﻿using System;

namespace _04._Print_and_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int stopNum = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = startNum; i <= stopNum; i++)
            {
                sum += i;
                Console.Write($"{i} ");

            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
