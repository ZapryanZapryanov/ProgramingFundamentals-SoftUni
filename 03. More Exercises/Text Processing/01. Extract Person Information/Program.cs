using System;

namespace _01._Extract_Person_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            int nLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < nLines; i++)
            {
                string comand = Console.ReadLine();
                int firstIndexName = comand.IndexOf("@");
                int lastIndexName = comand.LastIndexOf("|");
                string name = comand.Substring(firstIndexName + 1, lastIndexName - 1 - firstIndexName);
                int firstIndexAge = comand.IndexOf("#");
                int lastIndexAge = comand.LastIndexOf("*");
                string age = comand.Substring(firstIndexAge + 1, lastIndexAge - 1 - firstIndexAge);
                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
