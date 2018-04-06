using System;
using System.Collections.Generic;
using System.Text;

namespace ProductInterface
{
    class Product : IProduct
    {
        public string name;
        public double price;
        public int amount;

        public Product()
        {
            name = "";
            price = 1.00;
            amount = 100;
        }

        public Product(string Name, double Price, int Amount)
        {
            name = Name;
            price = Price;
            amount = Amount;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public string GetProduct(Product prod)
        {
            string name = prod.name;

            if(name == prod.name)
            {
                return $"Name: {prod.name}\nPrice: {prod.price}\nNumber: {prod.amount}\n";
            }

            else
            {
                return null;
            }

        }

        public void Average()
        {
            double total = price * amount   ;

            Console.WriteLine($"Total value of purchase: {total}\n");
        }
    }
}
