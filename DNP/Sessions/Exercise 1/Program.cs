using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new Player();

            player.Shout("Hi, I am player!");
            player.Shout(42);

            var enemy = new Enemy() { Damage = 1337 };

            player.Shout(enemy);
        }
    }
}
