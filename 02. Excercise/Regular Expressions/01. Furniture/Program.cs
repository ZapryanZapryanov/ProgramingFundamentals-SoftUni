using System;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string regexName = @">>(?<name>[A-Za-z]+)<<(?<price>\d+\.?\d+)!(?<quantity>\d+)";
            decimal allPrice = 0m;
            Console.WriteLine("Bought furniture:");
            while (input != "Purchase")
            {
                Match matches = Regex.Match(input, regexName);
                if (matches.Success)
                {
                    string name = matches.Groups["name"].Value;
                    decimal price = decimal.Parse(matches.Groups["price"].Value);
                    int quantity = int.Parse(matches.Groups["quantity"].Value);
                    allPrice += price * quantity;

                    Console.WriteLine(name);

                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Total money spend: {allPrice:f2}");
        }
    }
}
