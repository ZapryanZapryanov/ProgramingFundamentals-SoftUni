using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbProple = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int all = (int)Math.Ceiling((double)numbProple / capacity);
            Console.WriteLine(all);
        }
    }
}
