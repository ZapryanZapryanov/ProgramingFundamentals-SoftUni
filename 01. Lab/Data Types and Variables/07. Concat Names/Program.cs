﻿using System;

namespace _07._Concat_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1 = Console.ReadLine();
            string name2 = Console.ReadLine();
            string name3 = Console.ReadLine();
            Console.Write($"{name1}{name3}{name2}");
        }
    }
}
