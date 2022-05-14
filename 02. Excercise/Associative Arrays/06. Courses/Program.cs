using System;
using System.Collections.Generic;

namespace _06._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();

            Dictionary<string, List<string>> course = new Dictionary<string, List<string>>();

            while (comand != "end")
            {
                string[] elements = comand.Split(" : ", StringSplitOptions.RemoveEmptyEntries);

                string courseName = elements[0];
                string studentsName = elements[1];

                if (course.ContainsKey(courseName))
                {
                    course[courseName].Add(studentsName);
                }
                else
                {
                    List<string> newList = new List<string>() { studentsName };
                    course.Add(courseName, newList);
                }

                comand = Console.ReadLine();
            }

            foreach (var item in course)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                foreach (var nextItem in item.Value)
                {
                    Console.WriteLine($"-- {string.Join(" ", nextItem)}");
                }
            }
        }
    }
}
