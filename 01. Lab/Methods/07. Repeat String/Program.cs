using System;
using System.Text;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();
            int rotation = int.Parse(Console.ReadLine());
            string finalyy = PrintStrings(comand, rotation);
            Console.WriteLine(finalyy);
        }
        static string PrintStrings(string comand, int rotation)
        {
            StringBuilder stringRotation = new StringBuilder();
            for (int i = 0; i < rotation; i++)
            {
                stringRotation.Append(comand);
            }
            return stringRotation.ToString();
        }
    }
}
