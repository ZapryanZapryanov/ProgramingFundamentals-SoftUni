using System;
using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            MatchCollection colect = Regex.Matches(text, @"(?<day>\d{2})(.|-|/)(?<month>[A-Z][a-z]{2})\1(?<years>\d{4})");

            foreach (Match item in colect)
            {
                Console.WriteLine($"Day: {item.Groups["day"].Value}, Month: {item.Groups["month"].Value}, Year: {item.Groups["years"].Value}");
            }
    }
}
