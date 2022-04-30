using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().ToList();
            Random rand = new Random();
            for (int i = 0; i < words.Count; i++)
            {
                int randomIndex = rand.Next(0, words.Count);
                string currWords = words[i];
                words[i] = words[randomIndex];
                words[randomIndex] = currWords;

            }
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
