using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries).ToList();
            Article currElement = new Article();
            currElement.Title = elements[0];
            currElement.Content = elements[1];
            currElement.Author = elements[2];

            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string[] comand = Console.ReadLine().Split(":", StringSplitOptions.RemoveEmptyEntries);
                if (comand[0] == "Edit")
                {
                    currElement.Edit(comand[1]);


                }
                else if (comand[0] == "ChangeAuthor")
                {
                    currElement.ChangeAuthor(comand[1]);
                }
                else if (comand[0] == "Rename")
                {
                    currElement.Rename(comand[1]);
                }
            }
            Console.WriteLine(currElement);
        }
    }
    public class Article
    {

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public void Edit(string newContent)
        {
            this.Content = newContent;
        }
        public void ChangeAuthor(string otherAuthor)
        {
            this.Author = otherAuthor;
        }
        public void Rename(string newTitle)
        {
            this.Title = newTitle;
        }
        public override string ToString()
        {
            return $"{this.Title} -{this.Content}:{this.Author}";
        }

    }
}
