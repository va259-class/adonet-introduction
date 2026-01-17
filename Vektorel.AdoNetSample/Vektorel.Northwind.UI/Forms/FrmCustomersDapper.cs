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

namespace Vektorel.Northwind.UI.Forms
{
    public partial class FrmCustomersDapper : Form
    {
        public FrmCustomersDapper()
        {
            InitializeComponent();
        }

        private void FrmCustomersDapper_Load(object sender, EventArgs e)
        {
            var dm = new DataManager();
            var connection = dm.GetConnection();
            var query = @"select CustomerID, 
                                 CompanyName as Company, 
                                 ContactName as Contact, 
                                 Phone 
                          from Customers";
            var customers = connection.Query<CustomerDTO>(query);
            dgvCustomers.DataSource = customers;
        }

        class CustomerDTO
        {
            public string CustomerID { get; set; }
            public string Company { get; set; }
            public string Contact { get; set; }
            public string Phone{ get; set; }
        }
    }
}
