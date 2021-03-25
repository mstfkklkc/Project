using logLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace LogLibrary
{
    public class LogDal
    {
        private DBConnection dbConnection;

        public LogDal()
        {
            dbConnection = new DBConnection();
        }

        public DataTable GetAllItems()
        {
            //Veri tabanından verileri çeken fonksiyon
            SqlCommand cmd = dbConnection.GetSqlCommand();
            cmd.CommandText = "Select * from dbo.Table1";
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            return dt;
        }

        public void AddNewItem(string process, object dateTime)
        {
            //Veri tabanına verileri ekleyen fonksiyon
            string cmdText = "INSERT INTO [dbo].[Table1]([islem], [tarih])";
            cmdText += string.Format("values('{0}','{1}')", process, dateTime);

            SqlCommand cmd = dbConnection.GetSqlCommand();
            cmd.CommandText = cmdText;
            cmd.ExecuteNonQuery();

        }
    }
}
