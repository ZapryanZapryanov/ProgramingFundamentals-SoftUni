using System;
using System.Collections.Generic;
using System.Linq;
namespace _07._Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();
            List<People> newList = new List<People>();
            while (comand != "End")
            {
                string[] elements = comand.Split(" ").ToArray();
                string name = elements[0];
                int id = int.Parse(elements[1]);
                int age = int.Parse(elements[2]);
                People onePerson = new People(name, id, age);
                if (newList.Any(x => x.Id == id))
                {
                    onePerson.GetAge(age);
                    onePerson.GetName(name);
                }
                newList.Add(onePerson);
                comand = Console.ReadLine();
            }
            List<People> sort = newList.OrderBy(x => x.Age).ToList();

            foreach (var item in sort)
            {
                Console.WriteLine(item);
            }


        }
        class People
        {
            public People(string name, int id, int age)
            {
                this.Name = name;
                this.Id = id;
                this.Age = age;
            }
            public string Name { get; set; }
            public int Id { get; set; }
            public int Age { get; set; }

            public void GetName(string newName)
            {
                this.Name = newName;
            }
            public void GetAge(int age)
            {
                this.Age = age;
            }

            public override string ToString()
            {
                return $"{this.Name} with ID: {this.Id} is {this.Age} years old.";
            }

        }
    }
}
