using System;
using System.Collections.Generic;
using System.Linq;


namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            string comand = Console.ReadLine();

            while (comand != "end")
            {
                string[] input = comand.Split(" ");
                if (input[0] == "Delete")
                {
                    int element = int.Parse(input[1]);
                    list.RemoveAll(x => x == element);
                }
                else if (input[0] == "Insert")
                {
                    int element = int.Parse(input[1]);
                    int position = int.Parse(input[2]);
                    list.Insert(position, element);

                }


                comand = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
