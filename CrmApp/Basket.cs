using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CrmApp
{
    class Basket
    {
        private List<Product> products;
        public Customer Customer { get; set; }

        public Basket()
        {
            products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product); 
        }

        public void Print()
        {
            foreach (Product p in products)
            {
                Console.WriteLine(p);
            }
        }


        public void ShowCategories()
        {
            int howManyLow = 0;
            int howManyMedium = 0;
            int howManyHi = 0;
            foreach (Product p in products)
            {
                if (p.GetRange() == "low") howManyLow++;
                if (p.GetRange() == "medium") howManyMedium++;
                if (p.GetRange() == "hi") howManyHi++;

            }
            Console.WriteLine($"howManyLow= {howManyLow}");
            Console.WriteLine($"howManyMedium= {howManyMedium}");
            Console.WriteLine($"howManyHi= {howManyHi}");
        }


        public decimal TotalCost()
        {
            decimal totalCost = 0;
            foreach (Product p in products)
            {
                totalCost+=p.TotalCost;
            }
            return totalCost;
        }

        public string Save(string fileName)
        {
            try
            {
                StreamWriter sw = new StreamWriter(fileName, false);
                foreach (Product p in products)
                {
                    sw.WriteLine(p.Code + "," +
                        p.Name + "," +
                        p.Price + "," +
                        p.Quantity);
                }
                sw.Close();
            }
            catch (Exception)
            {
                return "An error occured";
            }
            return "The data hava been saved";
            
        }

        public string Load(string fileName)
        {
            try
            {
                products.Clear();
                StreamReader sr = new StreamReader(fileName);
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] words = line.Split(",");
                    Product product = new Product
                    {
                        Code = words[0],
                        Name = words[1],
                        Price = Decimal.Parse(words[2]),
                        Quantity = Int32.Parse(words[3])
                    };
                    products.Add(product);
                    line = sr.ReadLine();
                }
                //Den einai apareteio na kleinoume ton sr
                sr.Close();
            }
            catch (Exception)
            {
                return "An error occured";
            }
            return ("The data hava been printed");
        }
    }
}
