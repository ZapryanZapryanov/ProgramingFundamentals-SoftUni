using System;
using System.Numerics;

namespace _11._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int firstSum = 0;
            BigInteger allSum = 0;
            BigInteger max = 0;
            int a = 0;
            int b = 0;
            int c = 0;
            for (int i = 1; i <= n; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                firstSum = snowballSnow / snowballTime;
                allSum = BigInteger.Pow(firstSum, snowballQuality);
                if (allSum > max)
                {
                    max = allSum;
                    a = snowballSnow;
                    b = snowballTime;
                    c = snowballQuality;
                }



            }
            Console.WriteLine($"{a} : {b} = {max} ({c})");
        }
    }
}
