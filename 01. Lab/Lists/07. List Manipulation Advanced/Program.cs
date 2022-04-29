using System;

namespace _07._List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            string comand = Console.ReadLine();
            bool flag = false;
            while (comand != "end")
            {
                string[] program = comand.Split(" ");
                string firstElements = program[0];
                if (firstElements == "Add")
                {
                    int elements = int.Parse(program[1]);
                    list.Add(elements);
                    flag = true;
                }
                else if (firstElements == "Remove")
                {
                    int number = int.Parse(program[1]);
                    list.Remove(number);
                    flag = true;
                }
                else if (firstElements == "RemoveAt")
                {
                    int num = int.Parse(program[1]);
                    list.RemoveAt(num);
                    flag = true;
                }
                else if (firstElements == "Insert")
                {
                    int num = int.Parse(program[1]);
                    int number = int.Parse(program[2]);
                    list.Insert(number, num);
                    flag = true;
                }
                else if (firstElements == "Contains")
                {

                    int num = int.Parse(program[1]);
                    if (list.Contains(num))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");

                    }
                }
                else if (firstElements == "PrintEven")
                {
                    List<int> result = list.FindAll(x => x % 2 == 0);
                    Console.WriteLine(string.Join(" ", result));

                }
                else if (firstElements == "PrintOdd")
                {
                    List<int> result = list.FindAll(x => x % 2 != 0);
                    Console.WriteLine(string.Join(" ", result));

                }
                else if (firstElements == "GetSum")
                {
                    int sum = list.Sum();
                    Console.WriteLine(sum);

                }
                else if (firstElements == "Filter")
                {
                    string condition = program[1];
                    int num = int.Parse(program[2]);

                    switch (condition)
                    {
                        case "<":
                            List<int> result = list.FindAll(x => x < num);
                            Console.WriteLine(string.Join(" ", result));
                            break;
                        case "<=":
                            List<int> arr = list.FindAll(x => x <= num);
                            Console.WriteLine(string.Join(" ", arr));
                            break;
                        case ">":
                            List<int> agg = list.FindAll(x => x > num);
                            Console.WriteLine(string.Join(" ", agg));
                            break;
                        case ">=":
                            List<int> ahh = list.FindAll(x => x >= num);
                            Console.WriteLine(string.Join(" ", ahh));
                            break;
                    }
                }


                comand = Console.ReadLine();
            }
            if (flag)
            {
                Console.WriteLine(string.Join(" ", list));
            }
        }
    }
}
