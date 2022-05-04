using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string group = Console.ReadLine();
            string weekDay = Console.ReadLine();
            double allPrice = people;
            if (group == "Students")
            {
                switch (weekDay)
                {
                    case "Friday":
                        allPrice *= 8.45;
                        break;
                    case "Saturday":
                        allPrice *= 9.80;
                        break;
                    case "Sunday":
                        allPrice *= 10.46;
                        break;
                }
                if (people >= 30)
                {
                    allPrice *= 0.85;
                }
            }
            else if (group == "Business")
            {
                if (people >= 100)
                {
                    allPrice -= 10;
                }
                switch (weekDay)
                {
                    case "Friday":
                        allPrice *= 10.90;
                        break;
                    case "Saturday":
                        allPrice *= 15.60;
                        break;
                    case "Sunday":
                        allPrice *= 16;
                        break;
                }

            }
            if (group == "Regular")
            {
                switch (weekDay)
                {
                    case "Friday":
                        allPrice *= 15;
                        break;
                    case "Saturday":
                        allPrice *= 20;
                        break;
                    case "Sunday":
                        allPrice *= 22.50;
                        break;
                }
                if (10 <= people && 20 >= people)
                {
                    allPrice *= 0.95;
                }
            }
            Console.WriteLine($"Total price: {allPrice:f2}");
        }
    }
}
