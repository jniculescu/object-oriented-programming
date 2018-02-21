using System;
using System.Collections.Generic;
using System.Text;

namespace BBANcheck
{
    class BBAN
    {
        public string number { get; set; }
        public bool transformedNumber { get; set; }
        public string newNumber { get; set; }


        public BBAN(string bban)
        {
            number = bban;
            string tempNum = number;
            transformedNumber = BankUtils.BankUtils.NumberCheck(ref tempNum);
            newNumber = tempNum;
        }

        public bool IsValid()
        {
            return BankUtils.BankUtils.ValidNumber(number);
        }

        public override string ToString()
        {
            return $"BBAN: {number}\n" +
                   $"MachineNumber: {newNumber}\n" +
                   $"IsValid: {transformedNumber}\n" +
                   $"___________________________\n";

        }
      }
    }
