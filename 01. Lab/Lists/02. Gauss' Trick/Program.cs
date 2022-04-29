using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arrList = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> numbers = new List<int>();
            for (int i = 0; i < arrList.Count / 2; i++)
            {
                int sum = arrList[i] + arrList[arrList.Count - i - 1];
                numbers.Add(sum);
            }
            if (arrList.Count % 2 != 0)
            {
                numbers.Add(arrList[arrList.Count / 2]);
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
