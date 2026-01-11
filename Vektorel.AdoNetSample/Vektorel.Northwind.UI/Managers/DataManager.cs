using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektorel.Northwind.UI.Managers
{
    internal class DataManager
    {
        public SqlDataReader GetReader(string query, params object[] parameters)
        {
            var connection = GetConnection();
            var command = connection.CreateCommand();
            command.Connection = connection;
            command.CommandText = query;

            var p = 1;
            foreach (var parameter in parameters) 
            { 
                command.Parameters.AddWithValue($"p{p++}", parameter);
            }

            return command.ExecuteReader();
        }

        private SqlConnection GetConnection()
        {
            var connectionString = ConfigurationManager.AppSettings.Get("ConnStr");
            var connection = new SqlConnection(connectionString);
            connection.Open();

            return connection;
        }

        //public void A(params int[] parameters)
        //{
        //    A(new int[0] { });
        //    A(new int[1] { 1 });
        //    A(new int[2] { 1, 2 });
        //    A(1, 2, 3);
        //    A(1, 2, 3, 4);
        //    A(1, 2, 3, 4, 5, 6, 7, 11, 8, 9, 10);
        //}
    }
}
