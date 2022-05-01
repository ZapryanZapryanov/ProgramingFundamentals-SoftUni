using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split().ToList();
            Dictionary<string, int> arr = new Dictionary<string, int>();
            foreach (var item in list)
            {
                string lowerCase = item.ToLower();
                if (arr.ContainsKey(lowerCase))
                {
                    arr[lowerCase] += 1;
                }
                else
                {
                    arr.Add(lowerCase, 1);
                }
            }
            List<string> result = arr.Where(item => item.Value % 2 != 0).Select(item => item.Key).ToList();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
