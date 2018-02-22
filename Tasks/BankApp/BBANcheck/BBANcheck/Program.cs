using System;

namespace BBANcheck
{
    class Program
    {
        static void Main(string[] args)
        {
            BBAN newNumber = new BBAN("227720A35988");
            Console.WriteLine(newNumber.ToString());

            BBAN Number2 = new BBAN("123456-781");
            Console.WriteLine(Number2.ToString());

            Console.ReadKey();
        }
    }
}
                                                                                                                                                      