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
    public class PurchaseRepository
    {
        static SqlConnection sqlConnection = null;

        public bool AddPurchase(Purchase purchase)
        {
            string commandString;

            if (purchase.ManufactureDate == null && purchase.ExpireDate == null)
                commandString = @"INSERT INTO Purchases (Date, InvoiceNo, SupplierID, ProductID, Quantity, UnitPrice, MRP) VALUES('" + purchase.Date + "','" + purchase.InvoiceNo + "'," + purchase.SupplierID + "," + purchase.ProductID + ", " + purchase.Quantity + "," + purchase.UnitPrice + "," + purchase.MRP + ")";
            else
                commandString = @"INSERT INTO Purchases (Date, InvoiceNo, SupplierID, ProductID, ManufacturedDate, ExpireDate, Quantity, UnitPrice, MRP) VALUES('" + purchase.Date + "','" + purchase.InvoiceNo + "'," + purchase.SupplierID + "," + purchase.ProductID + ",'"+purchase.ManufactureDate+"','"+purchase.ExpireDate+"', " + purchase.Quantity + "," + purchase.UnitPrice + "," + purchase.MRP + ")";

            ConnectionDB connection = new ConnectionDB();
            sqlConnection = connection.CreateConnection();

            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            bool isAdded = connection.ExecuteQueries(commandString);

            sqlConnection.Close();

            return isAdded;
        }

        public Purchase LastPurchaseInfo(int productId)
        {
            string commandString = @"SELECT UnitPrice, MRP FROM Purchases WHERE ID IN(SELECT max(ID) FROM Purchases WHERE ProductID = "+productId+")";
            ConnectionDB connection = new ConnectionDB();
            sqlConnection = connection.CreateConnection();

            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            Purchase purchase = new Purchase();
            while (sqlDataReader.Read())
            {
                purchase = new Purchase();

                //purchase.ID = Convert.ToInt32(sqlDataReader["ID"]);
                purchase.UnitPrice = Convert.ToDouble(sqlDataReader["UnitPrice"]);
                purchase.MRP = Convert.ToDouble(sqlDataReader["MRP"]);

            }

            sqlConnection.Close();

            return purchase;
        }

        public int AvailableQuantity(int productId)
        {
            string commandString = @"Select * FROM AvailableQuantity WHERE ProductID = " + productId+"";
            ConnectionDB connection = new ConnectionDB();
            sqlConnection = connection.CreateConnection();

            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            //Purchase purchase = new Purchase();
            int qty = 0;
            while (sqlDataReader.Read())
            {
                qty= Convert.ToInt32(sqlDataReader["Quantity"]);
            }

            sqlConnection.Close();

            return qty;
        }
    
    }
}
