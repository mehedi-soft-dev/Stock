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
    public class SupplierRepository
    {
        static SqlConnection sqlConnection = null;

        public bool AddSupplier(Supplier supplier)
        {
            string commandString = @"INSERT INTO Suppliers (Code, Name, Address, Email, Contact, ContactPerson) VALUES('" + supplier.Code + "','" + supplier.Name + "','" + supplier.Address + "','" + supplier.Email + "','" + supplier.Contact + "','" + supplier.ContactPerson + "')";

            ConnectionDB connection = new ConnectionDB();
            sqlConnection = connection.CreateConnection();

            sqlConnection.Open();

            bool isAdded = connection.ExecuteQueries(commandString);

            sqlConnection.Close();

            return isAdded;
        }

        public List<Supplier> Display()
        {
            List<Supplier> suppliers = new List<Supplier>();

            string commandString = @"SELECT * FROM Suppliers";

            ConnectionDB connection = new ConnectionDB();
            sqlConnection = connection.CreateConnection();

            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                Supplier supplier = new Supplier();

                supplier.ID = Convert.ToInt32(sqlDataReader["ID"]);
                supplier.Code = sqlDataReader["Code"].ToString();
                supplier.Name = sqlDataReader["Name"].ToString();
                supplier.Address = sqlDataReader["Address"].ToString();
                supplier.Email = sqlDataReader["Email"].ToString();
                supplier.Contact = sqlDataReader["Contact"].ToString();
                supplier.ContactPerson = sqlDataReader["ContactPerson"].ToString();

                suppliers.Add(supplier);
            }

            sqlConnection.Close();

            return suppliers;
        }

        public List<Supplier> SupplierComboItem()
        {
            List<Supplier> suppliers = new List<Supplier>();

            string commandString = @"SELECT ID, Name FROM Suppliers";

            ConnectionDB connection = new ConnectionDB();
            sqlConnection = connection.CreateConnection();

            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                Supplier supplier = new Supplier();

                supplier.ID = Convert.ToInt32(sqlDataReader["ID"]);
                supplier.Name = sqlDataReader["Name"].ToString();
                
                suppliers.Add(supplier);
            }

            Supplier s = new Supplier();
            s.ID = 0;
            s.Name = "-SELECT-";
            suppliers.Insert(0,s);

            sqlConnection.Close();

            return suppliers;
        }

        public List<Supplier> Search(string searchKeyword)
        {
            List<Supplier> suppliers = new List<Supplier>();

            string commandString = @"SELECT * FROM Suppliers WHERE Name LIKE '%" + searchKeyword + "%' OR Code LIKE '%" + searchKeyword + "%'";
            ConnectionDB connection = new ConnectionDB();
            sqlConnection = connection.CreateConnection();

            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                Supplier supplier = new Supplier();

                supplier.ID = Convert.ToInt32(sqlDataReader["ID"]);
                supplier.Code = sqlDataReader["Code"].ToString();
                supplier.Name = sqlDataReader["Name"].ToString();
                supplier.Contact = sqlDataReader["Contact"].ToString();
                supplier.Email = sqlDataReader["Email"].ToString();
                supplier.Address = sqlDataReader["Address"].ToString();
                supplier.ContactPerson = sqlDataReader["ContactPerson"].ToString();

                suppliers.Add(supplier);
            }

            sqlConnection.Close();

            return suppliers;
        }


        public bool IsCodeExist(string code)
        {
            string commandString = @"SELECT * FROM Suppliers WHERE Code = '" + code + "'";
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
            string commandString = @"SELECT * FROM Suppliers WHERE Name = '" + name + "'";
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
