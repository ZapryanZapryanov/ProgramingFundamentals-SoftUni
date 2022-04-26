using System;

namespace _01._Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            decimal kilometars = (decimal)(number / 1000);
            Console.WriteLine($"{kilometars:f2}");
        }
    }
}
