using System;
using System.Collections.Generic;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var ints = new List<int>() { 1, 2, 3, 4 };
            Console.WriteLine("List:");
            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Random element from list: " + ints.GetRandom());
            ints.Shuffle();
            Console.WriteLine("Shuffled list: ");
            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }
        }
    }
}
