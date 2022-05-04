using System;

namespace _01._Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            int ages = int.Parse(Console.ReadLine());
            if (0 <= ages && ages <= 2)
            {
                Console.WriteLine("baby");
            }
            else if (ages <= 13 && ages >= 3)
            {
                Console.WriteLine("child");
            }
            else if (ages <= 19 && ages >= 14)
            {
                Console.WriteLine("teenager");
            }
            else if (ages <= 65 && ages >= 20)
            {
                Console.WriteLine("adult");
            }
            else
            {
                Console.WriteLine("elder");
            }
        }
    }
}
