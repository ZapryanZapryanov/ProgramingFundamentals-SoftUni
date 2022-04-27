using System;

namespace _03._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rawInput = Console.ReadLine().Split();
            double[] arrayItems = new double[rawInput.Length];

            for (int i = 0; i < rawInput.Length; i++)
            {
                arrayItems[i] = double.Parse(rawInput[i]);

            }
            for (int i = 0; i < arrayItems.Length; i++)
            {
                Console.WriteLine($"{arrayItems[i]} => {Math.Round(arrayItems[i], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
