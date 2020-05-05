using System;
using System.Collections.Generic;

namespace CrmApp
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get ; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public DateTime Dob { get; set; }
        public bool Active { get; set; }
        public decimal Balance { get; set; }
        public List<Basket> Baskets { get; set; }



        //public Customer()
        //{
        //    Random rnd = new Random();
        //    Id = rnd.Next(0, 100);
        //}

        //public override string ToString()
        //{
        //    return $"Id= {Id} Name= {Name} Sex= {Sex} Age= {Age}";
        //}

        //public void Print()
        //{
        //    Console.WriteLine(ToString());
        //    Console.WriteLine();
        //}

        //public string GetTargetGroup()
        //{
        //    if (Age < 10)
        //        return "Target Group: Kid";
        //    else if (Age < 21)
        //        return "Target Group: Teenager";
        //    else
        //        return "Target Group: Adult";
        //}


    }
}
