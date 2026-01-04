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
    public partial class FrmNewProduct : Form
    {
        public FrmNewProduct()
        {
            InitializeComponent();
        }

        private void FrmNewProduct_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadSuppliers();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //öncesinde üsün adından arama yapıp doğrudan insert işlemini atlatmak iyi olabilir

            using var connection = GetConnection();
            var query = @"insert into Products (ProductName, UnitPrice, UnitsInStock, CategoryId, SupplierId)
                          values (@pn, @up, @us, @cat, @sup)";
            var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@pn", txtName.Text);
            command.Parameters.AddWithValue("@up", nudPrice.Value);
            command.Parameters.AddWithValue("@us", nudStock.Value);
            command.Parameters.AddWithValue("@cat", (cmbCategories.SelectedItem as ComboboxItem).Id);
            command.Parameters.AddWithValue("@sup", (cmbSuppliers.SelectedItem as ComboboxItem).Id);

            var result = command.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("Ürün eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Clear();
                nudStock.Value = 1;
                nudPrice.Value = 1;
                cmbCategories.SelectedIndex = -1;
                cmbSuppliers.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Ürün eklenemedi", "Hatalı işlem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

        
    }
}
