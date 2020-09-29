using System;
using System.IO;

namespace Session4.Ex1
{
    class MainEx1
    {
        static void Main(string[] args)
        {
            try
            {
                using(var sr = new StreamReader(@"C:\Users\Rokas\Desktop\Lessons\DES\session1\Session4\Ex1\file.txt"))
                {
                    String LongestWord = null; 
                    string line;
                    int wordsLength = 0;
                    while ((line = sr.ReadLine()) != null)
                    {
                        String[] words = line.Split(' ');
                        wordsLength = +words.Length;
                        for (int i = 0; i < words.Length; i++)
                        {
                            if(words[i].Length > LongestWord.Length)
                            {
                                LongestWord = words[i];
                            }
                        }
                    }
                    Console.WriteLine(wordsLength + " is the amount of words in file");
                    Console.WriteLine(LongestWord + " is the longest word in the text");
                }
            }catch(Exception e)
            {
                Console.WriteLine("The file could not be read");
                Console.WriteLine(e.Message);
            }
        }
    }
}
