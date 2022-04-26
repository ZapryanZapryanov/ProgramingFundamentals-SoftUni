using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int sum = i;
                int curent = 0;
                while (sum != 0)
                {
                    curent += sum % 10;
                    sum /= 10;
                }
                if (curent == 5 || curent == 7 || curent == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
    }
}
