using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace CrmApp
{
    class Program
    {
        static void Main()
        {
            //var ui = new Ui();
            //var basket = ui.CreateBasket();

            var dbContext = new CrmAppDbContext();
            //dbContext.Database.EnsureCreated();

            // Insert
            var customer = new Customer()
            {
                Name = "Unkown Customer",
                Sex = "Male",
                Age = 25
            };

            dbContext.Add(customer);
            dbContext.SaveChanges();

            //var customersList = new List<Customer>();
            //customersList.Add(new Customer {Name = "Unkown1 Customer", Sex = "Male",Age = 25 });
            //customersList.Add(new Customer { Name = "Unkown2 Customer", Sex = "Male", Age = 25 });
            //customersList.Add(new Customer { Name = "Unkown3 Customer", Sex = "Male", Age = 25 });
            //customersList.Add(new Customer { Name = "Unkown4 Customer", Sex = "Male", Age = 25 });
            //customersList.Add(new Customer { Name = "Unkown5 Customer", Sex = "Male", Age = 25 });

            //dbContext.AddRange(customersList);
            //dbContext.SaveChanges();

            //var arr = new int[4] { 0, 14, 25, 14 };
            //var first = arr.Where(i => i == 14).First();
            //var single = arr.Where(i => i == 14).Single();

            // Select
            var customers = dbContext
                .Set<Customer>()
                .Where(cust => cust.CustomerId == 6 && cust.Name == "Unkown2 Customer")
                .SingleOrDefault();
            //.ToList();

            //Remove
            //dbContext.Remove(customer);
            //dbContext.SaveChanges();
        }
    }
}
