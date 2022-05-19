using System;
using System.Linq;

namespace _05._Longest_Increasing_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] list;
            int[] current = new int[numbers.Length];
            int[] prev = new int[numbers.Length];
            int maxLength = 0;
            int lastIndex = -1;

            for (int i = 0; i < numbers.Length; i++)
            {
                
                current[i] = 1;
                prev[i] = -1;

               
                for (int j = 0; j < i; j++)
                {
                    
                    if (numbers[j] < numbers[i] && current[j] >= current[i])
                    {
                        current[i] = 1 + current[j];
                        prev[i] = j; 
                    }
                }
                
                if (current[i] > maxLength)
                {
                    maxLength = current[i];
                    lastIndex = i;
                }
            }
            list = new int[maxLength];
            for (int i = 0; i < maxLength; i++)
            {
                list[i] = numbers[lastIndex];
                lastIndex = prev[lastIndex];
            }
            Array.Reverse(list);
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
