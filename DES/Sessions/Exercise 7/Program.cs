using System;

namespace Exercise_7
{
    class Program
    {
        delegate void Notifier(string sender);

        static void Main(string[] args)
        {
            Notifier greetings = SayHello;
            greetings("World");
            greetings = SayGoodbye;
            greetings("World");
            greetings = SayHello;
            greetings += SayGoodbye;
            greetings("World");
        }

        static void SayHello(string name)
        {
            Console.WriteLine($"Hello {name}");
        }

        static void SayGoodbye(string name)
        {
            Console.WriteLine($"Goodbye {name}");
        }
    }
}
