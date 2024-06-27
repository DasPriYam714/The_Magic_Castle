using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Magic_Castle.DataAccess_layer
{
    class AdminDataAccess:DataAccess
    {
        public bool LoginValidation(string username, string password)
        {
            string sql = "SELECT * FROM Admins WHERE Username='" + username + "' AND Password='" + password + "'";
            SqlDataReader reader = this.Getdata(sql);
            if (reader.Read())
            {
                return true;
            }
            return false;
        }
    }
}
