using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();

            MatchCollection words = Regex.Matches(text, @"\+359( |-)2\1\d{3}\1\d{4}\b");

            string[] arr = words.Select(x => x.Value.Trim()).ToArray();
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
