using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lippulaskuri käynnistynyt. Syötä tietosi:");
            Customer customer = new Customer();

            //asiakkaan nimi
            Console.WriteLine("Nimi: ");
            customer._name = Console.ReadLine();

            //asiakkaan ikä
            Console.WriteLine("Ikä: ");
            customer._age = int.Parse(Console.ReadLine());

            //erikois ehdot eli jäsenyydet jne.
            Console.WriteLine("Varusmies?: K/E ");
            string yesorno = Console.ReadLine();
            if(yesorno == "K" || yesorno == "k")
            {
                customer._conscript = true;
            }
            else if (yesorno == "E" || yesorno == "e")
            {
                customer._conscript = false;
            }
            else
            {
                Console.WriteLine("Virhe, yritä uudelleen");
                return;
            }

            Console.WriteLine("Mtk:n jäsenyys?: K/E ");
            yesorno = Console.ReadLine();
            if (yesorno == "K" || yesorno == "k")
            {
                customer._mtk = true;
            }
            else if (yesorno == "E" || yesorno == "e")
            {
                customer._mtk = false;
            }
            else
            {
                Console.WriteLine("Virhe, yritä uudelleen");
                return;
            }

            Console.WriteLine("Opiskelija?: K/E ");
            yesorno = Console.ReadLine();
            if (yesorno == "K" || yesorno == "k")
            {
                customer._student = true;
            }
            else if (yesorno == "E" || yesorno == "e")
            {
                customer._student = false;
            }
            else
            {
                Console.WriteLine("Virhe, yritä uudelleen");
                return;
            }

            //tietojen tulostus
            customer.Printinfo();
            //hintalaskurille tiedot
            Price.Getinfo(customer);
            //hinnan tallennus
            double price = Price.Getprice();
            //tulostus
            Console.WriteLine($"Lipun Hinta: {price}");

            Console.ReadKey();
        }
    }
}
