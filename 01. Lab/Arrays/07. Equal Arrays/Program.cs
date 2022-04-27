using System;

namespace _07._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arraysOne = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arraysSecond = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            for (int i = 0; i < arraysOne.Length; i++)
            {
                sum += arraysOne[i];
                if (arraysOne[i] != arraysSecond[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }
            }
            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }
}
