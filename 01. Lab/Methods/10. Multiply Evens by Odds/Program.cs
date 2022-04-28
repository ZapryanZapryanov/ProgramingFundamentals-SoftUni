using System;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int oneNum = Math.Abs(int.Parse(Console.ReadLine()));
            int evenSum = GetSumOfEvenDigits(oneNum);
            int oddSum = GetSumOfOddDigits(oneNum);
            int result = evenSum * oddSum;
            Console.WriteLine(result);

        }
        static int GetSumOfEvenDigits(int oneNum)
        {
            int even = 0;
            while (oneNum != 0)
            {
                int sum = oneNum % 10;
                if (sum % 2 == 0)
                {
                    even += sum;

                }
                oneNum /= 10;
            }
            return even;
        }
        static int GetSumOfOddDigits(int oneNum)
        {
            int odd = 0;
            while (oneNum != 0)
            {
                int sum = oneNum % 10;
                if (sum % 2 != 0)
                {
                    odd += sum;

                }
                oneNum /= 10;
            }
            return odd;
        }
    }
}
