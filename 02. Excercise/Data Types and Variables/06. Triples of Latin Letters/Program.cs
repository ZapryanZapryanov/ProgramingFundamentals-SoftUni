using System;

namespace _06._Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {

                for (int a = 0; a < n; a++)
                {

                    for (int b = 0; b < n; b++)
                    {


                        char first = (char)('a' + i);
                        char first1 = (char)('a' + a);
                        char first2 = (char)('a' + b);


                        Console.WriteLine($"{first}{first1}{first2}");

                    }
                }

            }
        }
    }
}
