using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kirja__ja_Kirjailija_luokka
{
    class Book
    {
        public string name;
        public string author;
        public string publisher;
        private double _price;
        public string themeName;

        public double Price
        {
            get
            {
                return _price;
            }

            set
            {
               if(value >30)
                {
                    _price = value * 0.90;
                }
            }
        }

        public Book()
        {
            name = "book";
            author = "somebody";
            publisher = "company";
            _price = 0.00;
            themeName = "theme";
        }

        public Book(string Name, string Author, string Publisher, double Price, string ThemeName)
        {
            name = Name;
            author = Author;
            publisher = Publisher;
            _price = Price;
            themeName = ThemeName;
        }

        public void SearchBook(string Name)
        {
            Console.WriteLine("Give my book a name: ");
            string bookname = Console.ReadLine();

            name = bookname;

            if(name == Name)
            {
                Console.WriteLine($"Book was found! \nName: {name}\nAuthor: {author}\nPublisher: {publisher}\nPrice: {Price}\nTheme: {themeName}\n");
            }
        }

        public void SwitchTheme(string ThemeName)
        {
            themeName = ThemeName;
        }

        public override string ToString()
        {
            return ($"Name = {name}\nAuthor = {author}\nPublisher = {publisher}\nPrice = {Price}\nTheme = {themeName}");
        }
    }
}