using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kirja
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Tohelo", "kirja2", 2, 15);
            Book book2 = new Book("joku jokutin", "kirja3", 3, 11);

            book.Bookinfo();
            book2.Bookinfo();

            Console.WriteLine(book.CompareBook(book2));

            Console.ReadKey();
        }
    }
}
