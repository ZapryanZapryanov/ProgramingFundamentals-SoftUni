using System;
using System.Text;

namespace _07._String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = Console.ReadLine();

            StringBuilder newText = new StringBuilder();

            int exp = 0;
            for (int i = 0; i < words.Length; i++)
            {

                if (words[i] == '>')
                {
                    exp += words[i + 1];
                    exp -= 48;
                    newText.Append('>');
                }
                else if (exp != 0)
                {

                    exp--;
                }
                else
                {
                    newText.Append(words[i]);
                }
            }
            Console.WriteLine(newText);
        }
    }
}
