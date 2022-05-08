using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMinNumber(first, second, third));

        }
        static int GetMinNumber(int firstSum, int secondSum, int thirdSum)
        {
            int minNum = 0;
            if (firstSum <= secondSum && firstSum <= thirdSum)
            {
                minNum = firstSum;
            }
            else if (secondSum <= firstSum && secondSum <= thirdSum)
            {
                minNum = secondSum;
            }
            else if (thirdSum <= firstSum && thirdSum <= secondSum)
            {
                minNum = thirdSum;
            }
            return minNum;
        }
    }
}
