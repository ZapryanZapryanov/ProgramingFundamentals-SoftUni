using System;

namespace _09._Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int all = 0;
            for (int i = 0; i < n; i++)
            {
                sum = 1 + (i * 2);
                all += sum;
                Console.WriteLine(sum);
            }
            Console.WriteLine($"Sum: {all}");
        }
    }
}
