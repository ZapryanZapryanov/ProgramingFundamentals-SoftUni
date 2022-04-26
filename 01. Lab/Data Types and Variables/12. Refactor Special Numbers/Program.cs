using System;

namespace _12._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());

            int specialNum = 0;
            bool flag = false;
            for (int i = 1; i <= num; i++)
            {
                specialNum = i;
                int all = 0;
                while (i > 0)
                {
                    all += i % 10;
                    i /= 10;
                }
                flag = (all == 5) || (all == 7) || (all == 11);
                Console.WriteLine($"{specialNum} -> {flag}");
                all = 0;
                i = specialNum;
            }
    }
}
