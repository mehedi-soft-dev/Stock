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

        

        public List<Customer> Search(string searchKeyword)
        {
            List<Customer> customers = new List<Customer>();

            string commandString = @"SELECT * FROM Customers WHERE Name LIKE '%" + searchKeyword + "%' OR Code LIKE '%" + searchKeyword + "%'";
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
                customer.Contact = sqlDataReader["Contact"].ToString();
                customer.Email = sqlDataReader["Email"].ToString();
                customer.Address = sqlDataReader["Address"].ToString();
                customer.LoyalityPoint = Convert.ToInt32(sqlDataReader["LoyalityPoint"]);

                customers.Add(customer);
            }

            sqlConnection.Close();

            return customers;
        }

        public Customer SearchById(int id)
        {
            string commandString = @"SELECT * FROM Customers WHERE ID =" + id + "";
            ConnectionDB connection = new ConnectionDB();
            sqlConnection = connection.CreateConnection();

            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();
            
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            Customer _customer = new Customer();
            while (sqlDataReader.Read())
            {
                _customer.ID = Convert.ToInt32(sqlDataReader["ID"]);
                _customer.Code = sqlDataReader["Code"].ToString();
                _customer.Name = sqlDataReader["Name"].ToString();
                _customer.LoyalityPoint = Convert.ToInt32(sqlDataReader["LoyalityPoint"]);
            }

            sqlConnection.Close();

            return _customer;
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

        public bool IsCodeExist(string code)
        {
            string commandString = @"SELECT * FROM Cutomers WHERE Code = '" + code + "'";
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
            sqlConnection.Close();

            if (sqlDataReader.Read())
                return true;
            else
                return false;
            sqlConnection.Close();
        }
    }
}
