using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Magic_Castle.DataAccess_layer
{
    class DataAccess
    {
        protected SqlConnection connnection;
        protected SqlCommand command;


        public DataAccess()
        {
            
            this.connnection = new SqlConnection(ConfigurationManager.ConnectionStrings["RMS"].ConnectionString);
            this.connnection.Open();
        }

        public SqlDataReader Getdata(string sql)
        {
            this.command = new SqlCommand(sql, connnection);
            return this.command.ExecuteReader();
        }

        public int ExecuteQuery(string sql)
        {
            this.command = new SqlCommand(sql, connnection);
            return this.command.ExecuteNonQuery();
        }

        //~DataAccess()
        //{
        //    this.connnection.Close();
        //}

    }
}
