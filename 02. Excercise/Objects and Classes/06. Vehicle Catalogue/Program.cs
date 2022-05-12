using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();

            List<Vehicle> vehicleList = new List<Vehicle>();

            while (comand != "End")
            {
                string[] elements = comand.Split().ToArray();

                string typeOfVehicle = elements[0];
                string modelOfVehicle = elements[1];
                string colorOfVehicle = elements[2];
                double horsepowerOfVehicle = double.Parse(elements[3]);

                Vehicle currVehicle = new Vehicle(typeOfVehicle, modelOfVehicle, colorOfVehicle, horsepowerOfVehicle);
                vehicleList.Add(currVehicle);

                comand = Console.ReadLine();
            }
            string input = Console.ReadLine();

            while (input != "Close the Catalogue")
            {
                Console.WriteLine(vehicleList.FirstOrDefault(x => x.Model == input).ToString());


                input = Console.ReadLine();
            }

            List<Vehicle> car = vehicleList.FindAll(x => x.Type == "car");
            List<Vehicle> truck = vehicleList.FindAll(x => x.Type == "truck");
            double sumCar = car.Sum(x => x.Horsepower);
            double finalySumCar = sumCar / car.Count;

            if (car.Count == 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {finalySumCar:f2}.");
            }

            double sumTruck = truck.Sum(x => x.Horsepower);
            double finalySumTruck = sumTruck / truck.Count;

            if (truck.Count == 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {finalySumTruck:f2}.");
            }
        }
        class Vehicle
        {
            public Vehicle(string typeOfVehicle, string modelOfVehicle, string colorOfVehicle, double horsepowerOfVehicle)
            {
                this.Type = typeOfVehicle;
                this.Model = modelOfVehicle;
                this.Color = colorOfVehicle;
                this.Horsepower = horsepowerOfVehicle;
            }
            public string Type { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public double Horsepower { get; set; }

            public override string ToString()
            {
                StringBuilder text = new StringBuilder();
                if (this.Type == "car")
                {
                    text.AppendLine($"Type: Car");
                }
                if (this.Type == "truck")
                {
                    text.AppendLine($"Type: Truck");
                }

                text.AppendLine($"Model: {this.Model}");
                text.AppendLine($"Color: {this.Color}");
                text.AppendLine($"Horsepower: {this.Horsepower}");
                return text.ToString().Trim();
            }
        }
    }
}
