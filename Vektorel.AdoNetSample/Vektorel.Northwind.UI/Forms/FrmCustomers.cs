using Microsoft.Data.SqlClient;
using System.Configuration;

namespace Vektorel.Northwind.UI.Forms
{
    public partial class FrmCustomers : Form
    {
        public FrmCustomers()
        {
            InitializeComponent();
        }
        private int page = 1;
        private const int PAGESIZE = 15;

        private void FrmCustomers_Load(object sender, EventArgs e)
        {
            btnPrevious.Enabled = false;
            using var connection = GetConnection();
            LoadCountries(connection);
            LoadCustomers(connection, page);
        }

        private void LoadCountries(SqlConnection connection)
        {
            // Ülkeler çekiliyor
            var countryQuery = "select distinct Country from Customers";
            using var countryCommand = new SqlCommand(countryQuery, connection);
            using var countryReader = countryCommand.ExecuteReader();
            while (countryReader.Read())
            {
                cmbCountries.Items.Add(countryReader["Country"].ToString());
            }

            // Normalde eklemeye gerek yok ama devamında aynı connection üzerinden yeni sorgu çalıştırılacağı için önceki kapatılmalı
            countryCommand.Dispose();
            countryReader.Close();
            //Ülkeler UI'da dolduruldu
        }

        private void LoadCustomers(SqlConnection connection, int page)
        {
            var offset = (page - 1) * PAGESIZE;
            // Müşteriler çekiliyor
            var customerQuery = @$"select CustomerID, CompanyName, ContactName, Phone, Country
                                  from Customers
                                  order by CompanyName
                                  offset {offset} rows
                                  fetch next {PAGESIZE} rows only";
            using var customerCommand = new SqlCommand(customerQuery, connection);
            using var customerReader = customerCommand.ExecuteReader();
            var list = new List<CustomerDTO>();
            while (customerReader.Read())
            {
                var customer = new CustomerDTO();
                customer.CustomerID = customerReader["CustomerID"].ToString();
                customer.CompanyName = customerReader["CompanyName"].ToString();
                customer.ContactName = customerReader["ContactName"].ToString();
                customer.Phone = customerReader["Phone"].ToString();
                customer.Country = customerReader["Country"].ToString();

                list.Add(customer);
            }

            if (list.Count == 0)
            {
                page--;
                btnPrevious.PerformClick();
                return;
            }
            if (list.Count < PAGESIZE)
            {
                btnNext.Enabled = false;
            }

            dgvTable.DataSource = null;
            dgvTable.DataSource = list;
            //Müşteriler UI'da
        }

        private SqlConnection GetConnection()
        {
            var connectionString = ConfigurationManager.AppSettings.Get("ConnStr");
            var connection = new SqlConnection(connectionString);
            connection.Open();

            return connection;
        }

        class CustomerDTO
        {
            public string CustomerID { get; set; }
            public string CompanyName { get; set; }
            public string ContactName { get; set; }
            public string Phone { get; set; }
            public string Country { get; set; }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            page++;
            using var connection = GetConnection();
            LoadCustomers(connection, page);
            btnPrevious.Enabled = true;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            page--;
            using var connection = GetConnection();
            LoadCustomers(connection, page);
            if (page == 1)
            {
                btnPrevious.Enabled = false;
            }
            btnNext.Enabled = true;
        }

    }
}
