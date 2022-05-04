using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int all = 0;
            bool flag = false;
            double ah = num;
            while (!flag)
            {
                sum = num % 10;
                num /= 10;
                int a = 1;
                for (int i = 1; i <= sum; i++)
                {
                    a *= i;
                }
                all += a;
                if (all == ah)
                {
                    Console.WriteLine("yes");
                    return;
                }
                if (num == 0)
                {
                    flag = true;
                }

            }
            Console.WriteLine("no");
        }
    }
}
