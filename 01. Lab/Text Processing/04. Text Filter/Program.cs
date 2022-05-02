using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> banedWords = Console.ReadLine().Split(", ").ToList();
            string text = Console.ReadLine();
            foreach (var item in banedWords)
            {
                text = text.Replace(item, new string('*', item.Length));
            }
            Console.WriteLine(text);
        }
    }
}
