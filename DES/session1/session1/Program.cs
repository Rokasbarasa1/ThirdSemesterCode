using System;
using session1;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            /*//Console.WriteLine("Hello Rokas!");
            Person human = new Person("Rokas", 12);
            Calculator calculator = new Calculator();
            human.myName();
            for (int i = 0; i < 100; i++)
            {
                if((i % 2) == 1){
                    System.Console.WriteLine(i);
                }
            }

            for (int i = 0; i < 100; i++)
            {
                if((i % 2) == 0){
                    System.Console.WriteLine(i);
                }
            }
            int number = 0;
            switch (number)
            {
                case 10:
                    System.Console.WriteLine("i fucked up");                break;
                case 0:
                    System.Console.WriteLine("this is the first number");
                break;
                case 1:
                    System.Console.WriteLine("this is the second number");
                break;
                case 2:
                    System.Console.WriteLine("this is the third number");
                break;
                case 3:
                    System.Console.WriteLine("this is the fourth number");
                break;
                case 4:
                    System.Console.WriteLine("this is the fift number");
                break;
                case 5:
                    System.Console.WriteLine("this is the sixt number");
                break;
                case 6:
                    System.Console.WriteLine("this is the seventh number");
                break;
                case 7:
                    System.Console.WriteLine("this is the eight number");
                break;
                case 8:
                    System.Console.WriteLine("this is the ninth number");
                break;
                case 9:
                    System.Console.WriteLine("this is the tenth number");
                break;
                default:
                    System.Console.WriteLine("iNVALID NUMBER");
                break;
            }
            
            int[] kaka = new int[6] {1,2,3,4,5,6};
            int[] kakulis = new int[4] {3,5,1,7};

            int first = 3, second = 7;
            System.Console.WriteLine(calculator.Add(3,7));
            System.Console.WriteLine(calculator.Add(kaka, kakulis));
            
            int number1;
            int number2;

            number1 = int.Parse(Console.ReadLine());
            number2 = int.Parse(Console.ReadLine());

            if (number1 > number2)
            {
                System.Console.WriteLine(number1 + " is bigger");
            }
            else
            {

                System.Console.WriteLine(number2 + " is bigger");
            }
            */
            string name;

            name = Console.ReadLine();

            Console.WriteLine(StringUtility.SummarizeText(name));
            /*
            for (int i = name.Length-1; i >= 0; i--)
            {
                reverse = reverse + name[i];
            }
            */            

        }
    }
}
