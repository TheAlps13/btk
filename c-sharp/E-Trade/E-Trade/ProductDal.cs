using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade
{
    public class ProductDal
    {
        public DataTable GetAll()
        {   // Connect to sql server with connection string
            SqlConnection connection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;Initial Catalog=ETrade;integrated security=true");
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            // Execute sql command and read data as table
            SqlCommand command = new SqlCommand("SELECT * FROM Products", connection);
            SqlDataReader reader = command.ExecuteReader();
            // Load the data that sql command has returned
            DataTable dataTable = new();
            dataTable.Load(reader);
            // Close connections and return DataTable
            connection.Close();
            reader.Close();
            return dataTable;
        }
    }
}
