using SportsStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace SportsStore.Controllers
{
    public class ProductController : ApiController
    {
        private IRepository repository;

        public ProductController(IRepository reponsitoryParam)
        {
            repository = reponsitoryParam;
        }

        [HttpGet]
        public IEnumerable<Product> GetProducts() => repository.Products;

        [HttpGet]
        public IHttpActionResult GetProductById(int id)
        {
            Product result = repository.Products.Where(p => p.Id == id).FirstOrDefault();
            return result == null ? (IHttpActionResult)BadRequest("No Product Found") : Ok(result);
        }

        public async Task PostProduct(Product product)
        {
            await repository.SaveProductAsync(product);
        }

        public async Task DeleteProduct(int id)
        {
            await repository.DeleteProductAsync(id);
        }
    }
}