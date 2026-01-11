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
    public partial class FrmCreateOrderDetail : Form
    {
        private readonly int orderId;
        private BindingList<ProductOrderDTO> details;

        public FrmCreateOrderDetail(int orderId)
        {
            InitializeComponent();
            this.orderId = orderId;
            this.Text += $" - {orderId}";
        }



        private void btnComplete_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var query = @"insert into [Order Details] (ProductID, OrderID, UnitPrice, Quantity)
                          values (@p1, @p2, @p3, @p4)";
            var dm = new DataManager();
            var product = cmbProducts.SelectedItem as ProductDTO;
            dm.Execute(query, product.ProductID,
                              orderId,
                              nudPrice.Value,
                              nudStock.Value);

            details.Add(new ProductOrderDTO
            {
                Product = product.ProductName,
                Price = nudPrice.Value,
                Quantity = nudStock.Value
            });
        }

        private void FrmCreateOrderDetail_Load(object sender, EventArgs e)
        {
            details = new BindingList<ProductOrderDTO>();
            dgvDetails.DataSource = details;

            var dm = new DataManager();
            var query = @"select ProductID, 
                                 ProductName 
                          from Products 
                          order by 1";
            using var reader = dm.GetReader(query);
            var employees = new List<ProductDTO>();
            while (reader.Read())
            {
                employees.Add(new ProductDTO
                {
                    ProductID = reader.GetInt32(0),
                    ProductName = reader.GetString(1),
                });
            }
            cmbProducts.DataSource = employees;
            cmbProducts.DisplayMember = "ProductName";
        }

        private void cmbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            var productId = (cmbProducts.SelectedItem as ProductDTO).ProductID;
            var query = @"select UnitPrice, UnitsInStock from Products 
                          where ProductID = @p1";
            var dm = new DataManager();
            using var reader = dm.GetReader(query, productId);
            if (reader.Read())
            {
                var stock = reader.GetInt16(1);
                nudStock.Maximum = stock;
                nudPrice.Value = Convert.ToDecimal(reader["UnitPrice"]);
                txtStock.Text = stock.ToString();
                if (stock == 0)
                {
                    btnAdd.Enabled = false;
                }
            }
        }

        class ProductDTO
        {
            public int ProductID { get; set; }
            public string ProductName { get; set; }
        }

        class ProductOrderDTO
        {
            [DisplayName("Ürün")]
            public string Product { get; set; }
            [DisplayName("Miktar")]
            public decimal Quantity { get; set; }
            [DisplayName("Fiyat")]
            public decimal Price { get; set; }
        }
    }
}
