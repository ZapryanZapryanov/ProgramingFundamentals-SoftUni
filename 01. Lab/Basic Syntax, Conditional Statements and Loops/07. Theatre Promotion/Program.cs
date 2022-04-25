using System;

namespace _07._Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int day = int.Parse(Console.ReadLine());
            switch (name)
            {
                case "Weekday":
                    if (0 <= day && day <= 18)
                    {
                        Console.WriteLine("12$");
                    }
                    else if (19 <= day && day <= 64)
                    {
                        Console.WriteLine("18$");
                    }
                    else if (65 <= day && day <= 122)
                    {
                        Console.WriteLine("12$");
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                    break;
                case "Weekend":
                    if (0 <= day && day <= 18)
                    {
                        Console.WriteLine("15$");
                    }
                    else if (19 <= day && day <= 64)
                    {
                        Console.WriteLine("20$");
                    }
                    else if (65 <= day && day <= 122)
                    {
                        Console.WriteLine("15$");
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                    break;
                case "Holiday":
                    if (0 <= day && day <= 18)
                    {
                        Console.WriteLine("5$");
                    }
                    else if (19 <= day && day <= 64)
                    {
                        Console.WriteLine("12$");
                    }
                    else if (65 <= day && day <= 122)
                    {
                        Console.WriteLine("10$");
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                    break;
            }
        }
    }
}
