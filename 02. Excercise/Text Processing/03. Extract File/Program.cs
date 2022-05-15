using System;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string fail = Console.ReadLine();

            int index = fail.LastIndexOf("\\");
            fail = fail.Substring(index + 1);
            int indexLast = fail.LastIndexOf(".");

            string firstElement = fail.Substring(0, indexLast);
            string secondElement = fail.Substring(indexLast + 1);
            Console.WriteLine($"File name: {firstElement}");
            Console.WriteLine($"File extension: {secondElement}");
        }
    }
}
