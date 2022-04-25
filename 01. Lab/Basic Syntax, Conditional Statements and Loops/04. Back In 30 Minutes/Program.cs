using System;

namespace _04._Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int mins = minutes + 30;
            if (mins > 59)
            {
                hours += 1;
                mins -= 60;
            }
            if (hours > 23)
            {
                hours = 0;

            }
            Console.WriteLine($"{hours}:{mins:d2}");
        }
    }
}
