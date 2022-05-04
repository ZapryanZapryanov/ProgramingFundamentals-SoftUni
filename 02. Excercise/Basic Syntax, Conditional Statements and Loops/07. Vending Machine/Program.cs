using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string money = Console.ReadLine();
            double sum = 0;

            while (money != "Start")
            {
                double price = double.Parse(money);
                switch (price)
                {
                    case 0.1:
                        sum += 0.10;
                        break;
                    case 0.2:
                        sum += 0.20;
                        break;
                    case 0.5:
                        sum += 0.50;
                        break;
                    case 1:
                        sum += 1;
                        break;
                    case 2:
                        sum += 2;
                        break;
                    default:
                        Console.WriteLine($"Cannot accept {price}");
                        break;
                }

                money = Console.ReadLine();
            }
            string product = Console.ReadLine();
            while (product != "End")
            {
                switch (product)
                {
                    case "Nuts":
                        if (sum >= 2)
                        {
                            sum -= 2.0;
                            Console.WriteLine($"Purchased nuts");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }

                        break;
                    case "Water":
                        if (sum >= 0.70)
                        {
                            sum -= 0.70;
                            Console.WriteLine($"Purchased water");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }

                        break;
                    case "Crisps":
                        if (sum >= 1.50)
                        {
                            sum -= 1.50;
                            Console.WriteLine($"Purchased crisps");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }

                        break;
                    case "Soda":
                        if (sum >= 0.80)
                        {
                            sum -= 0.80;
                            Console.WriteLine($"Purchased soda");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Coke":
                        if (sum >= 1)
                        {
                            sum -= 1.0;
                            Console.WriteLine($"Purchased coke");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;

                }
                product = Console.ReadLine();
            }
            Console.WriteLine($"Change: {sum:f2}");
        }
    }
}
