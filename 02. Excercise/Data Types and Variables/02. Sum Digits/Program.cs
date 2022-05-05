using System;

namespace _02._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int magicNum = int.Parse(Console.ReadLine());
            int firstNum = 0;
            int sum = 0;
            while (true)
            {
                firstNum = magicNum % 10;
                magicNum /= 10;
                sum += firstNum;
                if (magicNum == 0)
                {
                    Console.WriteLine(sum);
                    break;
                }
            }
        }
    }
}
