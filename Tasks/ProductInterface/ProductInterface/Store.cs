using System;
using System.Collections.Generic;
using System.Text;

namespace ProductInterface
{
    class Store : Product, ICustomers, IProducts
    {
        public string storeName;
        public int sales;
        public Product[] Products;
        public Customer[] Customers;

        public Store()
        {
            storeName = "unknown";
            sales = 0;
        }

        public Store(string Storename, int Sales)
        {
            storeName = Storename;
            sales = Sales;
        }

        public override string ToString()
        {
            return string.Format($"Store name: {storeName}" +
                                 $"Store sales: {sales}");
        }

        public void AddCustomer(Customer[] customers)
        {
            Customers = customers;
        }

        public void PrintCustomer()
        {
            for (int i = 0; i < Products.Length; i++)
            {
                Console.WriteLine($"Name: {Customers[i].Cname}\n" +
                                  $"Price: {Customers[i].Items}$\n");
            }
            Console.WriteLine($"Total amount of customers: {Customers.Length}");
        }

        public void AddProduct(Product[] products)
        {
            Products = products;
        }

        public void PrintProducts()
        {
            int amount = 0;
            for (int i = 0; i < Products.Length; i++)
            {
                Console.WriteLine($"Name: {Products[i].name}\n" +
                                  $"Price: {Products[i].price}\n" +
                                  $"Number of products: {Products[i].amount}\n");

                amount += Products[i].amount;
            }
            Console.WriteLine($"Amount of all products: {amount}\n");

        }

        public void CountTotalValue()
        {
            Console.WriteLine($"Total Value: {price * amount}$\n");
        }
    }
}
