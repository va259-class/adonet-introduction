using Microsoft.Data.SqlClient;
using System.Configuration;

namespace Vektorel.Northwind.UI.Forms
{
    public partial class FrmEmployees : Form
    {
        public FrmEmployees()
        {
            InitializeComponent();
        }

        private void FrmEmployees_Load(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadEmployees(txtSearch.Text);
        }

        private void LoadEmployees(string filter = null)
        {
            using var connection = GetConnection();
            var queryFilter = string.Empty;
            if (!string.IsNullOrWhiteSpace(filter))
            {
                queryFilter = @$"where FirstName like '{txtSearch.Text}%' or 
                                       LastName like '{txtSearch.Text}%' or
	                                   Country like '{txtSearch.Text}%' or
	                                   HomePhone like '%{txtSearch.Text}%'";    
            }

            var query = @$"select FirstName, LastName, Country, Title, HomePhone
                           from Employees
                           {queryFilter}";
            using var command = new SqlCommand(query, connection);
            using var reader = command.ExecuteReader();
            var list = new List<EmployeeDTO>();
            while (reader.Read())
            {
                var emp = new EmployeeDTO
                {
                    FirstName = reader[nameof(EmployeeDTO.FirstName)].ToString(),
                    LastName = reader[nameof(EmployeeDTO.LastName)].ToString(),
                    Country = reader[nameof(EmployeeDTO.Country)].ToString(),
                    Title = reader[nameof(EmployeeDTO.Title)].ToString(),
                    HomePhone = reader[nameof(EmployeeDTO.HomePhone)].ToString(),
                };
                list.Add(emp);
            }

            dgvEmployees.DataSource = null;
            dgvEmployees.DataSource = list;
        }

        private SqlConnection GetConnection()
        {
            var connectionString = ConfigurationManager.AppSettings.Get("ConnStr");
            var connection = new SqlConnection(connectionString);
            connection.Open();

            return connection;
        }

        class EmployeeDTO
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Country { get; set; }
            public string Title { get; set; }
            public string HomePhone { get; set; }
        }
    }
}
