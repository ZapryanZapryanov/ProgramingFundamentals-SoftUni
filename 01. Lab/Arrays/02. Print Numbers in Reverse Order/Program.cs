using System;

namespace _02._Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arraysa = new int[n];

            for (int i = 0; i < n; i++)
            {
                arraysa[i] = int.Parse(Console.ReadLine());
            }
            for (int i = arraysa.Length - 1; i >= 0; i--)
            {
                Console.Write($"{arraysa[i]} ");
            }
            Console.WriteLine();
        }
    }
}
