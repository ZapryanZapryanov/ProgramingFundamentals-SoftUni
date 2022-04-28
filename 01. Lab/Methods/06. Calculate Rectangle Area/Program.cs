using System;

namespace _06._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            Console.WriteLine(getCalculate(first, second));
        }
        static double getCalculate(double width, double hight)
        {
            return width * hight;
        }
    
    }
}
