using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Security.Policy;
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

            //string commandString = @"SELECT * FROM Categories WHERE Name LIKE '%" + searchKeyword + "%'";
            string commandString = @"SELECT * FROM Categories WHERE Name LIKE '%" + searchKeyword + "%' OR Code LIKE '%" + searchKeyword + "%'";
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

        public bool IsCodeExist(string code)
        {
            string commandString = @"SELECT * FROM Categories WHERE Code = '" + code + "'";
            ConnectionDB connection = new ConnectionDB();
            sqlConnection = connection.CreateConnection();

            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            

            if (sqlDataReader.Read())
                return true;
            else
                return false;

            sqlConnection.Close();
        }

        public bool IsNameExist(string name)
        {
            string commandString = @"SELECT * FROM Categories WHERE Name = '" + name + "'";
            ConnectionDB connection = new ConnectionDB();
            sqlConnection = connection.CreateConnection();

            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            

            if (sqlDataReader.Read())
                return true;
            else
                return false;
            sqlConnection.Close();

        }
    }
}
