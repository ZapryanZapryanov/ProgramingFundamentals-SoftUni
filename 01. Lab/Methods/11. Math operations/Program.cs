using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            Console.WriteLine(CalculateOne(firstNum, symbol, secondNum));
        }
        static double CalculateOne(int first, char sym, int second)
        {
            switch (sym)
            {
                case '*':
                    first *= second;
                    break;
                case '/':
                    first /= second;
                    break;
                case '+':
                    first += second;
                    break;
                case '-':
                    first -= second;
                    break;
            }
            return first;
        }
    }
}
