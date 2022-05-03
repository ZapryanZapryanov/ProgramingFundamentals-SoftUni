using System;
using System.Text.RegularExpressions;

namespace _01._Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();


            MatchCollection word = Regex.Matches(text, @"\b[A-Z][a-z]+ [A-Z][a-z]+\b");

            foreach (Match item in word)
            {
                Console.Write($"{item.Value} ");
            }
        }
    }
}
