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

namespace Vektorel.Northwind.UI.Forms
{
    public partial class FrmProductSales : Form
    {
        private bool stillLoading;
        private BindingList<ProductOrderDTO> productOrders;
        public FrmProductSales()
        {
            InitializeComponent();
        }

        private void FrmProductSales_Load(object sender, EventArgs e)
        {
            productOrders = new BindingList<ProductOrderDTO>();
            dgvOrders.DataSource = productOrders;

            stillLoading = true;
            var dm = new DataManager();
            var query = "select ProductID, ProductName from Products order by ProductName";
            using var reader = dm.GetReader(query);
            var products = new List<ProductDTO>();
            while (reader.Read())
            {
                products.Add(new ProductDTO
                {
                    ProductID = Convert.ToInt32(reader["ProductID"]),
                    ProductName = reader["ProductName"].ToString()
                });
            }

            cmbProducts.DataSource = products;
            cmbProducts.DisplayMember = "ProductName";
            cmbProducts.SelectedIndex = 0;

            cmbYears.Items.AddRange([1996, 1997, 1998]); // yeni dizi yazım formatı
            cmbYears.SelectedIndex = 0;

            stillLoading = false;
            LoadProducts();
        }

        private void LoadProducts()
        {
            if (stillLoading)
            {
                return;
            }
            var query = @"select o.OrderDate, od.UnitPrice, od. Quantity
                          from Orders o
                          inner join [Order Details] od on o.OrderID = od.OrderID
                          where od.ProductID = @p1 and 
	                            DATEPART(year, o.OrderDate) = @p2";
            var dm = new DataManager();
            var productId = (cmbProducts.SelectedItem as ProductDTO).ProductID;
            var year = Convert.ToInt32(cmbYears.SelectedItem);
            using var reader = dm.GetReader(query, productId, year);
            productOrders.Clear();
            while (reader.Read())
            {
                productOrders.Add(new ProductOrderDTO
                {
                    OrderDate = Convert.ToDateTime(reader["OrderDate"]),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"]),
                    Quantity = Convert.ToInt32(reader["Quantity"]),
                });
            }

            txtTotal.Text = productOrders.Sum(s => s.SubTotal).ToString();
        }

        private void cmbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void cmbYears_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProducts();
        }

        class ProductDTO
        {
            public int ProductID { get; set; }
            public string ProductName { get; set; }
        }

        class ProductOrderDTO
        {
            public DateTime OrderDate { get; set; }
            public decimal UnitPrice { get; set; }
            public int Quantity { get; set; }
            public decimal SubTotal { get { return UnitPrice * Quantity; } }
        }
    }
}
