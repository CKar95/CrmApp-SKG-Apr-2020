using CrmApp;
using CrmApp.Options;
using CrmApp.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrmApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {

        [HttpGet("")]
        public string Get()
        {
            return "Welcome to our Products dir";
        }

        [HttpGet("all")]
        public List<Product> GetAllProducts()
        {
            using CrmDbContext db = new CrmDbContext();
            ProductManagment prdMng = new ProductManagment(db);

            return prdMng.GetAllProducts();
        }

        [HttpGet("{id}")]
        public Product GetProduct(int id)
        {
            using CrmDbContext db = new CrmDbContext();
            ProductManagment prdMng = new ProductManagment(db);

            return prdMng.FindProductById(id);
        }

        [HttpPost("")]
        public Product PostProduct(ProductOption prdOption)
        {
            using CrmDbContext db = new CrmDbContext();
            ProductManagment prdMng = new ProductManagment(db);

            return prdMng.CreateProduct(prdOption);
        }

        [HttpPut("{id}")]
        public Product PutProduct(ProductOption prdOption, int id)
        {
            using CrmDbContext db = new CrmDbContext();
            ProductManagment prdMng = new ProductManagment(db);

            return prdMng.UpdateProduct(prdOption, id);
        }

        [HttpDelete("hard/{id}")]
        public bool HardDeleteProduct(int id)
        {
            using CrmDbContext db = new CrmDbContext();
            ProductManagment prdMng = new ProductManagment(db);

            return prdMng.DeleteProdcutById(id);
        }
    }
}
