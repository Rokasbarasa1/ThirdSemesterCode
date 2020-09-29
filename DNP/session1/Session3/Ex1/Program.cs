using System;

namespace Session3
{
    class Program
    {
        static void Main(string[] args)
        {
            Enemy kaka = new Enemy(12);

            Player play = new Player();

            play.Shout(kaka);
            play.Shout(345);
            play.Shout("sdasdtf");
        }
    }
}
