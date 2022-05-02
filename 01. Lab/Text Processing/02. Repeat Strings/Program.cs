using System;
using System.Text;

namespace _02._Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            StringBuilder text = new StringBuilder();


            foreach (var item in arr)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    text.Append(item);

                }
            }
            Console.WriteLine(text);
        }
    }
}
