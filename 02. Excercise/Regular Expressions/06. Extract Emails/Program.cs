using System;
using System.Text.RegularExpressions;

namespace _06._Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string patern = @"(?<=\s)(?<user>[A-Za-z0-9]+[.-]*\w*)*@([a-z]+([.-][a-z]*)*(\.[a-z]{2,}))";
            MatchCollection words = Regex.Matches(text, patern);

            foreach (Match item in words)
            {
                Console.WriteLine($"{item.Value}");
            }
        }
    }
}
