using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma
{
    class Company
    {
        private string _title;
        private string _address;
        private int _phone;
        private int _income;
        private int _expenses;

        public Company()
        {
            _title = "company";
            _address = "somewhere";
            _phone = 0;
            _income = 0;
            _expenses = 0;
        }

        public Company(string title, string address, int phone, int income, int expenses)
        {
            _title = title;
            _address = address;
            _phone = phone;
            _income = income;
            _expenses = expenses;
        }

        public Company(Company previousCompany)
        {
            _title = previousCompany._title;
            _address = previousCompany._address;
            _phone = previousCompany._phone;
            _income = previousCompany._income;
            _expenses = previousCompany._expenses;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Title = {_title}\nAddress = {_address}\nPhone number = {_phone}\nOutcome = {_income}\nExpence = {_expenses}\n");
        }

        public void ShowProfit()
        {
            int profit = (_income - _expenses) / _expenses * 100;

            if (profit < 2 * _expenses)
            {
                Console.WriteLine($"\n{_title}: Company's profits are under 100 % bigger than expences. Company is not doing so great.");
            }

            else if (profit <= 3 * _expenses)
            {
                Console.WriteLine($"\n{_title}: Company's profits are at least 200 % bigger than expences. Company is doing fine.");
            }

            else
            {
                Console.WriteLine($"\n{_title}: Company's profits are at least 300 % bigger than expences. Company is doing very well!");
            }
        }
    }
}
