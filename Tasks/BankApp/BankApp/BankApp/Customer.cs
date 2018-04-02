using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    class Customer
    {
        public string FirstName { get; }
        public string LastName{get;}
        private string _accountNumber;

        public Customer(string accountNumber, string firstname, string lastname)
        {
            AccountNumber = accountNumber;
            FirstName = firstname;
            LastName = lastname;
        }

        public string AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }

        public override string ToString()
        {
            //return base.ToString();
            return $"{FirstName} {LastName} \t {_accountNumber}";
        }
    }
}
