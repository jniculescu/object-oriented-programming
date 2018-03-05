using System;

namespace ProductInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[3];
            products[0] = new Product("Phone", 650, 6);
            products[1] = new Product("Television", 760, 5);
            products[2] = new Product("Microwave", 120, 4);

            Console.WriteLine(products[0].GetProduct(products[2]));

            products[0].Average();
            products[1].Average();
            products[2].Average();
        }
    }
}
