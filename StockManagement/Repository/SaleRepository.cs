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
    public class SaleRepository
    {
        private SqlConnection sqlConnection = null;

        public bool AddSale(Sale sale)
        {
            string commandString = @"INSERT INTO Sales (Date, CustomerID, ProductID, Quantity, Price, DiscountPercentage) VALUES('" + sale.Date + "','" + sale.CustomerID + "'," + sale.ProductID + "," + sale.Quantity + "," + sale.Price + ", "+sale.DiscountPercentage+")";

            ConnectionDB connection = new ConnectionDB();
            sqlConnection = connection.CreateConnection();

            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            bool isAdded = connection.ExecuteQueries(commandString);

            sqlConnection.Close();

            return isAdded;
        }
    }
}
