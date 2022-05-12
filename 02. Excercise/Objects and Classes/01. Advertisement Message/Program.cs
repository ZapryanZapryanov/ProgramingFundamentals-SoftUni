using System;
using System.Collections.Generic;

namespace _1._Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {



            List<string> phrases = new List<string>()
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Exceptional product.",
                "I can’t live without this product."
            };
            List<string> events = new List<string>()
            {

                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };
            List<string> authors = new List<string>()
            {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
            };
            List<string> cities = new List<string>()
            {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
            };
            int n = int.Parse(Console.ReadLine());

            Random currMessenger = new Random();
            for (int i = 1; i <= n; i++)
            {
                int PhraseIndex = currMessenger.Next(0, phrases.Count);
                int EventIndex = currMessenger.Next(0, events.Count);
                int AuthorIndex = currMessenger.Next(0, authors.Count);
                int CityIndex = currMessenger.Next(0, cities.Count);
                Console.WriteLine($"{phrases[PhraseIndex]} {events[EventIndex]} {authors[AuthorIndex]} – {cities[CityIndex]}.");
            }

        }
    }
}