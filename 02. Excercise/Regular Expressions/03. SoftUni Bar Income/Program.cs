using System;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();
            string validText = @"\%(?<name>[A-Z][a-z]+)%[^\|\$\%\.]*?<(?<product>\w+)>[^\|\$\%\.]*?\|(?<count>[0-9]+)\|[^\|\$\%\.]*?(?<price>\d+\.?\d+)\$";
            decimal sum = 0m;
            while (comand != "end of shift")
            {
                Match valid = Regex.Match(comand, validText);

                if (valid.Success)
                {
                    string name = valid.Groups["name"].Value;
                    string product = valid.Groups["product"].Value;
                    int count = int.Parse(valid.Groups["count"].Value);
                    decimal price = decimal.Parse(valid.Groups["price"].Value);

                    Console.WriteLine($"{name}: {product} - {(decimal)count * price:f2}");
                    sum += (decimal)count * price;

                }

                comand = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {sum:f2}");
        }
    }
}
