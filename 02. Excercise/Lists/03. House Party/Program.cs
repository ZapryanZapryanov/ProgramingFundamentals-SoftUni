using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> human = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string[] people = Console.ReadLine().Split(" ").ToArray();
                if (people[2] == "not")
                {
                    if (!human.Contains(people[0]))
                    {
                        Console.WriteLine($"{people[0]} is not in the list!");
                        continue;
                    }
                    human.Remove(people[0]);


                }
                else
                {
                    if (human.Contains(people[0]))
                    {
                        Console.WriteLine($"{people[0]} is already in the list!");
                        continue;
                    }
                    human.Add(people[0]);
                }
            }

            for (int i = 0; i < human.Count; i++)
            {
                Console.WriteLine(human[i]);
            }
        }
    }
}
