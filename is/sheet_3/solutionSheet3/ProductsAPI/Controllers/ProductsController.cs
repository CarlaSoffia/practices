using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProductsAPI.Models;

namespace ProductsAPI.Controllers
{
    public class ProductsController : ApiController
    {
        List<Product> products = new List<Product>()
        {
            new Product {Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
            new Product {Id = 2, Name = "Yo-yo", Category = "Toys", Price = 2.3M},
            new Product {Id = 3, Name = "Hammer", Category = "Hardware", Price = 15.3M}
        };
        // GET: api/Products
        //[HttpGet] - force to respond to a get
        [Route("api/products")]
        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        // GET: api/Products/5
        [Route("api/products/{id:int}")]
        public IHttpActionResult GetProductById(int id)
        {
            var prod = products.FirstOrDefault(i => i.Id == id);
            if (prod == null) { 
                return NotFound(); 
            }
            return Ok(prod);
        }

        // GET: api/Products/5
        [Route("api/products/{category}")]
        public IHttpActionResult GetProductByCategory(string category)
        {
            var prods = products.Where(i => i.Category.Equals(category));
            if (prods == null)
            {
                return NotFound();
            }
            return Ok(prods);
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
