using System;

namespace _04._Centuries_to_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            const int Minutes = 60;
            const int Hours = 24;
            const decimal Days = 365.2422m;
            short sum = short.Parse(Console.ReadLine());
            short centuries = (short)(sum * 100);
            int years = (int)(centuries * Days);
            long days = (long)(years * Hours);
            BigInteger hours = (BigInteger)(days * Minutes);

            Console.Write($"{sum} centuries = {centuries} years = {years} days = {days} hours = {hours} minutes");

        }
    }
}
