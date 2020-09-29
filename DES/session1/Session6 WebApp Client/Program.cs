using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Session6_WebApp_Client
{
	class Program
	{
		static readonly HttpClient client = new HttpClient();
		static async Task Main(string[] args)
		{
			Console.WriteLine("started client");
			while (true)
			{
				Console.Write("Enter HTTP Operation: ");
				string operation = Console.ReadLine();
				string body;
				string URL;
				switch (operation)
				{
					case "GET":
						Console.Write("Enter URL: ");
						URL = Console.ReadLine();
						await GetPR(URL);
						break;

					case "POST":
						Console.Write("Enter URL: ");
						URL = Console.ReadLine();
						Console.Write("Enter Body: ");
						body = Console.ReadLine();
						await PostPR(URL, body);
						break;

					case "PUT":
						Console.Write("Enter URL: ");
						URL = Console.ReadLine();
						Console.Write("Enter Body: ");
						body = Console.ReadLine();
						await PutPR(URL, body);
						break;

					case "DELETE":
						Console.WriteLine("IN delete");
						Console.Write("Enter URL: ");
						URL = Console.ReadLine();
						await DeletePR(URL);
						break;
					default:
						break; 
				}
			}
		}

		private static async Task GetPR(String URL)
		{
			client.DefaultRequestHeaders.Accept.Clear();
			var stringTask = client.GetStringAsync(URL);
			var msg = await stringTask;

			Console.WriteLine(msg);
		}

		private static async Task PostPR(String URL, String BODY)
		{
			client.DefaultRequestHeaders.Accept.Clear();
			StringContent httpContent = new StringContent(BODY, Encoding.UTF8, "application/json");

			HttpResponseMessage stringTask = await client.PostAsync(URL, httpContent);

			Console.WriteLine(stringTask.ToString());
		}
		private static async Task PutPR(String URL, String BODY)
		{
			client.DefaultRequestHeaders.Accept.Clear();
			StringContent httpContent = new StringContent(BODY, Encoding.UTF8, "application/json");

			HttpResponseMessage stringTask = await client.PutAsync(URL, httpContent);

			Console.WriteLine(stringTask.ToString());
		}
		private static async Task DeletePR(String URL)
		{
			client.DefaultRequestHeaders.Accept.Clear();
			var stringTask = client.DeleteAsync(URL);
			var msg = await stringTask;

			Console.WriteLine(msg);
		}
	}
}
