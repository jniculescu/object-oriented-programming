using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketPrice
{
    class Price
    {
        public static double price = 16;
        public static int age;
        public static bool conscript;
        public static bool mtk;
        public static bool student;

        public static void Getinfo(Customer customer)
        {
            age = customer._age;
            conscript = customer._conscript;
            mtk = customer._mtk;
            student = customer._student;
        }

        public static double Getprice()
        {

            if (age < 7)
            {
                price = 0;
                return price;
            }

            else if(age > 7 && age < 15)
            {
                price = 8;
                return price;
            }

            else if(age >= 65)
            {
                price = 8;
                return price;
            }

            else
            {
                if(conscript == true)
                {
                    price = 8;
                    return price;
                }

                else if(mtk == true)
                {
                    if(student == true)
                    {
                        price = 16 * 0.40;
                        return price;
                    }

                    else
                    {
                        price = 16 * 0.85;
                        return price;
                    }                    
                }

                else if (student == true)
                {
                    price = 16 * 0.55;
                    return price;
                }
                return price;
            }            
        }
    }
}
