using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList();
            SortedDictionary<int, int> arr = new SortedDictionary<int, int>();
            foreach (var item in list)
            {
                if (arr.ContainsKey(item))
                {
                    arr[item] += 1;
                }
                else
                {
                    arr.Add(item, 1);
                }
            }
            foreach (var item in arr)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
      
         }
    }

