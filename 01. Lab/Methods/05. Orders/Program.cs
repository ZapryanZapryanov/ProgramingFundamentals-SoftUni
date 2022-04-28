using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int price = int.Parse(Console.ReadLine());
            printPriceall(product, price);



        }
        static void printPriceall(string product, int num)
        {
            if (product == "coffee")
            {
                decimal price = num * 1.50m;
                Console.WriteLine($"{price:f2}");
            }
            else if (product == "water")
            {
                decimal price = num * 1.00m;
                Console.WriteLine($"{price:f2}");
            }
            else if (product == "coke")
            {
                decimal price = num * 1.40m;
                Console.WriteLine($"{price:f2}");
            }
            else if (product == "snacks")
            {
                decimal price = num * 2.00m;
                Console.WriteLine($"{price:f2}");
            }
        }
    }
}
