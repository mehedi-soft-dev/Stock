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
    public class CustomerRepository
    {
        static SqlConnection sqlConnection = null;

        public bool AddCustomer(Customer customer)
        {
            string commandString = @"INSERT INTO Customers (Code, Name, Address, Email, Contact, LoyalityPoint) VALUES('" + customer.Code + "','" + customer.Name + "','" + customer.Address + "','" + customer.Email + "','" + customer.Contact + "'," + customer.LoyalityPoint + ")";

            ConnectionDB connection = new ConnectionDB();
            sqlConnection = connection.CreateConnection();

            sqlConnection.Open();

            bool isAdded = connection.ExecuteQueries(commandString);

            sqlConnection.Close();

            return isAdded;
        }

        public List<Customer> Display()
        {
            List<Customer> customers = new List<Customer>();

            string commandString = @"SELECT * FROM Customers";

            ConnectionDB connection = new ConnectionDB();
            sqlConnection = connection.CreateConnection();

            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                Customer customer = new Customer();

                customer.ID = Convert.ToInt32(sqlDataReader["ID"]);
                customer.Code = sqlDataReader["Code"].ToString();
                customer.Name = sqlDataReader["Name"].ToString();
                customer.Address = sqlDataReader["Address"].ToString();
                customer.Email = sqlDataReader["Email"].ToString();
                customer.Contact = sqlDataReader["Contact"].ToString();
                customer.LoyalityPoint = Convert.ToInt32(sqlDataReader["LoyalityPoint"]);

                customers.Add(customer);
            }

            sqlConnection.Close();

            return customers;
        }

        public List<Customer> SearchByName(string searchKeyword)
        {
            List<Customer> customers = new List<Customer>();

            string commandString = @"SELECT * FROM Customers WHERE Name LIKE '%" + searchKeyword + "%'";
            ConnectionDB connection = new ConnectionDB();
            sqlConnection = connection.CreateConnection();

            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                Customer customer = new Customer();

                customer.ID = Convert.ToInt32(sqlDataReader["ID"]);
                customer.Code = sqlDataReader["Code"].ToString();
                customer.Name = sqlDataReader["Name"].ToString();

               customers.Add(customer);
            }

            sqlConnection.Close();

            return customers;
        }

        public List<Customer> CustomerComboItem()
        {
            List<Customer> customers = new List<Customer>();

            string commandString = @"SELECT ID, Name FROM Customers";
            ConnectionDB connection = new ConnectionDB();
            sqlConnection = connection.CreateConnection();

            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                Customer customer = new Customer();

                customer.ID = Convert.ToInt32(sqlDataReader["ID"]);
                customer.Name = sqlDataReader["Name"].ToString();

                customers.Add(customer);
            }

            Customer cus = new Customer();
            cus.ID = 0;
            cus.Name = "-SELECT-";

            customers.Insert(0, cus);

            sqlConnection.Close();

            return customers;
        }
    }
}
