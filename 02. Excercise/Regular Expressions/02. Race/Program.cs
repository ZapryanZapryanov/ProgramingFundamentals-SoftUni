using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> players = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string comand = Console.ReadLine();
            Dictionary<string, int> people = new Dictionary<string, int>();

            while (comand != "end of race")
            {
                string name = GetName(comand);
                int num = GetDigit(comand);
                if (players.Contains(name))
                {
                    if (people.ContainsKey(name))
                    {
                        people[name] += num;
                    }
                    else
                    {
                        people.Add(name, num);
                    }

                }

                comand = Console.ReadLine();
            }


            int count = 0;
            foreach (var item in people.OrderByDescending(x => x.Value))
            {
                count++;
                if (count == 1)
                {
                    Console.WriteLine($"1st place: {item.Key}");
                }

                else if (count == 2)
                {
                    Console.WriteLine($"2nd place: {item.Key}");
                }

                else if (count == 3)
                {
                    Console.WriteLine($"3rd place: {item.Key}");
                    break;
                }
            }


        }
        static string GetName(string input)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char ch in input)
            {
                if (char.IsLetter(ch))
                {
                    sb.Append(ch);
                }
            }
            return sb.ToString();
        }
        static int GetDigit(string input)
        {
            int sum = 0;
            int digit = 0;
            foreach (char ch in input)
            {
                if (char.IsDigit(ch))
                {
                    digit = (char)ch - 48;
                    sum += digit;
                }
            }
            return sum;
        }
    }
}
