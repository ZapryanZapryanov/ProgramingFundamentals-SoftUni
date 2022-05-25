using System;

namespace _01._Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();

            string comand = Console.ReadLine();

            while (comand != "Generate")
            {
                string[] elements = comand.Split(">>>", StringSplitOptions.RemoveEmptyEntries);

                if (elements[0] == "Contains")
                {
                    if (key.Contains(elements[1]))
                    {
                        Console.WriteLine($"{key} contains {elements[1]}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (elements[0] == "Flip")
                {
                    int startIndex = int.Parse(elements[2]);
                    int endIndex = int.Parse(elements[3]);
                    if (elements[1] == "Upper")
                    {
                        string text = key.Substring(startIndex, endIndex - startIndex);
                        key = key.Remove(startIndex, endIndex - startIndex);
                        key = key.Insert(startIndex, text.ToUpper());
                        Console.WriteLine(key);
                    }
                    else if (elements[1] == "Lower")
                    {
                        string text = key.Substring(startIndex, endIndex - startIndex);
                        key = key.Remove(startIndex, endIndex - startIndex);
                        key = key.Insert(startIndex, text.ToLower());
                        Console.WriteLine(key);
                    }
                }
                else if (elements[0] == "Slice")
                {
                    int startIndex = int.Parse(elements[1]);
                    int endIndex = int.Parse(elements[2]);
                    key = key.Remove(startIndex, endIndex - startIndex);
                    Console.WriteLine(key);
                }

                comand = Console.ReadLine();
            }

            Console.WriteLine($"Your activation key is: {key}");
        }
    }
}
