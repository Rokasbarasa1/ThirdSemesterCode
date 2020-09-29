using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_2
{
    static class Extensions
    {
        static readonly Random rnd = new Random();
        public static T GetRandom<T>(this List<T> list)
        {
            return list[rnd.Next(list.Count)];
        }

        public static void Shuffle<T>(this List<T> list)
        {
            int n = list.Count;
            // Fisher–Yates shuffle
            while (n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
