using System;
using System.Collections.Generic;

namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            string comand = Console.ReadLine();
            while (comand != "end")
            {
                string[] program = comand.Split(" ");
                string firstElements = program[0];
                if (firstElements == "Add")
                {
                    int elements = int.Parse(program[1]);
                    list.Add(elements);
                }
                else if (firstElements == "Remove")
                {
                    int number = int.Parse(program[1]);
                    list.Remove(number);
                }
                else if (firstElements == "RemoveAt")
                {
                    int num = int.Parse(program[1]);
                    list.RemoveAt(num);
                }
                else if (firstElements == "Insert")
                {
                    int num = int.Parse(program[1]);
                    int number = int.Parse(program[2]);
                    list.Insert(number, num);
                }



                comand = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
