using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace logLibrary
{
    public class DBConnection
    {
        private readonly string _connectionString;

        public DBConnection()
        {
            //veritabanını tanıtma
            _connectionString = "Data Source=.; Database=veri1; Integrated Security = True";
        }

        private SqlConnection GetSqlConnection()
        {
            //bağlantıyı açmak
            SqlConnection cnn = new SqlConnection(_connectionString);
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
                cnn.Open();
            }
            else
            {
                cnn.Open();
            }
            return cnn;
        }

        public SqlCommand GetSqlCommand()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = GetSqlConnection();

            return cmd;
        }
    }
    

}
