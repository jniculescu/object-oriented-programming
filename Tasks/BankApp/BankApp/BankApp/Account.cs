using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankApp
{
    class Account
    {
        private string _accountNumber;
        private List<Transaction> _transactions;
        private double _balance;

        public string AccountNumber
        {
            get => _accountNumber;
            set => _accountNumber = value;
        }
        public double Balance
        { get => _balance;
          set => _balance = value;
        }

        public Account(string accountNumber)
        {
            AccountNumber = accountNumber;
            _transactions = new List<Transaction>();
        }

        public Account(string accountNumber, double balance, List<Transaction> transactions)
        {
            AccountNumber = accountNumber;
            Balance = balance;
            _transactions = transactions;
        }

        public List<Transaction> GetTransactionsForTimeSpan(DateTime startTime, DateTime endTime)
        {
            List<Transaction> res = (from transaction in _transactions where transaction.Timestamp >= startTime && transaction.Timestamp <= endTime orderby transaction.Timestamp select transaction).ToList();

            /*
             * List<Transaction> res = (_transactions.Where(t => t.TimerStamp >= startTime && t.TimeStamp <= endTime).OrderBy(t => t.TimeStamp)).ToList(); 
             * */

            return res;
        }

        public bool AddTransaction(Transaction transaction)
        {
            bool res = false;

            _transactions.Add(transaction);
            double balanceBeforeTransaction = _balance;
            if(_transactions.Last().Equals(transaction))
            {
                _balance += transaction.Sum;
            }
            if(_balance - transaction.Sum == balanceBeforeTransaction)
            {
                res = true;
            }
            return res;
        }
    }
}
