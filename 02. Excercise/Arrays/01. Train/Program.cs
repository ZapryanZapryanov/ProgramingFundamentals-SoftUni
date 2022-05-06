using System;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrPeople = new int[n];
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                arrPeople[i] = int.Parse(Console.ReadLine());
                sum += arrPeople[i];


            }
            Console.WriteLine(string.Join(" ", arrPeople));
            Console.WriteLine(sum);
        }
    }
}
