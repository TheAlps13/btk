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
        private SqlConnection _connection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;Initial Catalog=ETrade;Integrated Security=true");
        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
                _connection.Open();
        }
        public List<Product> GetAll()
        {
            // Connect to sql server with connection string

            ConnectionControl();
            // Execute sql command and read data as table
            SqlCommand command = new SqlCommand("SELECT * FROM Products", _connection);
            SqlDataReader reader = command.ExecuteReader();
            List<Product> products = new List<Product>();

            while (reader.Read())
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
            ConnectionControl();
            // Execute sql command and read data as table
            SqlCommand command = new SqlCommand("SELECT * FROM Products", _connection);
            SqlDataReader reader = command.ExecuteReader();
            // Load the data that sql command has returned
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            // Close connections and return DataTable
            _connection.Close();
            reader.Close();
            return dataTable;
        }

        public void Add(Product product)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("INSERT INTO Products VALUES(@name,@unitPrice,@stockAmount)", _connection);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void Update(Product product)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("UPDATE Products SET Name=@name,UnitPrice=@unitPrice,StockAmount=@stockAmount WHERE Id=@id", _connection);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            command.Parameters.AddWithValue("@id", product.Id);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void Delete(int id)
        {
            ConnectionControl();
            SqlCommand deleteCommand = new SqlCommand("DELETE Products WHERE Id=@id", _connection);
            deleteCommand.Parameters.AddWithValue("@id", id);
            deleteCommand.ExecuteNonQuery();

            _connection.Close();
        }
    }
}
