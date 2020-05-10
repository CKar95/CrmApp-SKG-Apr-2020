using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrmApp;
using CrmApp.Options;
using CrmApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CrmApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ILogger<CustomerController> _logger;

        public CustomerController(ILogger<CustomerController> logger)
        {
            _logger = logger;
        }

        [HttpGet("")]
        public string Get()
        {
            return "Welcome to our site";
        }

        [HttpGet("all")]
        public List<Customer> GetAllCustomers()
        {
            using CrmDbContext db = new CrmDbContext();
            CustomerManagement custMangr = new CustomerManagement(db);

            return custMangr.GetAllCustomers();
        }

        [HttpGet("{id}")]
        public Customer GetCustomer(int id)
        {
            using CrmDbContext db = new CrmDbContext();
            CustomerManagement custMangr = new CustomerManagement(db);

            return custMangr.FindCustomerById(id);
        }

        [HttpPost("")]
        public Customer PostCustomer(CustomerOption custOption)
        {
            using CrmDbContext db = new CrmDbContext();
            CustomerManagement custMangr = new CustomerManagement(db);

            return custMangr.CreateCustomer(custOption);
        }

        [HttpPut("{id}")]
        public Customer PutCustomer(CustomerOption custOption, int id)
        {
            using CrmDbContext db = new CrmDbContext();
            CustomerManagement custMangr = new CustomerManagement(db);

            return custMangr.Update(custOption, id);
        }

        [HttpDelete("hard/{id}")]
        public bool HardDeleteCustomer(int id)
        {
            using CrmDbContext db = new CrmDbContext();
            CustomerManagement custMangr = new CustomerManagement(db);

            return custMangr.DeleteCustomerById(id);
        }

        [HttpDelete("soft/{id}")]
        public bool SoftDeleteCustomer(int id)
        {
            using CrmDbContext db = new CrmDbContext();
            CustomerManagement custMangr = new CustomerManagement(db);

            return custMangr.SoftDeleteCustomerById(id);
        }
    }
}
