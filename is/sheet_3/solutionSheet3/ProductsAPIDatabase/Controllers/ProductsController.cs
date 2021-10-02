using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProductsAPIDatabase.Models;
using System.Data.SqlClient;
namespace ProductsAPIDatabase.Controllers
{
    public class ProductsController : ApiController
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DDProds.mdf;Integrated Security=True";

        // GET: api/Products
        [Route("api/products")]
        public IEnumerable<Product> GetAllProducts()
        {
            List<Product> prods = new List<Product>();
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();

                string sql = "SELECT * FROM prods";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    Product p = new Product
                    {
                        Id = (int)dataReader["Id"],
                        Name = (string)dataReader["Name"],
                        Category = dataReader["Category"] == DBNull.Value ? "" : (string)dataReader["Category"],
                        Price = dataReader["Price"] == DBNull.Value ? 0 : Convert.ToDecimal(dataReader["Price"])
                    };
                    prods.Add(p);
                }
                dataReader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {

                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }

            return prods;
        }

        // GET: api/Products/5
        [Route("api/products/{id:int}")]
        public IHttpActionResult GetProductById(int id)
        {
            List<Product> prods = new List<Product>();
            SqlConnection connection = null;
            Product p = null;
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();

                string sql = "SELECT * FROM prods WHERE Id = @id";

                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("id", id);
                SqlDataReader dataReader = command.ExecuteReader();
                dataReader.Read();
                p =  new Product
                {
                    Id = (int)dataReader["Id"],
                    Name = (string)dataReader["Name"],
                    Category = dataReader["Category"] == DBNull.Value ? "" : (string)dataReader["Category"],
                    Price = dataReader["Price"] == DBNull.Value ? 0 : Convert.ToDecimal(dataReader["Price"])
                };
                dataReader.Close();
                connection.Close();
            }
            catch (Exception)
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
                return InternalServerError();
            }
            if (p == null)
            {
                return NotFound();
            }
            return Ok(p);

        }

        // GET: api/Products/5
        [Route("api/products/{category}")]
        public IHttpActionResult GetProductByCategory(string category)
        {
            List<Product> prods = new List<Product>();
            SqlConnection connection = null;
            Product p = null;
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();

                string sql = "SELECT * FROM prods WHERE Category = @category";

                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("category", category);
                SqlDataReader dataReader = command.ExecuteReader();
                dataReader.Read();
                p = new Product
                {
                    Id = (int)dataReader["Id"],
                    Name = (string)dataReader["Name"],
                    Category = dataReader["Category"] == DBNull.Value ? "" : (string)dataReader["Category"],
                    Price = dataReader["Price"] == DBNull.Value ? 0 : Convert.ToDecimal(dataReader["Price"])
                };
                dataReader.Close();
                connection.Close();
            }
            catch (Exception)
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
                return InternalServerError();
            }
            if (p == null)
            {
                return NotFound();
            }
            return Ok(p);

        }

        // POST: api/Products
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Products/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Products/5
        public void Delete(int id)
        {
        }
    }
}
