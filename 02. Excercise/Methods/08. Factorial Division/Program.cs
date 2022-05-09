using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            double firstFac = GetFirstSumFactorial(first);
            double secondFac = GetFirstSumFactorial(second);
            double result = firstFac / secondFac;
            Console.WriteLine($"{result:f2}");
        }
        static double GetFirstSumFactorial(double first)
        {

            double result = 1;
            for (int i = 1; i <= first; i++)
            {
                result *= i;

            }

            return result;
        }
        static double GetSecondSumFactorial(double second)
        {

            double result = 1;
            for (int i = 1; i <= second; i++)
            {
                result *= i;

            }

            return result;
        }
    }
}
