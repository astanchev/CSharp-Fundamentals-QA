namespace _04.Car_27January2019
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    class Startup
    {
        private static List<Car> cars;
        static void Main(string[] args)
        {
            cars = new List<Car>();

            AddCars();

            DriveCars();

            PrintCars();
        }

        private static void PrintCars()
        {
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TraveledDistance}");
            }
        }

        private static void DriveCars()
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                string[] inputLine = input.Split();

                string model = inputLine[1];
                double amountOfKm = double.Parse(inputLine[2]);

                if (cars.Any(c => c.Model == model))
                {
                    bool isDrived = cars.First(c => c.Model == model).Drive(amountOfKm);

                    if (!isDrived)
                    {
                        Console.WriteLine("Insufficient fuel for the drive");
                    }
                }
            }
        }

        private static void AddCars()
        {
            int numberCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberCars; i++)
            {
                string[] input = Console.ReadLine().Split();

                string model = input[0];
                double fuelAmount = double.Parse(input[1]);
                double FuelConsumptionFor1km = double.Parse(input[2]);

                Car car = new Car(model, fuelAmount, FuelConsumptionFor1km);

                if (cars.All(c => c.Model != model))
                {
                    cars.Add(car);
                }
            }
        }
    }
}
