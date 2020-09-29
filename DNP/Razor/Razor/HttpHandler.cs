using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Razor
{
	public class HttpHandler
	{
		private HttpHandler()
		{
		}

		private static HttpHandler _instance;


		public static HttpHandler getInstance()
		{
			if (_instance == null)
			{
				_instance = new HttpHandler();
			}
			return _instance;
		}

		public string GetPR(String URL)
		{
			using (var client = new HttpClient())
			{
				var response = client.GetStringAsync(URL);
				return response.Result;
			}
		}

		public string PostPR(String URL, String BODY)
		{
			using (var client = new HttpClient())
			{
				StringContent info = new StringContent(BODY, Encoding.UTF8, "application/json");
				var response = client.PostAsync(URL, info).Result;

				if (response.IsSuccessStatusCode)
				{
					var responseContent = response.Content;
					string responseString = responseContent.ReadAsStringAsync().Result;

					return responseString;
				}
				return "failed";
			}
		}
		/*
		public async Task<string> PutPR(String URL, String BODY)
		{
			client.DefaultRequestHeaders.Accept.Clear();
			StringContent httpContent = new StringContent(BODY, Encoding.UTF8, "application/json");

			HttpResponseMessage stringTask = await client.PutAsync(URL, httpContent);

			return msg;
		}
		public async Task<string> DeletePR(String URL)
		{
			client.DefaultRequestHeaders.Accept.Clear();
			var stringTask = client.DeleteAsync(URL);
			var msg = await stringTask;

			return msg;
		}
		*/

	}
}
