using System;

namespace _03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            switch (comand)
            {
                case "add":
                    printAdd(first, second);
                    break;
                case "multiply":
                    printMultiply(first, second);
                    break;
                case "subtract":
                    printSubtract(first, second);
                    break;
                case "divide":
                    printDivide(first, second);

                    break;
            }

        }
        static void printAdd(int first, int second)
        {
            Console.WriteLine(first + second);
        }
        static void printMultiply(int first, int second)
        {
            Console.WriteLine(first * second);

        }
        static void printSubtract(int first, int second)
        {
            Console.WriteLine(first - second);

        }
        static void printDivide(int first, int second)
        {
            Console.WriteLine(first / second);

        }
    
    }
}
