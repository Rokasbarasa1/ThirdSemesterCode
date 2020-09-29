
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization.Json;
using System.Text.Json;
using System.Threading.Tasks;


namespace Session5.Ex5
{
	class MainEx5
	{
		static readonly HttpClient client = new HttpClient();
		static async Task Main(string[] args)
		{
			String message = await ProcessRepositories();
			Console.WriteLine(message);
			char[] lettersBad = message.ToCharArray();
			List<char> letters = new List<char>();
			for (int i = 0; i < lettersBad.Length; i++)
			{
				letters.Add(lettersBad[i]);
			}
			letters.Remove('[');
			letters.Remove('"');
			letters.Remove('"');
			letters.Remove(']');
			int correctLetters = 0;

			char[] score = new char[letters.Count];
			for (int i = 0; i < letters.Count; i++)
			{
				score[i] = '_';
			}
			List<char> guessedLetters = new List<char>();
			while(correctLetters != letters.Count)
			{
				Console.WriteLine("Guess a word:");
				for (int i = 0; i < score.Length; i++)
				{
					Console.Write(score[i]);
				}
				Console.WriteLine("\n");
				Console.WriteLine("Your letter?");

				String letter = Console.ReadLine();
				char[] guessedCorrect = letter.ToCharArray();
				int teporaryCorrect = correctLetters;

				for (int i = 0; i < score.Length; i++)
				{
					if (letters[i].Equals(guessedCorrect[0]))
					{
						correctLetters++;
						score[i] = guessedCorrect[0];
					}
				}
				if(teporaryCorrect < correctLetters)
				{
					correctLetters = teporaryCorrect++;
					guessedLetters.Add(guessedCorrect[0]);
				}
			}
			Console.WriteLine("Guess the letters:");
		}
		
		public static async Task<String> ProcessRepositories()
		{
			client.DefaultRequestHeaders.Accept.Clear();
			//client.DefaultRequestHeaders.Accept.Add(
			//	new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json")
			//);
			//client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

			var stringTask = client.GetStringAsync("https://random-word-api.herokuapp.com/word?number=1");
			String msg = await stringTask;
			return msg;
		}
	}
}
