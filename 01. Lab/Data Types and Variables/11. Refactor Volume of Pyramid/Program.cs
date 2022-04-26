using System;

namespace _11._Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0;
            double b = 0;
            double x = 0;
            double result = 0;

            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            x = double.Parse(Console.ReadLine());
            result = (a * b * x) / 3;
            Console.Write($"Length: Width: Height: Pyramid Volume: {result:f2}");
        }
    }
}
