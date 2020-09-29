using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Data
{
    public class HttpHandlerService
    {
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
	}
}
