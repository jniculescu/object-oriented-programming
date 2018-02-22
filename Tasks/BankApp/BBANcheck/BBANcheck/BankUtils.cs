using System;
using System.Collections.Generic;
using System.Text;

namespace BBANcheck
{
    class BankUtils
    {
        public static bool NumberCheck(ref string bban)
        {
            // remove white space and dash
            bban = bban.Replace(" ", "");
            bban = bban.Replace("-", "");

            //chec for other than numbers
            for (int i = 0; i < bban.Length; i++)
            {
                bool isNumber = int.TryParse(bban[i].ToString(), out int digit);
                if (!isNumber)
                    return false;
            }

            // determine position of zero spam
            int positionOfZeros = 0;

            if (bban[0] == '1' || bban[0] == '2' ||
                bban[0] == '6' || bban[0] == '8')
                positionOfZeros = 6;
            else if (bban[0] == '3')
            {
                if (bban[1] == '0' || bban[1] == '2' || bban[1] == '5')
                    return false;
                positionOfZeros = 6;
            }
            else if (bban[0] == '4' || bban[0] == '5')
                positionOfZeros = 7;
            else
            {
                return false;
            }

            while (bban.Length < 14)
            {
                bban = bban.Insert(positionOfZeros, "0");
            }

            return true;
        }

        public static bool ValidNumber(string newFormNumber)
        {
            int checkNumber = int.Parse(newFormNumber[newFormNumber.Length - 1].ToString());

            newFormNumber = newFormNumber.Remove(newFormNumber.Length - 1, 1);
            int[] multipliers = new int[2] { 2, 1 };
            int x = 0;
            for (int i = 0; i < newFormNumber.Length; i++)
            {
                bool isNumbers = int.TryParse(newFormNumber[i].ToString(), out int numbers);
                if (!isNumbers)
                {
                    return false;
                }


                int y = numbers * multipliers[i % 2];
                if (y >= 10)
                {
                    x += y / 10 + (y - 10);
                }
                else
                {
                    x += y;
                }
            }

            int checkedNum = ((x / 10 + 1) * 10) - x;

            return checkNumber == checkedNum;
        }
    }
}
