using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    public abstract class Vehicle
    {
        protected string _type;
        protected string _make;
        protected int _year;
        protected double _price;

        public Vehicle()
        {
            _type = "unknown";
            _make = "unknown";
            _year = 0;
            _price = 0;
        }

        public Vehicle(string type, string make, int year, double price)
        {
            _type = type;
            _make = make;
            _year = year;
            _price = price;
        }

        public virtual void PrintVehicle()
        {
            Console.WriteLine("Here is your car: \n" +
                              $"Tyyppi: {_type}\n" +
                              $"Merkki: {_make}\n" +
                              $"Vuosimalli: {_year}\n" +
                              $"Hinta: {_price}");
        }

        abstract public void PrintInfo();
    }
}
