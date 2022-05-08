using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstSymbol = char.Parse(Console.ReadLine());
            char secondSymbol = char.Parse(Console.ReadLine());
            bool flag = true;
            int first = (int)firstSymbol;
            int second = (int)secondSymbol;

            if (second < first)
            {
                flag = false;
            }
            if (!flag)
            {
                for (int i = second + 1; i < first; i++)
                {
                    Console.Write($"{(char)i} ");
                }
            }
            else
            {
                for (int i = first + 1; i < second; i++)
                {
                    Console.Write($"{(char)i} ");
                }
            }
        }
    }
}
