using System;
using System.Collections.Generic;

namespace Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car> { new Car("blue", 2, 3), new Car("red", 3, 4), new Car("black", 56, 100), new Car("orange", 42, 1337) };

            foreach (Car c in cars.FindAll(IsCarOrange))
            {
                Console.WriteLine(c);
            }

            foreach (Car c in cars.FindAll(car => car.Color.Equals("orange")))
            {
                Console.WriteLine(c);
            }

            foreach (Car c in cars.FindAll(car => car.EngineSize > 42))
            {
                Console.WriteLine(c);
            }

            foreach (Car c in cars.FindAll(car => car.FuelEconomy < 50))
            {
                Console.WriteLine(c);
            }

            foreach (Car c in cars.FindAll(car => car.Color.Equals("black") && car.EngineSize > 50))
            {
                Console.WriteLine(c);
            }
        }

        static bool IsCarOrange(Car car)
        {
            return car.Color.Equals("orange");
        }
    }
}
