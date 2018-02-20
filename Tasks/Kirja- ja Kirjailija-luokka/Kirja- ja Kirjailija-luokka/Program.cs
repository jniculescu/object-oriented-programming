using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kirja__ja_Kirjailija_luokka
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("The Hunt For Red October", "Tom Clancy", "WSOY", 25, "War");
            Book book2 = new Book("The Lord of the Rings", "J.R.R. Tolkien", "Allen & Unwin", 40.00, "Fantasy");

            book1.SearchBook("The Hunt For Red October");
            book2.SearchBook("The Lord of the Rings");

            Console.WriteLine($"Category now: {book1.themeName}");
            book1.SwitchTheme("Fantasy");
            Console.WriteLine($"Category now: {book1.themeName}");
            Author author = new Author("Tom Clancy", "12.4.1947", "The Hunt For Red October");

            Console.ReadKey();                        
        }
    }
}
