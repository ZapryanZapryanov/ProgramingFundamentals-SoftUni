using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Emoji_Detector
{
    class Program
    {
        static void Main(string[] args)
        {
            string emoji = Console.ReadLine();

            int sumDiggit = GetSum(emoji);
            Console.WriteLine($"Cool threshold: {sumDiggit}");
            Regex regex = new Regex(@"(\:\:|\*\*)[A-Z][a-z]{2,}\1");
            MatchCollection matches = regex.Matches(emoji);
            List<string> bestEmoji = new List<string>();

            foreach (Match item in matches)
            {
                int sum = 0;
                string words = item.Value;
                foreach (char ch in words)
                {
                    if (char.IsLetter(ch))
                    {
                        sum += ch;
                    }

                }
                if (sum >= sumDiggit)
                {
                    bestEmoji.Add(words);
                }
            }
            Console.WriteLine($"{matches.Count} emojis found in the text. The cool ones are:");
            Console.WriteLine(string.Join(Environment.NewLine, bestEmoji));
        }
        static int GetSum(string text)
        {
            Regex numbers = new Regex(@"\d");
            MatchCollection diggit = numbers.Matches(text);
            int sum = 1;
            foreach (Match item in diggit)
            {
                sum *= int.Parse(item.Value);
            }
            return sum;
        }
    }
}
