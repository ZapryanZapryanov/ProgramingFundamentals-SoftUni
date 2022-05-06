using System;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] firstArr = new int[n];
            int[] secondArr = new int[n];


            for (int i = 1; i <= n; i++)
            {
                int[] items = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int first = items[0];
                int second = items[1];
                if (i % 2 == 0)
                {
                    firstArr[i - 1] = first;
                    secondArr[i - 1] = second;
                }
                else
                {
                    firstArr[i - 1] = second;
                    secondArr[i - 1] = first;
                }

            }
            Console.WriteLine(string.Join(" ", secondArr));
            Console.WriteLine(string.Join(" ", firstArr));

        }
    }
}
