using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(", ").ToList();
            string comand = Console.ReadLine();

            while (comand != "course start")
            {
                string[] leeson = comand.Split(":", StringSplitOptions.RemoveEmptyEntries);
                string firstComand = leeson[0];
                if (firstComand == "Add")
                {
                    if (!list.Contains(leeson[1]))
                    {
                        list.Add(leeson[1]);
                    }
                }
                else if (firstComand == "Insert")
                {
                    if (!list.Contains(leeson[1]))
                    {
                        int index = int.Parse(leeson[2]);
                        list.Insert(index, leeson[1]);
                    }
                }
                else if (firstComand == "Remove")
                {
                    if (list.Contains(leeson[1]))
                    {
                        if (list.Contains(leeson[1] + "-Exercise"))
                        {
                            list.Remove(leeson[1] + "-Exercise");
                        }
                        else
                        {
                            list.Remove(leeson[1]);
                        }

                    }
                }
                else if (firstComand == "Swap")
                {
                    if (list.Contains(leeson[1]) && list.Contains(leeson[2]))
                    {
                        string firstElement = leeson[1];
                        string secondElement = leeson[2];
                        int indexSecond = list.IndexOf(secondElement);
                        list.Insert(indexSecond, firstElement);
                        list.Remove(secondElement);
                        int index = list.IndexOf(firstElement);
                        list.Insert(index, secondElement);
                        list.Remove(firstElement);


                    }
                }
                else if (firstComand == "Exercise")
                {

                    if (list.Contains(leeson[1]) && !list.Contains(leeson[1] + "-Exercise"))
                    {
                        int result = list.IndexOf(leeson[1]);
                        list.Add(result + "-Exercise");

                    }
                    else
                    {
                        list.Add(leeson[1] + "-Exercise");
                    }
                }


                comand = Console.ReadLine();
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{list[i]}");
            }
        }
    }
}
