using System;

namespace _08._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            int bases = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMathPow(bases, power));
        }
        static int GetMathPow(int basis, int power)
        {
            int result = 1;
            for (int i = 1; i <= power; i++)
            {
                result *= basis;
            }
            return result;
        }
    }
}
