using System;
using System.Collections.Generic;

namespace _04._Students
{
    class Student
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string HomeTown { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();
            List<Student> listStudents = new List<Student>();
            while (comand != "end")
            {
                string[] element = comand.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string firstName = element[0];
                string lastName = element[1];
                int age = int.Parse(element[2]);
                string homeTown = element[3];
                Student oneStudent = new Student();
                oneStudent.FirstName = firstName;
                oneStudent.LastName = lastName;
                oneStudent.Age = age;
                oneStudent.HomeTown = homeTown;
                listStudents.Add(oneStudent);



                comand = Console.ReadLine();
            }
            string town = Console.ReadLine();
            List<Student> newList = listStudents.FindAll(x => x.HomeTown == town);
            foreach (var item in newList)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName} is {item.Age} years old.");
            }
        }
    }
}
