using System;
using System.Collections.Generic;
using System.Text;

namespace Session3.Ex3
{
    class Program2
    {
        static void Main(string[] args)
        {
            Stack<int> stackInt = new Stack<int>();
            Stack<string> stackString = new Stack<string>();
            pushToStack(stackInt, 1, 2, 4, 6, 1, 675, 6, 3, 2);
            pushToStack(stackString, "asdasg", "d1duhas", "dkaka", "kakulis");

            printStack(stackInt);
            printStack(stackString);
        }

        static void pushToStack(Stack<int>stack, params int[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                stack.Push(list[i]);
            }
        }
        static void pushToStack(Stack<string> stack, params string[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                stack.Push(list[i]);
            }
        }
        
        static void printStack(Stack<int> stack)
        {
            int[] arrayInt = stack.ToArray();
            for (int i = 0; i < arrayInt.Length; i++)
            {
                Console.WriteLine(arrayInt[i]);
            }
        }
        static void printStack(Stack<String> stack)
        {
            String[] arrayInt = stack.ToArray();
            for (int i = 0; i < arrayInt.Length; i++)
            {
                Console.WriteLine(arrayInt[i]);
            }
        }
    }
}
