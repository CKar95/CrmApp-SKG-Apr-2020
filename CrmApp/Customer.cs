using System;

namespace CrmApp
{
    class Customer
    {
        public int Id { get;}
        public string Name { get ; set; }
        public string Sex { get; set; }
        public int Age { get; set; }

        public Customer()
        {
            Random rnd = new Random();
            Id = rnd.Next(0, 100);
        }

        public override string ToString()
        {
            return $"Id= {Id} Name= {Name} Sex= {Sex} Age= {Age}";
        }

        public void Print()
        {
            Console.WriteLine(ToString());
            Console.WriteLine();
        }

        public string GetTargetGroup()
        {
            if (Age < 10)
                return "Target Group: Kid";
            else if (Age < 21)
                return "Target Group: Teenager";
            else
                return "Target Group: Adult";
        }


    }
}
