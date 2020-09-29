using System;
using GasPump;
namespace PumpTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TestPumpPrices();
            TestFillDate();
        }

        public static void TestPumpPrices()
        {
            Pump newPump = new Pump();
            double[] tankSize = { 42,23,112,12,4};
            for (int i = 0; i < tankSize.Length; i++)
            {
                Console.WriteLine(newPump.CostOfFullTank(tankSize[i]));
                Console.WriteLine(newPump.FillTank(tankSize[i]));
            }
        }

        public static void TestFillDate()
        {
            Pump newPump = new Pump();
            Console.WriteLine(newPump.FillPump());
        }
    }
}
