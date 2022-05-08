using System;
using System.Linq;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            Console.WriteLine(GetVowels(word));
        }
        static int GetVowels(string word)
        {
            char[] vowels = new char[]
            {
                'a',
                'e',
                'i',
                'o',
                'u'
            };
            int counter = 0;
            foreach (char charucter in word.ToLower())
            {
                if (vowels.Contains(charucter))
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
