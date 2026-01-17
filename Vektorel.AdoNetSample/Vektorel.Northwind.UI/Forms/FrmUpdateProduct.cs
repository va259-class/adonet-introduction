using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vektorel.Northwind.UI.Managers;
using Vektorel.Northwind.UI.Models;

namespace Vektorel.Northwind.UI.Forms
{
    public partial class FrmUpdateProduct : Form
    {
        private readonly DataManager dataManager;
        public FrmUpdateProduct()
        {
            InitializeComponent();
            dataManager = new DataManager();
        }

        private void txtProductId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var connection = dataManager.GetConnection();
                var query = "select ProductName as Name, UnitPrice as Price, UnitsInStock as Stock, CategoryID, SupplierID from Products where ProductID = @Id";
                var product = connection.QueryFirstOrDefault<ProductUpdateDTO>(query, new { Id = txtProductId.Text});

                if (product is not null)
                {
                    txtProductName.Text = product.Name;
                    nudPrice.Value = product.Price;
                    nudStok.Value = product.Stock;

                    var categories = cmbCategories.DataSource as List<DataOption>;
                    // Lambda expression
                    var selectedCategory = categories.First(f => f.Id == product.CategoryID);
                    cmbCategories.SelectedItem = selectedCategory;

                    var suppliers = cmbSuppliers.DataSource as List<DataOption>;
                    var selectedSupplier = suppliers.First(f => f.Id == product.SupplierID);
                    cmbSuppliers.SelectedItem = selectedSupplier;
                }
                else
                {
                    MessageBox.Show("Ürün bulunamadı");
                }
            }
        }

        private void FrmUpdateProduct_Load(object sender, EventArgs e)
        {
            var connection = dataManager.GetConnection();
            var categories = connection.Query<DataOption>("select CategoryID as Id, CategoryName as Label from Categories order by Label");
            var suppliers = connection.Query<DataOption>("select SupplierID as Id, CompanyName as Label from Suppliers order by Label");

            cmbCategories.DataSource = categories;
            cmbCategories.DisplayMember = nameof(DataOption.Label);
            cmbCategories.ValueMember = nameof(DataOption.Id);
            
            cmbSuppliers.DataSource = suppliers;
            cmbSuppliers.DisplayMember = nameof(DataOption.Label);
            cmbSuppliers.ValueMember = nameof(DataOption.Id);
        }
    }

    class ProductUpdateDTO
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int CategoryID { get; set; }
        public int SupplierID { get; set; }
    }
}
