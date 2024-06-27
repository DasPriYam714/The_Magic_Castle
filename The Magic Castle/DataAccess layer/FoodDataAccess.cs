using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Magic_Castle.Entity_classes;

namespace The_Magic_Castle.DataAccess_layer
{
    class FoodDataAccess:DataAccess
    {
        public List<Food> GetAllFood()
        {
            string sql = "SELECT * FROM FoodList";
            SqlDataReader reader = this.Getdata(sql);
            List<Food> foods = new List<Food>();
            while (reader.Read())
            {
                Food food = new Food();
                food.Id = (int)reader["Id"];
                food.FoodName = reader["FoodName"].ToString();
                food.Item = reader["Item"].ToString();
                food.Price = Convert.ToDouble(reader["Price"]);
                food.CategoryId = (int)reader["CategoryId"];
                foods.Add(food);
            }
            return foods;
        }

        public bool AddNewFood(string foodName,string item, double price, int categoryId)
        {
            string sql = "INSERT INTO FoodList(FoodName,Item,Price,CategoryId) VALUES('" + foodName + "','" + item + "'," + price + "," + categoryId + ")";
            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            return false;
        }

        public bool UpdateFood(int id, string foodName, string item, double price, int categoryId)
        {
            string sql = "UPDATE Foodlist SET FoodName='" + foodName + "',Item='" + item + "',Price=" + price + ",CategoryId=" + categoryId + " WHERE Id=" + id;
            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            return false;
        }

        public bool DeleteFood(int id)
        {
            string sql = "DELETE FROM FoodList WHERE Id=" + id;
            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            return false;
        }


        public List<Food> GetAllProductsByCategoryId(int categoryId)
        {
            string sql = "SELECT * FROM Foodlist WHERE CategoryId=" + categoryId;
            SqlDataReader reader = this.Getdata(sql);
            List<Food> foods = new List<Food>();
            while (reader.Read())
            {
                Food food = new Food();
                food.Id = (int)reader["Id"];
                food.FoodName = reader["FoodName"].ToString();
                food.Item = reader["Item"].ToString();
                food.Price = Convert.ToDouble(reader["Price"]);
                food.CategoryId = (int)reader["CategoryId"];
                foods.Add(food);
            }
            return foods;
        }


        public List<Food> GetFoodByName(string foodName)
        {
            string sql = "SELECT * FROM FoodList WHERE FoodName LIKE '" + foodName + "%'";
            SqlDataReader reader = this.Getdata(sql);
            List<Food> foods = new List<Food>();
            while (reader.Read())
            {
                Food food = new Food();
                food.Id = (int)reader["Id"];
                food.FoodName = reader["FoodName"].ToString();
                food.Item = reader["Item"].ToString();
                food.Price = Convert.ToDouble(reader["Price"]);
                food.CategoryId = (int)reader["CategoryId"];
                foods.Add(food);
            }
            return foods;
        }
    }
}
