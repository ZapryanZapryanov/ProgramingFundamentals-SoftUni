using System;

namespace _02._Pounds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());

            decimal translete = (decimal)(money * 1.31);
            Console.WriteLine($"{translete:f3}");
        }
    }
}
