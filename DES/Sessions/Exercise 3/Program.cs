using System;
using System.Collections.Generic;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> ints = new Stack<int>();
            Stack<string> strings = new Stack<string>();

            PushToStack(ints, 4, 3, 2, 1);
            PushToStack(strings, "world", "and", "class", "hello");

            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }

            foreach (string s in strings)
            {
                Console.WriteLine(s);
            }
        }

        private static void PushToStack<T>(Stack<T> stack, params T[] values)
        {
            foreach (T value in values)
            {
                stack.Push(value);
            }
        }
    }
}
