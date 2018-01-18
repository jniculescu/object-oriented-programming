using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kirja
{
    class Book
    {
        private string _author;
        private string _title;        
        private int _id;
        private int _price;

        public Book()
        {
            this._author = "Joku Jokutin";
            this._title = "Kirja 1";
            this._id = 1;
            this._price = 20;                            
        }

        public Book(string author, string title, int id, int price)
        {
            this._author = author;
            this._title = title;
            this._id = id;
            this._price = price;
        }

        public void Bookinfo()
        {
            Console.WriteLine("Kirja: " + _title + ", Tekijä: " + _author + ", tunniste: " + _id + ", hinta: " + _price);
        }

        public string CompareBook(Book book)
        {
            if(this._price > book._price)
            {
                return $"{this._title} on kalliimpi kuin {book._title}";
            }

            else
            {
                return $"{this._title} on halvempi kuin {book._title}";
            }
        }
    }
}
