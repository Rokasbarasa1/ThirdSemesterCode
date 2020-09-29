using System;
using System.IO;
using System.Threading;
namespace Session4.Ex3
{
    class MainEx3
    {
        public String data; 
        static void Main(string[] args)
        {
            /*
            Thread thread1 = new Thread(
            MainEx3.DoWork("file.txt")
            );
            Thread thread2 = new Thread(
            MainEx3.DoWork("file.txt")
            );
            Thread thread3 = new Thread(
            DoWork("file.txt")
            );
            */
        }

        public static void DoWork(string fileName)
        {
            Reader sr = new Reader(fileName);

            sr.Read();
            
            //data = sr.Data;

        }
    }
}
