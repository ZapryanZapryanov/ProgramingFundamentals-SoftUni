using System;

namespace _02._Division
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = int.Parse(Console.ReadLine());

            double sum = -1;
            if (num % 10 == 0)
            {
                sum = 10;
            }
            else if (num % 7 == 0)
            {
                sum = 7;
            }
            else if (num % 6 == 0)
            {
                sum = 6;
            }
            else if (num % 3 == 0)
            {
                sum = 3;
            }
            else if (num % 2 == 0)
            {
                sum = 2;
            }
            if (sum == -1)
            {
                Console.WriteLine("Not divisible");
            }
            else
            {
                Console.WriteLine($"The number is divisible by {sum}");
            }
        }
    }
}
