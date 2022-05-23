using System;
using System.Collections.Generic;

namespace _03._Speed_Racing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Cars> listCars = new List<Cars>();

            for (int i = 0; i < n; i++)
            {
                string[] elements = Console.ReadLine().Split();
                string model = elements[0];
                double fuel = double.Parse(elements[1]);
                double consumption = double.Parse(elements[2]);

                Cars oneCar = new Cars(model, fuel, consumption);
                listCars.Add(oneCar);
            }

            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] comand = input.Split();

                string carModel = comand[1];
                int amountKm = int.Parse(comand[2]);
                int index = listCars.FindIndex(x => x.Model == carModel);
                listCars[index].Flag(carModel, amountKm);

                input = Console.ReadLine();
            }

            foreach (var item in listCars)
            {
                Console.WriteLine($"{item.Model} {item.FuelAmount:f2} {item.TravelDistance}");
            }
        }
    }
    class Cars
    {
        public Cars(string model, double fuelAmount, double fuelConsumptionFor1km)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionFor1km = fuelConsumptionFor1km;
            this.TravelDistance = 0;
        }
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionFor1km { get; set; }
        public double TravelDistance { get; set; }

        public void Flag(string carModel, int amount)
        {
            double neededLitters = amount * this.FuelConsumptionFor1km;

            if (this.FuelAmount >= neededLitters)
            {
                this.FuelAmount -= neededLitters;
                this.TravelDistance += amount;

            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
