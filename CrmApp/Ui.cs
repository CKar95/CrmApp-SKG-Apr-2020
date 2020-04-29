using System;
using System.Collections.Generic;
using System.Text;

namespace CrmApp
{


    class Ui
    {
          
 

        //Factory method
       public Product CreateProduct()
        { 
            Product product = new Product();
            //try-catch block to manage user's input
            try { 
              
                Console.WriteLine("Give the code ");
                product.Code = Console.ReadLine();
                Console.WriteLine("Give the name ");
                product.Name = Console.ReadLine();
                Console.WriteLine("Give the price ");
                product.Price =Decimal.Parse( Console.ReadLine());
                Console.WriteLine("Give the quantity ");
                product.Quantity =Int32.Parse( Console.ReadLine());
                return product;
            }
            catch(Exception  )
            {
                Console.WriteLine("You have not completed the questions properly." +
                    " Please try again.");
                return null;
            }

        }

        public int Menu()
        {
            Console.WriteLine("1. Add a product   2. Display basket " +
                " 3. ShowCategories  4. TotalCost 0. Exit");
            Console.WriteLine("Give your choice");
            int choice = 0;
            try {
                  choice = Int32.Parse(Console.ReadLine()); 
            }
            catch (Exception)
            {

            }
            return choice;
        }

        //TODO: Lets play with CreateCustomer Method!
        public Customer CreateCustomer()
        {
            Customer customer = new Customer();
            try
            {
                Console.WriteLine("Give the Name ");
                customer.Name = Console.ReadLine();
                Console.WriteLine("Give the Sex ");
                customer.Sex = Console.ReadLine();
                Console.WriteLine("Give the Age ");
                customer.Age = Int32.Parse(Console.ReadLine());

                return customer;
            }
            catch (Exception)
            {
                Console.WriteLine("You have not completed customer's questions properly." +
                    " Please try again.");
                return null;
            }
            
        }

        public Basket CreateBasket()
        {
            Basket basket = new Basket();
            int choice;
            
            do
            {
                choice = Menu();
                switch (choice)
                {
                    case 1:
                        Product product = CreateProduct();
                        basket.AddProduct(product);
                        break;
                    case 2:
                        basket.Print();
                        break;
                    case 3:
                        basket.ShowCategories();
                        break;
                    case 4:
                        Console.WriteLine("TotalCost= " + basket.TotalCost());
                        break;
                    case 0:
                        Console.WriteLine("You selected to exit");
                        break;
                    default:
                        Console.WriteLine("Invalid number! Please type a number between 0 and 4.");
                        break;

                }
            }
            while (choice != 0);
            return basket;
        }

    }
}
