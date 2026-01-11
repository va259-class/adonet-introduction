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
    public partial class FrmNewOrder : Form
    {
        private readonly string customerId;
        private readonly double fright = 2;

        public FrmNewOrder(string customerId)
        {
            InitializeComponent();
            this.customerId = customerId;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var query = @"insert into Orders 
                            (CustomerID, EmployeeID, OrderDate, RequiredDate, Freight)
                          values (@p1, @p2, @p3, @p4, @p5)";
            var dm = new DataManager();
            var employeeId = (cmbEmployee.SelectedItem as EmployeeDTO).EmployeeID;
            dm.Execute(query, customerId, 
                              employeeId, 
                              dtpOrderDate.Value, 
                              dtpOrderDate.Value.AddDays(3), 
                              fright);

            using var reader = dm.GetReader(@"select top 1 OrderID 
                                              from Orders 
                                              where CustomerID = @p1 
                                              order by OrderID desc", 
                                              txtCustomer.Text);
            if (reader.Read())
            {
                var orderId = Convert.ToInt32(reader["OrderID"]);
                var f = new FrmCreateOrderDetail(orderId);
                f.ShowDialog();
            }
        }

        private void FrmNewOrder_Load(object sender, EventArgs e)
        {
            txtTotal.Text = "0";
            txtCustomer.Text = customerId;

            var dm = new DataManager();
            var query = @"select EmployeeID, 
                                 concat(FirstName, ' ', LastName) FullName 
                          from Employees 
                          order by 1";
            using var reader = dm.GetReader(query);
            var employees = new List<EmployeeDTO>();
            while (reader.Read())
            {
                employees.Add(new EmployeeDTO
                {
                    EmployeeID = reader.GetInt32(0),
                    FullName = reader.GetString(1),
                });
            }
            cmbEmployee.DataSource = employees;
            cmbEmployee.DisplayMember = "FullName";
        }

        class EmployeeDTO
        {
            public int EmployeeID { get; set; }
            public string FullName { get; set; }
        }
    }
}
