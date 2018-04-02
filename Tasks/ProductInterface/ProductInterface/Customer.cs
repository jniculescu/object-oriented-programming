using System;
using System.Collections.Generic;
using System.Text;

namespace ProductInterface
{
    class Customer : ICustomer
    {
        public string Cname;
        public int Items;

        public Customer()
        {
            Cname = "unknown";
            Items = 0;
        }

        public Customer(string cname, int items)
        {
            Cname = cname;
            Items = items;
        }

        //tostring method
        public override string ToString()
        {
            return base.ToString();
        }

        public string SearchCustomer(Customer ctm)
        {
            Console.Write("Search customer: ");
            string userInput = Console.ReadLine();
            Cname = userInput;

            if (Cname == ctm.Cname)
            {
                return $"Customers name: {ctm.Cname}\nItems: {ctm.Items}\n";
            }
            else
                return null;
        }


        public void CalBonus()
        {
            double bonus;

            if (Items <= 1000)
            {
                bonus = Items * 0.02;
                Console.WriteLine($"Bonus: {bonus}\n");
            }

            else if (Items > 1000 && Items < 2000)
            {
                bonus = Items * 0.03;
                Console.WriteLine($"Bonus: {bonus}\n");
            }

            else
            {
                bonus = Items * 0.05;
                Console.WriteLine($"Bonus: {bonus}");
            }
        }
    }
}
