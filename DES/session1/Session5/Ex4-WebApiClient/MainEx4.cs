
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;


namespace WebAPIClient
{
	class MainEx4
	{
		static readonly HttpClient client = new HttpClient();
		static async Task Main(string[] args)
		{
			await ProcessRepositories();
		}
		
		private static async Task ProcessRepositories()
		{
			client.DefaultRequestHeaders.Accept.Clear();
			var stringTask = client.GetStringAsync("https://jsonplaceholder.typicode.com/users");
			var msg = await stringTask;
			var objects = JArray.Parse(msg);
			
			foreach (JObject root in objects)
			{
				string username = root["name"].Value<string>();
				string email = root["email"].Value<string>();

				Console.WriteLine(username);
				Console.WriteLine(email);
				Console.WriteLine("\n");
			}
		}
	}
}
