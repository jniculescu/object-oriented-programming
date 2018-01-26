using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto
{
    class Car
    {
        private string _brand;
        private double _speed;
                    
        public Car()
        {
            _brand = "unknown";
            _speed = 0;
        }

        public Car(string brand, double speed)
        {
            _brand = brand;
            _speed = speed;

        }
                                
        public void AskData()
        {
            Console.WriteLine("Give brand and speed of vehicle.");
            Console.WriteLine("Brand: ");
            _brand = Console.ReadLine();
            Console.WriteLine("Speed: ");
            double.TryParse(Console.ReadLine(), out _speed);  
        }

        public void ShowCarinfo()
        {
            Console.WriteLine($"Car was a {_brand} with a speed of {_speed}.");
        }

        public void Accelerate(int number)
        {
            _speed = _speed + number;
        }

        public void Brake(int number)
        {
            _speed = (_speed * number) / 100;
        }
    }
}
