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
        public Product GetProductById(int id)
        {
            return repository.Products.Where(p => p.Id == id).FirstOrDefault();
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