using System;

namespace Simple_things
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            GenericsTopic generics = new GenericsTopic();
            int[] intArray = generics.createArray<int>(5, 6);
            string[] stringArray = generics.createArray<string>("kaka", "lilu");

            DelegateTopic delegates = new DelegateTopic();
            delegates.start();

            //Lambda example 
            //Employee employee = listEmployees.Find(Emp => Emp.ID == 102);

            //Employee employee = listEmployees.Find((Employee Emp) => Emp.ID == 102);
        }
    }
}
