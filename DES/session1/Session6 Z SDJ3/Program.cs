using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;

namespace Session6_Z_SDJ3
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Rokas", "ForkliftDriver", 54, false);

            IPEndPoint serverAddress = new IPEndPoint(IPAddress.Parse("192.168.1.20"), 4343);
            Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            clientSocket.Connect(serverAddress);
            Console.WriteLine("Connected to server");

            String jsonPerson = JsonSerializer.Serialize(person);
            Console.WriteLine(jsonPerson);
            
            int toSendLen = System.Text.Encoding.ASCII.GetByteCount(jsonPerson);
            byte[] toSendBytes = System.Text.Encoding.ASCII.GetBytes(jsonPerson);
            byte[] toSendLenBytes = System.BitConverter.GetBytes(toSendLen);
            clientSocket.Send(toSendLenBytes);
            clientSocket.Send(toSendBytes);
        }
    }
}
