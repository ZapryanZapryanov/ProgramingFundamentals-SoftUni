using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<SomeStudent> listStudent = new List<SomeStudent>();
            for (int i = 1; i <= n; i++)
            {
                string[] infoStudents = Console.ReadLine().Split(" ").ToArray();
                string firstName = infoStudents[0];
                string lastName = infoStudents[1];
                double grade = double.Parse(infoStudents[2]);
                SomeStudent newStudents = new SomeStudent(firstName, lastName, grade);
                listStudent.Add(newStudents);

            }


            List<SomeStudent> sortedStudents = listStudent.OrderByDescending(t => t.Grade).ToList();

            foreach (var item in sortedStudents)
            {
                Console.WriteLine(item);
            }
        }

        class SomeStudent
        {
            public SomeStudent(string firstName, string lastName, double grade)
            {
                this.FirstName = firstName;
                this.LastName = lastName;
                this.Grade = grade;
            }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public double Grade { get; set; }

            public override string ToString()
            {
                return $"{this.FirstName} {this.LastName}: {this.Grade:f2}";
            }
        }
    }
}
