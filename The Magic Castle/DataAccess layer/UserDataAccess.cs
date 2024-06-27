using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Magic_Castle.Entity_classes;

namespace The_Magic_Castle.DataAccess_layer
{
    class UserDataAccess:DataAccess
    {
        public bool UserRegister(User user)
        {
            string sql = "INSERT INTO Users(Name,Username,Email,Password,DateOfBirth,BloodGroup) VALUES('" + user.Name + "','" + user.Username + "','" + user.Email + "','" + user.Password + "','" + user.DateOfBirth + "','" + user.BloodGroup + "')";
            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            return false;
        }

        public bool LoginValidation(string Username, string password)
        {
            string sql = "SELECT * FROM Users WHERE Username='" + Username + "' AND Password='" + password + "'";
            SqlDataReader reader = this.Getdata(sql);
            if (reader.Read())
            {
                return true;
            }
            return false;
        }


        public List<User> GetAllUser()
        {
            string sql = "SELECT * FROM Users";
            SqlDataReader reader = this.Getdata(sql);
            List<User> user = new List<User>();
            while (reader.Read())
            {
                User users= new User();
                users.Id = (int)reader["Id"];
                users.Name = reader["Name"].ToString();
                users.Username = reader["Username"].ToString();
                users.Email = reader["Email"].ToString();
                users.Password = reader["Password"].ToString();
                users.DateOfBirth = reader["DateOfBirth"].ToString();
                users.BloodGroup = reader["BloodGroup"].ToString();
                user.Add(users);
            }
            return user;
        }

        public bool UpdateUser(int id, string Name,string username, string email, string password )
        {
            string sql = "UPDATE Users SET Name='" + Name + "',Username='" + username + "',Email='" + email + "',Password='" + password + "'  WHERE Id=" + id;
            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            return false;
        }

        public bool DeleteUser(int id)
        {
            string sql = "DELETE FROM Users WHERE Id=" + id;
            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            return false;
        }

        public List<string> GetAllBloodGroup()
        {
            string sql = "SELECT * FROM Users";
            SqlDataReader reader = this.Getdata(sql);
            List<string> bloodGroup = new List<string>();
            while (reader.Read())
            {
                bloodGroup.Add(reader["BloodGroup"].ToString());
            }
            return bloodGroup;
        }

        public string GetBloodGroupNameById(int id)
        {
            string sql = "SELECT * FROM Users WHERE Id=" + id;
            SqlDataReader reader = this.Getdata(sql);
            if (reader.Read())
            {
                return reader["BloodGroup"].ToString();
            }
            return null;
        }

        public List<User> GetUserByName(string username)
        {
            string sql = "SELECT * FROM Users WHERE Username LIKE '" + username + "%'";
            SqlDataReader reader = this.Getdata(sql);
            List<User> users = new List<User>();
            while (reader.Read())
            {
                User user = new User();
                user.Id = (int)reader["Id"];
                user.Name = reader["Name"].ToString();
                user.Username = reader["Username"].ToString();
                user.Email = reader["Email"].ToString();
                user.Password = reader["Password"].ToString();
                user.DateOfBirth = reader["DateOfBirth"].ToString();
                user.BloodGroup = reader["BloodGroup"].ToString();
                users.Add(user);
            }
            return users;
        }
    }
}
