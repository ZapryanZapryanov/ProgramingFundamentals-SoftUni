using System;

namespace _06._Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] items = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int evenSum = 0;
            int oddSum = 0;
            for (int i = 0; i < items.Length; i++)
            {
                int currItems = items[i];
                if (currItems % 2 == 0)
                {
                    evenSum += currItems;
                }
                else
                {
                    oddSum += currItems;
                }
            }
            int allSum = evenSum - oddSum;
            Console.WriteLine(allSum);
        }
    }
}
