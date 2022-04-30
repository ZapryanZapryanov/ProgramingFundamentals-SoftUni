using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();
            Catalog catalogForAll = new Catalog();


            while (comand != "end")
            {
                //"{type}/{brand}/{model}/{horse power / weight}"
                string[] element = comand.Split("/", StringSplitOptions.RemoveEmptyEntries);
                string type = element[0];
                string brand = element[1];
                string model = element[2];
                double weightOrPower = double.Parse(element[3]);
                if (type == "Car")
                {
                    Car oneCar = new Car(brand, model, weightOrPower);
                    catalogForAll.CarCollection.Add(oneCar);
                }
                if (type == "Truck")
                {
                    Truck oneTruck = new Truck(brand, model, weightOrPower);
                    catalogForAll.TruckCollection.Add(oneTruck);
                }

                comand = Console.ReadLine();
            }

            List<Car> orderCar = catalogForAll.CarCollection.OrderBy(s => s.Brand).ToList();
            List<Truck> orderTruck = catalogForAll.TruckCollection.OrderBy(s => s.Brand).ToList();
            if (orderCar.Count != 0)
            {
                Console.WriteLine("Cars:");
                foreach (Car item in orderCar)
                {
                    Console.WriteLine($"{item.Brand}: {item.Model} - {item.HorsePower}hp");
                }
            }
            if (orderTruck.Count != 0)
            {
                Console.WriteLine("Trucks:");
                foreach (Truck item in orderTruck)
                {
                    Console.WriteLine($"{item.Brand}: {item.Model} - {item.Weight}kg");
                }
            }


        }
    }
    class Truck
    {
        public Truck(string currBrand, string currModel, double currWeight)
        {
            this.Brand = currBrand;
            this.Model = currModel;
            this.Weight = currWeight;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Weight { get; set; }
    }

    class Car
    {
        public Car(string currBrand, string currModel, double currHorsePower)
        {
            this.Brand = currBrand;
            this.Model = currModel;
            this.HorsePower = currHorsePower;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public double HorsePower { get; set; }
    }

    class Catalog
    {
        public Catalog()
        {
            this.CarCollection = new List<Car>();
            this.TruckCollection = new List<Truck>();
        }
        public List<Truck> TruckCollection { get; set; }
        public List<Car> CarCollection { get; set; }

    }
}
