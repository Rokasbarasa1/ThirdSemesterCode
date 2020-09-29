using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_8
{
    class Car
    {
        public string Color { get; set; }
        public int EngineSize { get; set; }
        public int FuelEconomy { get; set; }

        public Car(string color, int engineSize, int fuelEconomy)
        {
            Color = color;
            EngineSize = engineSize;
            FuelEconomy = fuelEconomy;
        }

        public override string ToString()
        {
            return $"Color: {Color}, EngineSize: {EngineSize}, FuelEconomy: {FuelEconomy}";
        }
    }
}
