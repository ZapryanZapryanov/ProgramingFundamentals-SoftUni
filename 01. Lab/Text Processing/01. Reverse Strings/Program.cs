using System;
using System.Linq;

namespace _01._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();

            while (true)
            {

                if (comand == "end")
                {
                    break;
                }
                string words = string.Empty;
                for (int i = comand.Length - 1; i >= 0; i--)
                {
                    words += comand[i];
                }
                Console.WriteLine($"{comand} = {words}");
                comand = Console.ReadLine();

            }
        }
         
        
        
    }
}
