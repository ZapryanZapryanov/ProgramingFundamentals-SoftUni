using System;

namespace _08._Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            decimal sum = 0;
            for (int i = 0; i < text.Length; i++)
            {
                string firstWOrds = text[i];
                sum += GetSum(firstWOrds);
            }
            Console.WriteLine($"{sum:f2}");

        }
        static decimal GetSum(string words)
        {
            char firstLetter = words[0];
            char lastLetter = words[words.Length - 1];
            words = words.Substring(1, words.Length - 2);
            decimal num = int.Parse(words);
            decimal allSum = 0;
            int upperSum = 0;
            int lowerSum = 0;
            if (char.IsUpper(firstLetter))
            {
                upperSum = firstLetter - 64;
                num /= upperSum;
                allSum += num;
                upperSum = 0;
            }
            else if (char.IsLower(firstLetter))
            {
                lowerSum = firstLetter - 96;
                num *= lowerSum;
                allSum += num;
                lowerSum = 0;
            }
            if (char.IsUpper(lastLetter))
            {
                upperSum = lastLetter - 64;
                allSum -= upperSum;
                upperSum = 0;
            }
            else if (char.IsLower(lastLetter))
            {
                lowerSum = lastLetter - 96;
                allSum += lowerSum;
                lowerSum = 0;
            }
            return allSum;
        }
    }
}
