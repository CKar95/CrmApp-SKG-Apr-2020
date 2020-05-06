using CrmApp.Options;
using CrmApp.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrmApp
{
    class TestingProducts
    {
        public static void TestServices()
        {
            ProductOption po = new ProductOption
            {
                Name = "apple",
                Price = 0.2m,
                Quantity = 23
            };

            using CrmDbContext db = new CrmDbContext();
            ProductManagment prodMngr = new ProductManagment(db);

            //Create Product with options given (po)
            Product product = prodMngr.CreateProduct(po);
            Console.WriteLine($"Creating Product: Id = {product.Id}, Name = {product.Name}," +
                $" Price = {product.Price}, Quantity = {product.Quantity}, TotalCost = {product.TotalCost}!");

            //product.Name = "ayyayay";
            //db.SaveChanges();

            //Find Product with id
            Product prodFound = prodMngr.FindProductById(2);
            Console.WriteLine($"Find Product: Id = {prodFound.Id}, Name = {prodFound.Name}," +
                $" Price = {prodFound.Price}, Quantity = {prodFound.Quantity}, TotalCost = {prodFound.TotalCost}!");

            //Update Product with options and id
            Product prodUpdated = prodMngr.UpdateProduct(new ProductOption {Name = "Banana" }, 1);
            Console.WriteLine($"Updated Product: Id = {prodUpdated.Id}, Name = {prodUpdated.Name}," +
                $" Price = {prodUpdated.Price}, Quantity = {prodUpdated.Quantity}, TotalCost = {prodUpdated.TotalCost}!");

            //Delete Product with id
            bool prodDeleted = prodMngr.DeleteProdcutById(4);
            Console.WriteLine($"Deleted Product: {prodDeleted}");

            Product prd = prodMngr.FindProductById(4);
            if (prd != null)
            {
                Console.WriteLine(
                $"Id= {prd.Id} Name= {prd.Name}");

            }
            else
            {
                Console.WriteLine("Product not found");
            }
        }
    }
}
