using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Songs
{
    class Song
    {
        public string Type { get; set; }

        public string Name { get; set; }

        public string Time { get; set; }


    }
    class Program
    {
        static void Main(string[] args)
        {
            int numbersSongs = int.Parse(Console.ReadLine());
            List<Song> listSongs = new List<Song>();

            for (int i = 1; i <= numbersSongs; i++)
            {
                List<string> data = Console.ReadLine().Split("_").ToList();
                string type = data[0];
                string name = data[1];
                string time = data[2];
                Song song = new Song();
                song.Type = type;
                song.Name = name;
                song.Time = time;
                listSongs.Add(song);
            }
            string comanad = Console.ReadLine();

            if (comanad == "all")
            {
                foreach (Song item in listSongs)
                {
                    Console.WriteLine(item.Name);
                }
            }
            else
            {
                List<Song> newList = listSongs.FindAll(index => index.Type == comanad);
                foreach (Song item in newList)
                {
                    Console.WriteLine(item.Name);
                }
            }
        }
    }
}
