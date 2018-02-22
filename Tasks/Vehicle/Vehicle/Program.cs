using System;


namespace Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Sedan", "Audi", 1997, 4000, 1.8, "A4", 5);

            car1.PrintInfo();

            Car car2 = new Car("Estate", "Skoda", 2011, 1700, 1.6, "Otavia", 5);
            car2.PrintInfo();

            Console.WriteLine(car2.ToString());

            Console.WriteLine(car1.Equals(car1));
            Console.WriteLine(car1.Equals(car2));

            Truck truck1 = new Truck("Van", "Fiat", 2007, 13000, 2.5, "Ducato", 2, 5000, 13);
            truck1.PrintInfo();

            Console.WriteLine(truck1.CalcCons());


            Console.ReadKey();
        }
    }
}
                                                                            