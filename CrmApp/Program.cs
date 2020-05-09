using CrmApp.Options;
using CrmApp.Services;
using System;

namespace CrmApp
{
    class Program
    {
        static void Main()
        {
            //TestingCustomer.TestServices();
            //TestingProducts.TestServices();

            ProductOption prOpt = new ProductOption
            {
                Name = "mila",
                Price = 0.3m,
                Quantity = 12
            };

            using CrmDbContext dbs = new CrmDbContext();
            ProductManagment prdMng = new ProductManagment(dbs);

            Product prod = prdMng.CreateProduct(prOpt);

            BasketManagement bskMng = new BasketManagement(dbs);
            BasketOption bskOption = new BasketOption
            {
                CustomerId = 1
            };
            Basket basket = bskMng.CreateBasket(bskOption);

            BasketProductOption bskProdOption = new BasketProductOption
            {
                BasketId = 1,
                ProductId = 1
            };
            BasketProduct bskProduct = bskMng.AddProduct(bskProdOption);

            Console.WriteLine(basket.BasketProducts[0].Product.Name);
        }
    }
}