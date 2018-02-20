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
            Book book2 = new Book("", "Emily Bronte", "Bookpublishers", 24.60, "Romance");
            Book book3 = new Book("To Kill a Mockingbird", "Lee Harper", "Bookpublishers", 32.40, "Drama");
            Book book4 = new Book("The Lord of the Rings", "J.R.R. Tolkien", "Allen & Unwin", 35.00, "Fantasy");

            book1.SearchBook("The Hunt For Red October");
            book2.SearchBook("Wuthering Heights");

            Console.WriteLine($"Category now: {book1.themeName}");
            book1.SwitchTheme("Drama");
            Console.WriteLine($"Category now: {book1.themeName}");

            Console.ReadKey();
        }
    }
}
