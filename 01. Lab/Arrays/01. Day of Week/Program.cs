using System;

namespace _01._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string[] daysWeekArrays = new string[7]
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };
            if (num > 0 && num <= daysWeekArrays.Length)
            {
                Console.WriteLine(daysWeekArrays[num - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
