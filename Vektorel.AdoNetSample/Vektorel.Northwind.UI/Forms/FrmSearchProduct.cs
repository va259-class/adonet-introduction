using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vektorel.Northwind.UI.Forms
{
    public partial class FrmSearchProduct : Form
    {
        public FrmSearchProduct()
        {
            InitializeComponent();
        }

        private void FrmSearchProduct_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadSuppliers();
        }

        private void LoadProducts()
        {
            using var connection = GetConnection();
            var query = @$"select p.ProductName, 
	                              p.UnitPrice, 
	                              p.UnitsInStock, 
	                              c.CategoryName, 
	                              s.CompanyName
                           from Products p
                           inner join Categories c on p.CategoryID = c.CategoryID
                           inner join Suppliers s on p.SupplierID = s.SupplierID";
        }

        private void LoadCategories()
        {
            using var connection = GetConnection();
            var query = @$"select CategoryId, 
	                              CategoryName
                           from Categories";
            using var command = new SqlCommand(query, connection);
            using var reader = command.ExecuteReader();
            var list = new List<ComboboxItem>();
            while (reader.Read())
            {
                var ci = new ComboboxItem
                {
                    Id = int.Parse(reader["CategoryID"].ToString()),
                    Name = reader["CategoryName"].ToString(),
                };
                list.Add(ci);
            }

            cmbCategories.DataSource = list;
            cmbCategories.DisplayMember = nameof(ComboboxItem.Name);
        }

        private void LoadSuppliers()
        {
            using var connection = GetConnection();
            var query = @$"select SupplierId, 
	                              CompanyName
                           from Suppliers
                           order by CompanyName";
            using var command = new SqlCommand(query, connection);
            using var reader = command.ExecuteReader();
            var list = new List<ComboboxItem>();
            while (reader.Read())
            {
                var ci = new ComboboxItem
                {
                    Id = int.Parse(reader["SupplierId"].ToString()),
                    Name = reader["CompanyName"].ToString(),
                };
                list.Add(ci);
            }

            cmbSuppliers.DataSource = list;
            cmbSuppliers.DisplayMember = "Name";
        }

        private SqlConnection GetConnection()
        {
            var connectionString = ConfigurationManager.AppSettings.Get("ConnStr");
            var connection = new SqlConnection(connectionString);
            connection.Open();

            return connection;
        }

        class ComboboxItem
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        class ProductDTO
        {
            public string ProductName { get; set; }
            public decimal UnitPrice { get; set; }
            public int UnitsInStock { get; set; }
            public string Category { get; set; }
            public string Supplier { get; set; }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbCategories.SelectedIndex = -1;
            cmbSuppliers.SelectedIndex = -1;
        }
    }
}
