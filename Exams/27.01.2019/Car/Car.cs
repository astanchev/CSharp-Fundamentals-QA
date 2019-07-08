namespace _04.Car_27January2019
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionPerKm;
        private double traveledDistance;

        public Car(string model, double fuelAmount, double fuelConsumptionPerKm)
        {
            this.model = model;
            this.fuelAmount = fuelAmount;
            this.fuelConsumptionPerKm = fuelConsumptionPerKm;
            this.traveledDistance = 0;
        }

        public string Model
        {
            get => this.model;
            set => this.model = value;
        }
        public double FuelAmount
        {
            get => this.fuelAmount;
            set => this.fuelAmount = value;
        }

        public double FuelConsumptionPerKm
        {
            get => this.fuelConsumptionPerKm;
            set => this.fuelConsumptionPerKm = value;
        }

        public double TraveledDistance
        {
            get => this.traveledDistance;
            set => this.traveledDistance = value;
        }

        public bool Drive(double amountOfKm)
        {
            double fuelNeedeForTravel = this.FuelConsumptionPerKm * amountOfKm;

            if (this.FuelAmount >= fuelNeedeForTravel)
            {
                this.FuelAmount -= fuelNeedeForTravel;
                traveledDistance += amountOfKm;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}