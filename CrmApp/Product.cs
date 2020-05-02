using System;
using System.Collections.Generic;
using System.Text;

namespace CrmApp
{
    public class Product
    {
        //fields
        public int Category { get; set; }
        public String ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal ProductDesrciption { get; set; }



        //constructors
        //constructor overloading
        public Product(int _category)
        {
             Category = _category;
        }

        //default constructor or empty
        public Product()
        {

        }

        //method ToString inherented by the Object class
        public override string ToString()
        {
            //return "Name= " + Name +"\n"
            //   + " Price= "+Price
            //   + " Quantity= " + Quantity
            //   + " TotalCost= " + TotalCost;
            // preferrable way using $
            return $"Name= {Name} Price= {Price}";

        }

        //
        //Summary:
        //      methods
        public void IncreasePrice(decimal percentage)
        {
            if (Category == 1) { 
                Price *= (1 + 0.1m);
            }
            else
            {
                Price *= (1 + percentage);
            }
                
        }

        /// <summary>
        /// Printing prodcut's info.
        /// </summary>
        public void Print()
        {
            Console.WriteLine( ToString());
            Console.WriteLine();
        }

        public string GetRange()
        {
            if ( Price < 1)
                return "low";
            else if (Price  < 10)
                return "medium";
            else
                return "hi";
         
        }

       

    }


    
}
