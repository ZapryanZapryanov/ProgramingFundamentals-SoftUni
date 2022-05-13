using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> goodElements = new Dictionary<string, int>()
            {
                { "shards", 0 },
                { "motes", 0 },
                { "fragments", 0 }
            };
            Dictionary<string, int> junk = new Dictionary<string, int>();
            string legendaryElement = string.Empty;

            while (string.IsNullOrEmpty(legendaryElement))
            {
                string[] elements = Console.ReadLine().Split(" ").ToArray();

                for (int i = 0; i < elements.Length; i += 2)
                {
                    int first = int.Parse(elements[i]);
                    string secand = elements[i + 1].ToLower();

                    if (secand == "shards")
                    {
                        goodElements[secand] += first;
                        if (goodElements[secand] >= 250)
                        {
                            goodElements[secand] -= 250;
                            legendaryElement = "Shadowmourne";
                            break;
                        }
                    }
                    else if (secand == "fragments")
                    {
                        goodElements[secand] += first;
                        if (goodElements[secand] >= 250)
                        {
                            goodElements[secand] -= 250;
                            legendaryElement = "Valanyr";
                            break;
                        }
                    }
                    else if (secand == "motes")
                    {
                        goodElements[secand] += first;
                        if (goodElements[secand] >= 250)
                        {
                            goodElements[secand] -= 250;
                            legendaryElement = "Dragonwrath";
                            break;
                        }
                    }
                    else
                    {
                        junk.Add(secand, first);
                    }


                }
            }

            Console.WriteLine($"{legendaryElement} obtained!");
            foreach (var item in goodElements)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var newItem in junk)
            {
                Console.WriteLine($"{newItem.Key}: {newItem.Value}");
            }
        }
    }
}
