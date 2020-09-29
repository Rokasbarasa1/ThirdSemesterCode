using System;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 1400;
            string message;

            message = score > 1337 ? "This is a new highscore" : "You need more points to beat the highscore";
            Console.WriteLine(message);
        }
    }
}
