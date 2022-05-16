using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace _04._Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string patern = @"@(?<name>[A-Za-z]+)[^@|-|!|:|>]*?:(?<people>\d+)[^@|-|!|:|>]*?!(?<attack>[A-Z]{1})![^@|-|!|:|>]*?[->](?<solders>\d+)";
            Dictionary<string, int> attackPlanets = new Dictionary<string, int>();
            Dictionary<string, int> destroyPlanets = new Dictionary<string, int>();
            for (int i = 1; i <= n; i++)
            {
                string input = Console.ReadLine();
                string text = GetWords(input);
                Match planets = Regex.Match(text, patern);
                string atack = planets.Groups["attack"].Value;
                if (atack == "A")
                {
                    attackPlanets.Add(planets.Groups["name"].Value, 1);
                }
                else if (atack == "D")
                {
                    destroyPlanets.Add(planets.Groups["name"].Value, 1);
                }
            }
            Console.WriteLine($"Attacked planets: {attackPlanets.Count}");
            foreach (var item in attackPlanets.OrderBy(x => x.Key))
            {
                Console.WriteLine($"-> {item.Key}");
            }
            Console.WriteLine($"Destroyed planets: {destroyPlanets.Count}");
            foreach (var item in destroyPlanets.OrderBy(x => x.Key))
            {
                Console.WriteLine($"-> {item.Key}");
            }
        }
        static int GetNumberInText(string input)
        {
            string patern = "[STAR]";
            string text = input.ToUpper();
            MatchCollection chars = Regex.Matches(text, patern);
            return chars.Count;
        }
        static string GetWords(string input)
        {
            StringBuilder sb = new StringBuilder();
            int num = GetNumberInText(input);
            foreach (char item in input)
            {
                sb.Append((char)(item - num));
            }
            return sb.ToString();
        }
    }
}
