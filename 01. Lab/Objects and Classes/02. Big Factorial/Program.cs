using System;
using System.Numerics;

namespace _02._Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger numbers = 1;
            for (int i = 1; i <= n; i++)
            {
                numbers *= i;
            }
            Console.WriteLine(numbers);
        }
    }
}
