using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Session4.Ex4
{
	class MainEx4
	{
		static void Main(string[] args)
		{
			
			byte[] adr = { 127, 0, 0, 1 };
			IPAddress ipAdr = new IPAddress(adr);
			TcpListener newsock = new TcpListener(ipAdr, 5000);
			newsock.Start();
			
			while (true)
			{
				Console.WriteLine("Waiting for client... ");
				TcpClient client = newsock.AcceptTcpClient();
				//
				Thread newClient = new Thread(MainEx4.handleClient);
				newClient.Start(client);
			}
		}
		public static void handleClient(object argument)
		{
			TcpClient client = (TcpClient)argument;
			NetworkStream ns = client.GetStream();

			byte[] bytes = Encoding.ASCII.GetBytes("Welcome to the DNP test server");
			ns.Write(bytes, 0, bytes.Length);
			while (true)
			{
				Thread.Sleep(1000);
			}
		}
	}   
}
