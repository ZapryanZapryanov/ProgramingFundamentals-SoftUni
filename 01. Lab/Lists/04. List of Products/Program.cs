﻿using System;
using System.Collections.Generic;

namespace _04._List_of_Products
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> products = new List<string>();
            int counter = 0;
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                products.Add(name);
                counter++;
                products.Sort();


            }
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{products[i]}");
            }
        }
    }
}
