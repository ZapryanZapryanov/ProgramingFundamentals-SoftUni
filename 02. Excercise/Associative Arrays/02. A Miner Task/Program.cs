using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            string comand;
            while ((comand = Console.ReadLine()) != "stop")
            {
                int quality = int.Parse(Console.ReadLine());
                if (dictionary.ContainsKey(comand))
                {
                    dictionary[comand] += quality;
                }
                else
                {
                    dictionary[comand] = quality;
                }
            }
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
