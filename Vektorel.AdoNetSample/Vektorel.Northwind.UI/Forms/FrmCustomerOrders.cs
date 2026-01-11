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
    public partial class FrmCustomerOrders : Form
    {
        public FrmCustomerOrders()
        {
            InitializeComponent();
        }

        private void txtCustomerCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var query = @"select o.OrderID, 
	                                 o.OrderDate, 
	                                 concat(e.FirstName, ' ', e.LastName) as Seller, 
	                                 round(sum(od.Quantity * od.UnitPrice * (1 - od.Discount)), 2) as Total 
                              from Orders o
                              inner join Employees e on e.EmployeeID = o.EmployeeID
                              inner join [Order Details] od on o.OrderID = od.OrderID
                              where CustomerID = @p1
                              group by o.OrderID, o.OrderDate, concat(e.FirstName, ' ', e.LastName)";

                var dm = new DataManager();
                using var reader = dm.GetReader(query, txtCustomerCode.Text);
                var orders = new List<CustomerOrderDTO>();
                while (reader.Read())
                {
                    var row = new CustomerOrderDTO
                    {
                        OrderID = Convert.ToInt32(reader["OrderID"]),
                        OrderDate = Convert.ToDateTime(reader["OrderDate"]),
                        Seller = reader["Seller"].ToString(),
                        Total = Convert.ToDecimal(reader["Total"])
                    };

                    orders.Add(row);
                }

                dgvOrders.DataSource = null;
                dgvOrders.DataSource = orders;
                btnNewOrder.Enabled = true;
                return;
            }

        }

        private void FrmCustomerOrders_Load(object sender, EventArgs e)
        {
            var dm = new DataManager();
            using var reader = dm.GetReader("select CustomerId from Customers order by CustomerId");
            var customerList = new AutoCompleteStringCollection();

            while (reader.Read())
            {
                var name = reader.GetString(0);
                customerList.Add(name);
            }

            txtCustomerCode.AutoCompleteCustomSource = customerList;
            txtCustomerCode.AutoCompleteSource = AutoCompleteSource.CustomSource;
            btnNewOrder.Enabled = false;
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {

        }

        class CustomerOrderDTO
        {
            [DisplayName("Sipariş Numarası")]
            public int OrderID { get; set; }
            [DisplayName("Sipariş Tarihi")]
            public DateTime OrderDate { get; set; }
            [DisplayName("Satıcı")]
            public string Seller { get; set; }
            [DisplayName("Tutar")]
            public decimal Total { get; set; }
        }

        
    }
}
