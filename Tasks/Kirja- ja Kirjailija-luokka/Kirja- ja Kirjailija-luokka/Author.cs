using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kirja__ja_Kirjailija_luokka
{
    class Author
    {
        public string Name;
        public string Birthday;
        public string Book;

        public Author()
        {
            Name = "unknown";
            Birthday = "unknown";
            Book = "unknown";
        }

        public Author(string name, string birthday, string book)
        {
            Name = name;
            Birthday = birthday;
            Book = book;
        }

        public void PrintData()
        {
            Console.WriteLine($"\nAuthors name: {Name}\nBirthday: {Birthday}\nBooks name: {Book}");
        }
    }
}
