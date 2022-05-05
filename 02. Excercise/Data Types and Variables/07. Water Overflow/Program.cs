using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                int litters = int.Parse(Console.ReadLine());


                if (sum <= 255)
                {
                    sum += litters;
                    if (sum > 255)
                    {
                        sum -= litters;
                        Console.WriteLine("Insufficient capacity!");
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
