using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Repository
{
    public class ConnectionDB
    {
        string connectionString = @"Server=MH-PC\SQLEXPRESS; Database=RB_StockManagement; Integrated Security=True";
        SqlConnection con = null;

        public SqlConnection CreateConnection()
        {
            con = new SqlConnection(connectionString);
            return con;
        }

        public bool ExecuteQueries(string Query_)
        {
            SqlCommand cmd = new SqlCommand(Query_, con);
            int isExecute = cmd.ExecuteNonQuery();

            if (isExecute > 0)
                return true;
            else
                return false;
        }
    }
}
