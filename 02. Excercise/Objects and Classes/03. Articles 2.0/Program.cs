using System;
using System.Collections.Generic;

namespace _03._Articles_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Article> newList = new List<Article>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string[] comand = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                Article currElement = new Article();
                currElement.Title = comand[0];
                currElement.Content = comand[1];
                currElement.Author = comand[2];
                newList.Add(currElement);

            }
            string element = Console.ReadLine();
            switch (element)
            {
                case "title":
                    newList = newList.OrderBy(x => x.Title).ToList();
                    break;
                case "content":
                    newList = newList.OrderBy(x => x.Content).ToList();
                    break;
                case "author":
                    newList = newList.OrderBy(x => x.Author).ToList();
                    break;
            }
            Console.WriteLine(string.Join(Environment.NewLine, newList));

        }
    }
    public class Article
    {

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
