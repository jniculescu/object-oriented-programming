using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketPrice
{
    class Customer
    {
        public string _name;
        public int _age;
        public bool _mtk;
        public bool _conscript;
        public bool _student;

        public Customer()
        {
            _name = "Kukkuu";
            _age = 0;            
            _conscript = false;
            _mtk = false;
            _student = false;
        }

        public Customer(string name, int age, bool conscript, bool mtk, bool student)
        {
            _name = name;
            _age = age;            
            _conscript = conscript;
            _mtk = mtk;
            _student = student;
        }

        public void Printinfo()
        {
            Console.WriteLine($"Nimi: {_name}" + "\n" + $"Ikä: {_age}" + "\n" + $"Varusmies: {_conscript}" + "\n" + $"Mtk:n jäsen: {_mtk}"+ "\n" + $"Opiskelija: {_student}");
        }  
    }
}
