using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace _06._Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();
            List<Box> boxes = new List<Box>();
            while (comand != "end")
            {
                string[] element = comand.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                int serialNumber = int.Parse(element[0]);
                string item = element[1];
                int itemQuantity = int.Parse(element[2]);
                double priceItem = double.Parse(element[3]);
                Box currBox = new Box();
                currBox.SerialNumber = serialNumber;
                currBox.Item = item;
                currBox.ItemQuantity = itemQuantity;
                currBox.PriceItem = priceItem;
                currBox.FinalyPrice = itemQuantity * priceItem;
                boxes.Add(currBox);


                comand = Console.ReadLine();
            }

            List<Box> sortBox = boxes.OrderByDescending(x => x.FinalyPrice).ToList();
            Console.WriteLine(string.Join(Environment.NewLine, sortBox));
        }

        class Box
        {

            public int SerialNumber { get; set; }
            public string Item { get; set; }
            public int ItemQuantity { get; set; }
            public double PriceItem { get; set; }

            public double FinalyPrice { get; set; }

            public override string ToString()
            {
                StringBuilder text = new StringBuilder();

                text.AppendLine($"{this.SerialNumber}");
                text.AppendLine($"-- {this.Item} - ${this.PriceItem:f2}: {this.ItemQuantity}");
                text.AppendLine($"-- ${this.FinalyPrice:f2}");
                return text.ToString().Trim();

            }
        }
    }
}
