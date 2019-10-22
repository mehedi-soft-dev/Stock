using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using StockManagement.Model;

namespace StockManagement.Repository
{
    public class CategoryRepository
    {
        static SqlConnection sqlConnection = null;

        public bool AddCategory(Category category)
        {
            string commandString = @"INSERT INTO Categories (Code, Name) VALUES('" + category.Code + "','" + category.Name+ "')";

            ConnectionDB connection = new ConnectionDB();
            sqlConnection = connection.CreateConnection();

            sqlConnection.Open();

            bool isAdded = connection.ExecuteQueries(commandString);

            sqlConnection.Close();

            return isAdded;
        }

        public List<Category> Display()
        {
            List<Category> categories = new List<Category>();

            string commandString = @"SELECT * FROM Categories";

            ConnectionDB connection = new ConnectionDB();
            sqlConnection = connection.CreateConnection();
            
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                Category category = new Category();

                category.ID = Convert.ToInt32(sqlDataReader["ID"]);
                category.Code = sqlDataReader["Code"].ToString();
                category.Name = sqlDataReader["Name"].ToString();

                categories.Add(category);
            }

            sqlConnection.Close();

            return categories;
        }

        public List<Category> SearchByName(string searchKeyword)
        {
            List<Category> categories = new List<Category>();

            string commandString = @"SELECT * FROM Categories WHERE Name LIKE '%" + searchKeyword + "%'";
            ConnectionDB connection = new ConnectionDB();
            sqlConnection = connection.CreateConnection();
            
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                Category category = new Category();

                category.ID = Convert.ToInt32(sqlDataReader["ID"]);
                category.Code = sqlDataReader["Code"].ToString();
                category.Name = sqlDataReader["Name"].ToString();

                categories.Add(category);
            }

            sqlConnection.Close();

            return categories;
        }

        public List<Category> CategoryComboItem()
        {
            List<Category> categories = new List<Category>();

            string commandString = @"SELECT ID, Name FROM Categories";

            ConnectionDB connection = new ConnectionDB();
            sqlConnection = connection.CreateConnection();

            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                Category category = new Category();

                category.ID = Convert.ToInt32(sqlDataReader["ID"]);
                category.Name = sqlDataReader["Name"].ToString();

                categories.Add(category);
            }

            Category cat = new Category();
            cat.ID = 0;
            cat.Name = "-SELECT-";

            categories.Insert(0,cat);

            sqlConnection.Close();

            return categories;
        }
    }
}
