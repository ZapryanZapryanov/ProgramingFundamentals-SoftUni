using System;
using System.Collections.Generic;

namespace _08._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();

            Dictionary<string, List<string>> company = new Dictionary<string, List<string>>();

            while (comand != "End")
            {
                string[] elements = comand.Split(" -> ");
                string nameFirm = elements[0];
                string idEmployee = elements[1];
                List<string> newId = new List<string>() { idEmployee };

                if (company.ContainsKey(nameFirm))
                {
                    if (company[nameFirm].Contains(idEmployee))
                    {
                        comand = Console.ReadLine();
                        continue;
                    }
                    company[nameFirm].Add(idEmployee);
                }
                else
                {
                    company.Add(nameFirm, newId);

                }



                comand = Console.ReadLine();
            }

            foreach (var item in company)
            {
                Console.WriteLine($"{item.Key}");

                foreach (var items in item.Value)
                {
                    Console.WriteLine($"-- {string.Join(" ", items)}");
                }

            }
        }
    }
}
