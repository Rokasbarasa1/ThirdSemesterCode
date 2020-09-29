using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;

namespace Session4.Ex2
{
    class MainEx2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting writing");
            Person person = new Person();
            person.FirstName = "Rokas";
            person.LastName = "Barasa";
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("MyCar.bin", FileMode.Create,
                FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, person);
            stream.Close();
            Console.WriteLine("Stopping writting");

            stream = new FileStream("MyCar.bin", FileMode.Open,
                FileAccess.Read, FileShare.Read);
            Person obj = (Person)formatter.Deserialize(stream);
            stream.Close();
            Console.WriteLine(obj.FirstName);
            Console.WriteLine(obj.LastName);
        }
    }
}
