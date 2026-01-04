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
    public partial class FrmSuppliers : Form
    {
        public FrmSuppliers()
        {
            InitializeComponent();
        }

        private void FrmSuppliers_Load(object sender, EventArgs e)
        {
            LoadSuppliers();
        }

        private void LoadSuppliers()
        {
            using var connection = GetConnection();
            var query = @"select Country, City, CompanyName, 
	                             Phone, ContactName, ContactTitle 
                          from Suppliers";

            using var command = new SqlCommand(query, connection);
            using var reader = command.ExecuteReader();
            var countries = new List<string>();
            var suppliers = new List<SupplierDTO>();
            while (reader.Read())
            {
                var supplier = new SupplierDTO
                {
                    Country = reader["Country"].ToString(),
                    City = reader["City"].ToString(),
                    CompanyName = reader["CompanyName"].ToString(),
                    Phone = reader["Phone"].ToString(),
                    ContactName = reader["ContactName"].ToString(),
                    ContactTitle = reader["ContactTitle"].ToString(),
                };

                suppliers.Add(supplier);
                if (!countries.Contains(supplier.Country))
                {
                    countries.Add(supplier.Country);
                }
            }

            foreach (var country in countries)
            {
                var group = new ListViewGroup(country, country);
                group.CollapsedState = ListViewGroupCollapsedState.Collapsed;
                lstSupplier.Groups.Add(group);
            }

            foreach (var supplier in suppliers)
            {
                var item = new ListViewItem(supplier.CompanyName);
                item.SubItems.Add(supplier.ContactName);
                item.SubItems.Add(supplier.Phone);
                item.SubItems.Add(supplier.City);
                item.SubItems.Add(supplier.ContactTitle);

                var group = lstSupplier.Groups[supplier.Country];
                item.Group = group;

                lstSupplier.Items.Add(item);
            }
        }

        private SqlConnection GetConnection()
        {
            var connectionString = ConfigurationManager.AppSettings.Get("ConnStr");
            var connection = new SqlConnection(connectionString);
            connection.Open();

            return connection;
        }

        class SupplierDTO
        {
            public string Country { get; set; }
            public string City { get; set; }
            public string CompanyName { get; set; }
            public string Phone { get; set; }
            public string ContactName { get; set; }
            public string ContactTitle { get; set; }
        }
    }
}
