using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    class Transaction
    {

        public double Sum { get; }
        public DateTime Timestamp { get; }

        public Transaction (double sum, DateTime timestamp)
        {
            Sum = sum;
            Timestamp = timestamp;
        }

    }
}
