using System;

namespace _11._Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            if (n > 10)
            {
                Console.WriteLine($"{number} X {n} = {number * n}");
            }
            else
            {
                for (int i = n; i <= 10; i++)
                {
                    Console.WriteLine($"{number} X {i} = {number * i}");
                }
            }

        }
    }
}
