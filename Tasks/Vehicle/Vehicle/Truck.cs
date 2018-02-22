using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    class Truck : Car
    {
        protected double maxLoad;
        protected double consumptionPerKg;

        public Truck()
        {
            maxLoad = 0;
            consumptionPerKg = 0;
        }

        public Truck(string type, string make, int year, double price,
            double engineSize, string model, int doors, double loadweight, double conperkg) 
            : base(type, make, year, price, engineSize, model, doors)
        {
            maxLoad = loadweight;
            consumptionPerKg = conperkg;
        }

        public string CalcCons()
        {
            double cons = maxLoad / consumptionPerKg;
            return ($"Consumption is {cons} litres.");
        }

    }
}
