using System;

namespace Simple_things
{
    internal class GenericsTopic
    {
        public T[] createArray<T>(T firstElement, T secondElement)
        {
            return new T[] { firstElement, secondElement };
        }

        public void TestMultiGenerics<T1, T2>(T1 t1, T2 t2)
        {
            Console.WriteLine(t1.GetType());
            Console.WriteLine(t2.GetType());
        }
    }
}