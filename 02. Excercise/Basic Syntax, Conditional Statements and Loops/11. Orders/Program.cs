using System;

namespace _11._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double allSum = 0;

            for (int i = 0; i < n; i++)
            {
                double sum = 0;
                double PriceCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsule = int.Parse(Console.ReadLine());
                sum += PriceCapsule * days * capsule;
                allSum += PriceCapsule * days * capsule;
                Console.WriteLine($"The price for the coffee is: ${sum:f2}");
            }
            Console.WriteLine($"Total: ${allSum:f2}");
        }
    }
}
