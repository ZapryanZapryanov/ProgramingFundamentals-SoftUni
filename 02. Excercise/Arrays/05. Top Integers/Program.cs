using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            int[] big = new int[arr.Length];
            int bigIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int nextNum = arr[i];
                bool flag = true;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    int currNum = arr[j];
                    if (currNum >= nextNum)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    big[bigIndex] = nextNum;
                    bigIndex++;
                }
            }
            for (int i = 0; i < bigIndex; i++)
            {
                Console.Write($"{big[i]} ");
            }
        }
    }
}
