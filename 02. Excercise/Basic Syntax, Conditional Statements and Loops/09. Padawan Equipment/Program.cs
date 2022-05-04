using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double amountOfMoney = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double priceLightsabel = double.Parse(Console.ReadLine());
            double priceRobe = double.Parse(Console.ReadLine());
            double priceBelt = double.Parse(Console.ReadLine());
            int alls = 0;
            double people = students;
            for (int i = 1; i <= students; i++)
            {
                alls++;
                if (alls == 6)
                {
                    alls = 0;
                    people -= 1;

                }
            }
            double all = (priceLightsabel * Math.Ceiling(students * 0.10 + students)) + (priceRobe * students) + (priceBelt * people);
            if (all <= amountOfMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {all:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {all - amountOfMoney:f2}lv more.");
            }
        }
    }
}
