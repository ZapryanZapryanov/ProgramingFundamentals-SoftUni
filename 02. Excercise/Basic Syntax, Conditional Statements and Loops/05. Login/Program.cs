using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string passrowd = string.Empty;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                passrowd += username[i];

            }
            for (int i = 0; i < 4; i++)
            {
                string aa = Console.ReadLine();
                if (passrowd == aa)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else
                {
                    if (i == 3)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect password. Try again.");
                    }
                }
            }
        }
    }
}
