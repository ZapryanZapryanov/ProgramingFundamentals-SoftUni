using System;
using System.Linq;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                     .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                     .Select(int.Parse)
                     .ToArray();
            int n = int.Parse(Console.ReadLine());
            for (int a = 0; a < n; a++)
            {
                int index = arr[0];
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }
                arr[arr.Length - 1] = index;
            }
            Console.WriteLine(string.Join(" ", arr));

        }
    }
}
