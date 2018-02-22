using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    class Car : Vehicle
    {
        protected double _engineSize;
        protected string _model;
        protected int _doorNum;

        public Car()
        {
            _engineSize = 0;
            _model = "unknown";
            _doorNum = 0;
        }

        public Car(string type, string make, int year, double price, double engineSize, string model, int doorNum) : base(type, make, year, price)
        {
            _engineSize = engineSize;
            _model = model;
            _doorNum = doorNum;
        }

        public override void PrintVehicle()
        {
            base.PrintVehicle();
            Console.WriteLine("*****************************\n" +
                              $"Koneen koko: {_engineSize:f1} l\n" +
                              $"Malli: {_model}\n" +
                              $"Ovien lkm: {_doorNum}\n" +
                              "*****************************\n");
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"\nType: {_type}\nModel: {_make}\nYear: {_year}\nPrice: {_price}$\nMotor: {_engineSize}\nBrand: {_model}\nDoors: {_doorNum}\n");
        }

        public override string ToString()
        {
            return ($"\n{_engineSize}\n{_model}\n{_doorNum}\n");
        }
        public override bool Equals(object obj)
        {
            Car carObj = obj as Car;
            if (carObj == null)
                return false;
            else
                return _make.Equals(carObj._make);
        }
    }
}
