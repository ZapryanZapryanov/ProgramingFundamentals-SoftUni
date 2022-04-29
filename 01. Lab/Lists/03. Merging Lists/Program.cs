using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> first = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> second = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> all = new List<int>();
            int sum = Math.Max(first.Count, second.Count);
            for (int i = 0; i < sum; i++)
            {
                if (i < first.Count)
                {
                    all.Add(first[i]);
                }
                if (i < second.Count)
                {
                    all.Add(second[i]);
                }
            }
            Console.WriteLine(string.Join(" ", all));
        }
    }
}
