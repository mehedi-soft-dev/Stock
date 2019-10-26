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
    public class ProductRepository
    {
        private static SqlConnection sqlConnection = null;

        public bool AddProduct(Product product)
        {
            string commandString = @"INSERT INTO Products (CategoryID, Code, Name, ReOrderLevel, Description) VALUES('"+product.CategoryID+"', '" + product.Code + "','" + product.Name + "', "+product.ReOrderLevel+", '"+product.Description+"')";
            SqlConnection sqlConnection = null;

            ConnectionDB connection = new ConnectionDB();
            sqlConnection = connection.CreateConnection();

            sqlConnection.Open();

            bool isAdded = connection.ExecuteQueries(commandString);

            sqlConnection.Close();

            return isAdded;
        }

        public List<Product> Display()
        {
            List<Product> products = new List<Product>();

            string commandString = @"SELECT * FROM Products";
            SqlConnection sqlConnection = null;

            ConnectionDB connection = new ConnectionDB();
            sqlConnection = connection.CreateConnection();


            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                Product product = new Product();

                product.ID = Convert.ToInt32(sqlDataReader["ID"]);
                product.CategoryID = Convert.ToInt32(sqlDataReader["CategoryID"]);
                product.Code = sqlDataReader["Code"].ToString();
                product.Name = sqlDataReader["Name"].ToString();
                product.ReOrderLevel = Convert.ToInt32(sqlDataReader["ReOrderLevel"]);
                product.Description = sqlDataReader["Description"].ToString();

                products.Add(product);
            }

            sqlConnection.Close();

            return products;
        }

        public List<Product> GetProductsByCategory(int categoryId)
        {
            List<Product> products = new List<Product>();

            string commandString = @"SELECT * FROM Products WHERE CategoryID = "+categoryId+"";
            SqlConnection sqlConnection = null;

            ConnectionDB connection = new ConnectionDB();
            sqlConnection = connection.CreateConnection();


            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                Product product = new Product();

                product.ID = Convert.ToInt32(sqlDataReader["ID"]);
                product.CategoryID = Convert.ToInt32(sqlDataReader["CategoryID"]);
                product.Code = sqlDataReader["Code"].ToString();
                product.Name = sqlDataReader["Name"].ToString();
                product.ReOrderLevel = Convert.ToInt32(sqlDataReader["ReOrderLevel"]);
                product.Description = sqlDataReader["Description"].ToString();

                products.Add(product);
            }

            Product p = new Product();
            p.ID = 0;
            p.Name = "-SELECT-";
            products.Insert(0, p);

            sqlConnection.Close();

            return products;
        }

        public Product SearchProductById(int id)
        {
            string commandString = @"SELECT * FROM Products WHERE ID = " + id + "";
            SqlConnection sqlConnection = null;

            ConnectionDB connection = new ConnectionDB();
            sqlConnection = connection.CreateConnection();


            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            Product product = new Product();
            while (sqlDataReader.Read())
            {
                

                product.ID = Convert.ToInt32(sqlDataReader["ID"]);
                product.CategoryID = Convert.ToInt32(sqlDataReader["CategoryID"]);
                product.Code = sqlDataReader["Code"].ToString();
                product.Name = sqlDataReader["Name"].ToString();
                product.ReOrderLevel = Convert.ToInt32(sqlDataReader["ReOrderLevel"]);
                product.Description = sqlDataReader["Description"].ToString();
            }

            return product;
        }

        public bool IsCodeExist(string code)
        {
            string commandString = @"SELECT * FROM Products WHERE Code = '" + code + "'";
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
            string commandString = @"SELECT * FROM Products WHERE Name = '" + name + "'";
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

        public List<Product> Search(string searchKeyword)
        {
            List<Product> products = new List<Product>();

            string commandString = @"SELECT * FROM Products WHERE Name LIKE '%" + searchKeyword + "%' OR Code LIKE '%" + searchKeyword + "%'";
            ConnectionDB connection = new ConnectionDB();
            sqlConnection = connection.CreateConnection();

            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                Product product = new Product();

                product.ID = Convert.ToInt32(sqlDataReader["ID"]);
                product.Code = sqlDataReader["Code"].ToString();
                product.Name = sqlDataReader["Name"].ToString();
                product.CategoryID = Convert.ToInt32(sqlDataReader["CategoryID"]);
                product.ReOrderLevel = Convert.ToInt32(sqlDataReader["ReOrderLevel"]);
                product.Description = sqlDataReader["Description"].ToString();

                products.Add(product);
            }

            sqlConnection.Close();

            return products;
        }
    }
}
