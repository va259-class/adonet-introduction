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
    public partial class FrmNewCategory : Form
    {
        public FrmNewCategory()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using var connection = GetConnection();
            var query = @"insert into Categories (CategoryName, Description)
                          values (@p1, @p2)";
            var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@p1", txtName.Text);
            command.Parameters.AddWithValue("@p2", txtDescription.Text);
            var result = command.ExecuteNonQuery();

            if (result > 0)
            {
                MessageBox.Show("Kategori eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Clear();
                txtDescription.Clear();
            }
        }

        private SqlConnection GetConnection()
        {
            var connectionString = ConfigurationManager.AppSettings.Get("ConnStr");
            var connection = new SqlConnection(connectionString);
            connection.Open();

            return connection;
        }
    }
}
