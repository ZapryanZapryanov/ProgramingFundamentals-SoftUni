using System;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ");
            int sum = 0;
            int counter = 0;
            if (words[0].Length > words[1].Length)
            {
                for (int i = 0; i < words[1].Length; i++)
                {
                    sum += (int)words[0][i] * (int)words[1][i];
                    counter++;

                }
                for (int i = counter; i < words[0].Length; i++)
                {
                    sum += (int)words[0][i];
                }
                Console.WriteLine(sum);
            }
            else
            {
                for (int i = 0; i < words[0].Length; i++)
                {
                    sum += (int)words[0][i] * (int)words[1][i];
                    counter++;

                }
                for (int i = counter; i < words[1].Length; i++)
                {
                    sum += (int)words[1][i];
                }
                Console.WriteLine(sum);
            }
        }
    }
}
