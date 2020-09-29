using System;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var t1 = new Time { Hours = 2, Minutes = 30 };
            var t2 = new Time { Hours = 1, Minutes = 20 };

            var t3 = t1 + t2;

            Console.WriteLine(t3);

            t3 = t3 + 22;

            Console.WriteLine(t3);
        }
    }
}
