using System;
using System.Collections.Generic;
using System.Text;

namespace BBANcheck
{
    class BBAN
    {
        public string accnumber { get; set; }
        public bool isValidAccNumber { get; set; }
        public string transformedNumber { get; set; }

        public BBAN(string bban)
        {
            accnumber = bban;
            string tempNum = accnumber;
            isValidAccNumber = BankUtils.NumberCheck(ref tempNum);
            transformedNumber = tempNum;
        }

        public bool IsValid()
        {
            return BankUtils.ValidNumber(accnumber);
        }

        public override string ToString()
        {
            return $"BBAN: {accnumber}\n" +
                   $"MachineNumber: {transformedNumber}\n" +
                   $"IsValid: {isValidAccNumber}\n" +
                   $"___________________________\n";
        }
      }
    }
