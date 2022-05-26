using System;
using System.Collections.Generic;

namespace _05._HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string titlePage = Console.ReadLine();
            string contentPage = Console.ReadLine();
            string input = Console.ReadLine();
            List<string> comment = new List<string>();

            while (input != "end of comments")
            {
                comment.Add(input);
                input = Console.ReadLine();

            }
            Console.WriteLine("<h1>");
            Console.WriteLine($"    {titlePage}");
            Console.WriteLine("</h1>");
            Console.WriteLine("<article>");
            Console.WriteLine($"    {contentPage}");
            Console.WriteLine("</article>");
            for (int i = 0; i < comment.Count; i++)
            {
                Console.WriteLine("<div>");
                Console.WriteLine($"    {comment[i]}");
                Console.WriteLine("</div>");
            }
        }
    }
}
