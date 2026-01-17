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
    public partial class FrmNewEmployee : Form
    {
        public FrmNewEmployee()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var query = @"insert into Employees
                            (FirstName, LastName, HireDate, BirthDate, Country, City, HomePhone, Title)
                          values
                            (@FirstName, @LastName, @HireDate, @BirthDate, @Country, @City, @Phone, @Title)";
            var dm = new DataManager();
            var connection = dm.GetConnection();
            var affectedRow = connection.Execute(query, 
                                                 new NewEmployeeDTO 
                                                 {
                                                     FirstName = txtFirstName.Text,
                                                     LastName = txtLastName.Text,
                                                     BirthDate = dtpBirthDate.Value,
                                                     HireDate = dtpHireDate.Value,
                                                     Country = txtCountry.Text,
                                                     City = txtCity.Text,
                                                     Phone = txtPhone.Text,
                                                     Title = txtTitle.Text
                                                 });

            if (affectedRow > 0)
            {
                MessageBox.Show("Kayıt başarılı");
            }
        }
    }

    class NewEmployeeDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime BirthDate { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Title { get; set; }
    }
}
