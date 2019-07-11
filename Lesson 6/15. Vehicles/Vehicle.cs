namespace Vehicles
{
    using System;
    public class Vehicle
    {
        private double fuelQuantity;
        private double fuelConsumption;
        public Vehicle(double fuelQuantity, double fuelConsumption)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }

        public double FuelQuantity
        {
            get => this.fuelQuantity; 
            set => this.fuelQuantity = value;
        }

        public double FuelConsumption
        {
            get => this.fuelConsumption; 
            set => this.fuelConsumption = value;
        }

        public virtual double FuelConsumptionCorrection
        {
            get => 0.0;
        }

        public virtual double FuelRefuelCorrection
        {
            get => 1.0;
        }

        public void Drive(double distance)
        {
            if (IsFuelEnough(distance))
            {
                double neededFuel = distance * (this.FuelConsumption + this.FuelConsumptionCorrection);
                this.FuelQuantity -= neededFuel;
                Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} needs refueling");
            }
        }

        public virtual void Refuel(double amount)
        {
            this.FuelQuantity += this.FuelRefuelCorrection*amount;
        }

        private bool IsFuelEnough (double distance)
        {
            double neededFuel = distance * (this.FuelConsumption + this.FuelConsumptionCorrection);
            return this.FuelQuantity >= neededFuel;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}