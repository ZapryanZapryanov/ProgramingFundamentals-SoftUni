using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int losesGame = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            int headset = 0;
            int mouse = 0;
            int keyboard = -1;
            int oneKeyboard = 0;
            int display = 0;
            double sum = 0;
            for (int i = 1; i <= losesGame; i++)
            {
                headset++;
                mouse++;
                if (headset == 2)
                {
                    headset = 0;
                    sum += headsetPrice;
                    keyboard++;
                }
                if (mouse == 3)
                {
                    mouse = 0;
                    sum += mousePrice;
                    oneKeyboard++;
                }
                if (oneKeyboard == 2 && keyboard == 2)
                {
                    oneKeyboard = 0;
                    keyboard = -1;
                    sum += keyboardPrice;
                    display++;
                }
                if (display == 2)
                {
                    display = 0;
                    sum += displayPrice;
                }


            }
            Console.WriteLine($"Rage expenses: {sum:f2} lv.");
        }
    }
}
