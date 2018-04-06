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
            products[0].GetProduct(products[0]);

            products[1].Average();
            products[1].GetProduct(products[1]);

            products[2].Average();
            products[2].GetProduct(products[2]);

            Customer[] customers = new Customer[3];
            Customer customer0 = new Customer("Pena Korhonen", 2400);
            Customer customer1 = new Customer("Jaska Jokunen", 600);
            Customer customer2 = new Customer("Henna Heinonen", 5000);

            customers[0].SearchCustomer(customers[0]);
            customers[0].CalBonus();

            customers[1].SearchCustomer(customers[1]);
            customers[1].CalBonus();

            customers[2].SearchCustomer(customers[2]);
            customers[2].CalBonus();

            Store store = new Store("Lidl", 200000);
            store.AddProduct(products);
            store.AddCustomer(customers);

            store.PrintProducts();
            store.PrintCustomer();


            Console.ReadKey();
        }
    }
}
