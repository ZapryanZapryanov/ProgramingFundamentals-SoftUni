using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();

            Dictionary<string, int> people = new Dictionary<string, int>();
            Dictionary<string, int> gold = new Dictionary<string, int>();

            while (comand != "Sail")
            {
                string[] elements = comand.Split("||", StringSplitOptions.RemoveEmptyEntries);
                string town = elements[0];
                int person = int.Parse(elements[1]);
                int golds = int.Parse(elements[2]);
                if (people.ContainsKey(town))
                {
                    people[town] += person;
                    gold[town] += golds;
                }
                else
                {
                    people.Add(town, person);
                    gold.Add(town, golds);
                }



                comand = Console.ReadLine();
            }

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] elements = input.Split("=>", StringSplitOptions.RemoveEmptyEntries);

                string firstComand = elements[0];

                if (firstComand == "Plunder")
                {
                    int peopleFirst = int.Parse(elements[2]);
                    int goldsFirst = int.Parse(elements[3]);
                    string city = elements[1];
                    people[city] -= peopleFirst;
                    gold[city] -= goldsFirst;
                    Console.WriteLine($"{city} plundered! {goldsFirst} gold stolen, {peopleFirst} citizens killed.");
                    if (people[city] <= 0 || gold[city] <= 0)
                    {
                        people.Remove(city);
                        gold.Remove(city);
                        Console.WriteLine($"{city} has been wiped off the map!");
                    }
                }
                else if (firstComand == "Prosper")
                {
                    int allGold = int.Parse(elements[2]);
                    if (allGold < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                        input = Console.ReadLine();
                        continue;
                    }

                    gold[elements[1]] += allGold;

                    Console.WriteLine($"{allGold} gold added to the city treasury. {elements[1]} now has {gold[elements[1]]} gold.");
                }

                input = Console.ReadLine();
            }
            if (gold.Count == 0)
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! There are {gold.Count} wealthy settlements to go to:");
                Console.WriteLine(string.Join($"{Environment.NewLine}", gold.Select(x => $"{x.Key} -> Population: {people[x.Key]} citizens, Gold: {x.Value} kg")));
                // Console.WriteLine(string.Join
                // ($"{Environment.NewLine}",distance.Select(x=> $"{x.Key} -> Mileage: {x.Value} kms, Fuel in the tank: {fuel[x.Key]} lt.")));
            }
        }
    }
}
