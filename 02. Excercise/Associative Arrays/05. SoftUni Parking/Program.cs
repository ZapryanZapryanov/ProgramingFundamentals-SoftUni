using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> parky = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                string comand = input[0];
                if (comand == "register")
                {
                    if (parky.ContainsKey(input[1]))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {parky[input[1]]}");
                    }
                    else
                    {
                        string number = input[2];
                        parky.Add(input[1], number);
                        Console.WriteLine($"{input[1]} registered {number} successfully");
                    }
                }
                else if (comand == "unregister")
                {
                    if (!parky.ContainsKey(input[1]))
                    {
                        Console.WriteLine($"ERROR: user {input[1]} not found");
                    }
                    else
                    {
                        parky.Remove(input[1]);
                        Console.WriteLine($"{input[1]} unregistered successfully");
                    }
                }
            }
            foreach (var finaly in parky)
            {
                Console.WriteLine($"{finaly.Key} => {finaly.Value}");
            }
        }
    }
}
