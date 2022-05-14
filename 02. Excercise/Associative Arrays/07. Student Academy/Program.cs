using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string nameStudents = Console.ReadLine();
                double gradeOfStudents = double.Parse(Console.ReadLine());

                if (students.ContainsKey(nameStudents))
                {
                    students[nameStudents].Add(gradeOfStudents);
                }
                else
                {
                    List<double> oneGrade = new List<double>() { gradeOfStudents };
                    students.Add(nameStudents, oneGrade);
                }
            }


            foreach (var item in students)
            {
                double finaly = item.Value.Sum();
                double exam = (double)finaly / item.Value.Count;

                if (exam >= 4.50)
                {
                    Console.WriteLine($"{item.Key} -> {exam:f2}");
                }
            }
        }
    }
}
