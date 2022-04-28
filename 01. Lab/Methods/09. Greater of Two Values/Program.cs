using System;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string function = Console.ReadLine();
            switch (function)
            {
                case "int":
                    int firstNum = int.Parse(Console.ReadLine());
                    int secondNum = int.Parse(Console.ReadLine());
                    Console.WriteLine(GetMaxNum(firstNum, secondNum));
                    break;
                case "char":
                    char oneSymbol = char.Parse(Console.ReadLine());
                    char twoSymbol = char.Parse(Console.ReadLine());
                    Console.WriteLine(GetMaxChar(oneSymbol, twoSymbol));
                    break;
                case "string":
                    string firstName = Console.ReadLine();
                    string secondName = Console.ReadLine();
                    Console.WriteLine(GetMaxString(firstName, secondName));
                    break;


            }
        }
        static int GetMaxNum(int first, int second)
        {
            int result = 0;
            if (first > second)
            {
                result = first;
            }
            else
            {
                result = second;
            }
            return result;
        }
        static char GetMaxChar(char first, char second)
        {
            char result = '\0';
            if (first > second)
            {
                result = first;
            }
            else
            {
                result = second;
            }
            return result;
        }
        static string GetMaxString(string first, string second)
        {
            return first.CompareTo(second) >= 0 ? first : second;
        }
    }
}
