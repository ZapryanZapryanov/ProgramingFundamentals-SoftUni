using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int firstSum = GetFirstSum(firstNum, secondNum);
            int result = GetAllSum(firstSum, thirdNum);
            Console.WriteLine(result);
        }
        static int GetFirstSum(int one, int two)
        {
            return one + two;
        }
        static int GetAllSum(int allSum, int thirdNum)
        {
            return allSum - thirdNum;
        }
    }
}
