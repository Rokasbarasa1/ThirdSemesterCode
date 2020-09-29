using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_4
{
    class Bomb : IExplodable<double>
    {
        public void Explode(double radius)
        {
            Console.WriteLine($"BOOM! {radius}");
        }
    }
}