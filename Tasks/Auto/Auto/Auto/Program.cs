using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto
{
    class Program
    {
        static void Main(string[] args)
        {

            Car car1 = new Car();

            Car carAuto1 = new Car();
            car1.AskData();
            car1.ShowCarinfo();
            Console.WriteLine("Car speed after 30+:");
            car1.Accelerate(30);
            car1.ShowCarinfo();
            Console.WriteLine("Car speed after 10% slowdown:");
            car1.Brake(90);
            car1.ShowCarinfo();

            Car car2 = new Car();
            car2.AskData();
            car2.ShowCarinfo();
            Console.WriteLine("Car speed after 30+.");
            car2.Accelerate(30);
            car2.ShowCarinfo();
            Console.WriteLine("Car speed after 10% slowdown.");
            car2.Brake(90);
            car2.ShowCarinfo();

            Console.ReadKey();
        }
    }
}
