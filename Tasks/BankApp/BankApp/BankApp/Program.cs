using System;
using System.Collections.Generic;
using System.Linq;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Bank bank = new Bank("Ankkalinnan Pankki");

            List<Customer> customers = new List<Customer>();

            customers.Add(new Customer(bank.CreateAccount(), "Roope", "Ankka"));
            customers.Add(new Customer(bank.CreateAccount(), "Tiivi", "Taavi"));
            customers.Add(new Customer(bank.CreateAccount(), "Hupu", "Ankka"));

            PrintBalance(bank, customers[0]);
            PrintBalance(bank, customers[1]);
            PrintBalance(bank, customers[2]);

            for(int i = 0; i < 60; i++)
            {
                int c = rnd.Next(0, customers.Count()),
                    day = rnd.Next(1, 29),
                    month = rnd.Next(1, 13),
                    year = rnd.Next(2016, 2019);
                double saldo = rnd.NextDouble() * 2000 - 900;

                bank.AddTransactionForCustomer(customers[c].AccountNumber,
                    new Transaction(saldo, new DateTime(year, month, day)));
            }
            foreach (var cust in customers)
            {
                PrintBalance(bank, cust);
            }

            var endTime = DateTime.Today;
            var time = new TimeSpan(24 * 30 * 6, 0, 0);
            var startTime = endTime.Date - time;
            Console.WriteLine($"Tilitapahtumat viimeisen kuuden kuukauden ajalta: {startTime.ToShortDateString()}-" +
                              $"{endTime.ToShortDateString()}");

            foreach (var cust in customers)
            {
                PrintTransactions(bank.GetTransactionsForCustomerForTimeSpan(cust.AccountNumber,
                    startTime, endTime), cust);
            }

            Console.WriteLine("press anything to exit");
            Console.ReadKey();
        }

        public static void PrintBalance(Bank bank, Customer customer)
        {
            var balance = bank.GetBalanceForCustomer(customer.AccountNumber);
            Console.WriteLine("{0} - balance: {1}{2:0.00}", customer.ToString(), balance >= 0 ? "+" : "", balance);

            if (balance >= 0)
            {
                Console.WriteLine($"{customer.ToString()} - balance: + {balance:C}");
            }
            else
            {
                Console.WriteLine($"{customer.ToString()} - balance: {balance:C}");
            }
        }

        public static void PrintTransactions(List<Transaction> transactions, Customer customer)
        {
            Console.WriteLine($"Tilitapahtumat {customer.FirstName} {customer.LastName}");
            for (int i = 0; i < transactions.Count(); i++)
            {
                Console.WriteLine("{0}\t {1}{2:0,00}," +
                    transactions[i].Timestamp.ToShortDateString(),
                    transactions[i].Sum >= 0 ? "+" : "",
                    transactions[i].Sum);
            }
        }

        /*
 *   for (int i = 0; i > 60;i++)
 *   {
 *      int c = rnd.Next(0, customers.Count()),
 *      day = rnd.Next(1, 29),
 *      month = rnd.Next(1, 13),
 *      year = rnd.Next (2016, 2019);
 *     double saldo ) rnd.NextDouble() * 2000 - 900;
 *     
 *     bank.AddTransactionForCustomer(customers[c].AccountNumber, New Transaction(saldo, new DateTime(year,month,day);
 *     }
 *     
 *     foreach(var cust in customers)
 *     {
 *     PrintBalance(bank, cust);
 *     }
 * */
    }
}
