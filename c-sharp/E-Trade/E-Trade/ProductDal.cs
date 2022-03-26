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
        private SqlConnection _connection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;Initial Catalog=ETrade;integrated security=true");
        public List<Product> GetAll()
        {
            // Connect to sql server with connection string
           
            if (_connection.State == ConnectionState.Closed)
                _connection.Open();
            // Execute sql command and read data as table
            SqlCommand command = new SqlCommand("SELECT * FROM Products", _connection);
            SqlDataReader reader = command.ExecuteReader();
            List<Product> products = new List<Product>();
            
            while(reader.Read())
            {
                products.Add(new Product
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    StockAmount = Convert.ToInt32(reader["StockAmount"]),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"])
                });
            }
            _connection.Close();
            reader.Close();
            return products;
        }

        public DataTable GetAll_Dtb()
        {   // Connect to sql server with connection string
            SqlConnection _connection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;Initial Catalog=Etrade;integrated security=true");
            if (_connection.State == ConnectionState.Closed)
                _connection.Open();
            // Execute sql command and read data as table
            SqlCommand command = new SqlCommand("SELECT * FROM Products", _connection);
            SqlDataReader reader = command.ExecuteReader();
            // Load the data that sql command has returned
            DataTable dataTable = new();
            dataTable.Load(reader);
            // Close connections and return DataTable
            _connection.Close();
            reader.Close();
            return dataTable;
        }

        public void Add(Product product)
        {

        }
    }
}
