using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_1
{
    class Player
    {
        public void Shout(string s)
        {
            Console.WriteLine(s);
        }

        public void Shout(int i)
        {
            Console.WriteLine($"{i} is my lucky number");
        }

        public void Shout(Enemy e)
        {
            Console.WriteLine($"The enemy can do {e.Damage} damage to me");
        }

    }
}
