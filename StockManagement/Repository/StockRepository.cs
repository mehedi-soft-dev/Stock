using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using  StockManagement.Model;

namespace StockManagement.Repository
{
    public class StockRepository
    {
        private static SqlConnection sqlConnection = null;

        public List<Stock> FullStocks()
        {
            List<Stock> stocks = new List<Stock>();

            string commandString = @"Select * FROM ST";
            ConnectionDB connection = new ConnectionDB();
            sqlConnection = connection.CreateConnection();

            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            //Purchase purchase = new Purchase();
            
            while (sqlDataReader.Read())
            {
                Stock stock = new Stock();

                stock.Code = sqlDataReader["Code"].ToString();
                stock.Name = sqlDataReader["Name"].ToString();
                //stock.OpeningBalance = Convert.ToInt32(sqlDataReader["OpeningBalance"]);
                stock.In = Convert.ToInt32(sqlDataReader["In"]);
                stock.Out = Convert.ToInt32(sqlDataReader["OUt"]);
                stock.ClosingBalanace = Convert.ToInt32(sqlDataReader["ClosingBalance"]);

                stocks.Add(stock);
            }

            sqlConnection.Close();

            return stocks;
        }
    }
}
