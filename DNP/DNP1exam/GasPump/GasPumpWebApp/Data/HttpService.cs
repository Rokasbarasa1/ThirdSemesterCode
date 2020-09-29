using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace GasPumpWebApp.Data
{
    public class HttpService
    {
		public double GetCostOfFullTank(double size)
		{
			String URL = "https://localhost:5001/gaspump/CostOfFullTank/?size=" + size;
			using (var client = new HttpClient())
			{
				var response = client.GetStringAsync(URL);
				size = Double.Parse(response.Result);
				return size;
			}
		}

		public double GetFillTank(double amount)
		{
			String URL = "https://localhost:5001/gaspump/FillTank/?amount=" + amount;
			using (var client = new HttpClient())
			{
				var response = client.GetStringAsync(URL);
				amount = Double.Parse(response.Result);
				return amount;
			}
		}

		public IList<Refil> GetRefils()
		{
			String URL = "https://localhost:5001/gaspump/Refils";
			using (var client = new HttpClient())
			{
				var response = client.GetStringAsync(URL);
				string list = response.Result;
				IList<Refil> refils = JsonConvert.DeserializeObject<IList<Refil>>(list);
				return refils;
			}
		}

		public string PostFillPump()
		{
			String URL = "https://localhost:5001/gaspump/FillPump";
			StringContent info = new StringContent("", Encoding.UTF8, "application/json");
			using (var client = new HttpClient())
			{
				var response = client.PostAsync(URL, info);
				//Will not work on client for some reason, works with postman
				return "Pump refiled";
			}
		}
	}
}
