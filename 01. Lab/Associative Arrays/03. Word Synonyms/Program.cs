using System;
using System.Collections.Generic;

namespace _03._Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string sinonim = Console.ReadLine();
                if (dictionary.ContainsKey(word))
                {
                    dictionary[word].Add(sinonim);
                }
                else
                {
                    List<string> newList = new List<string>() { sinonim };
                    dictionary.Add(word, newList);
                }

            }
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }
        }
    }
}
