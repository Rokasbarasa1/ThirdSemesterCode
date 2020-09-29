using System;
using System.Net.Sockets;
using System.Text;

namespace Session4.Ex4
{
    class ClientMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("starting client");
            TcpClient client = new TcpClient("127.0.0.1", 5000);
            Console.WriteLine("Client connected");

            NetworkStream stream = client.GetStream();
            byte[] bytes = Encoding.ASCII.GetBytes("Hi from client");
            stream.Write(bytes, 0, bytes.Length);
            //String fromServer = (string)stream.Read;
            client.Close();
            Console.WriteLine("Client terminated");
        }
    }
}

