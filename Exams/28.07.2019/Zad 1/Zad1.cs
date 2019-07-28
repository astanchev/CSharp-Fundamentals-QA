namespace Zad1
{
    using System;

    class Zad1
    {
        static void Main(string[] args)
        {
            string destinationStar = Console.ReadLine();
            int distanceFromEarthInGm = int.Parse(Console.ReadLine());
            int budgetIvan = int.Parse(Console.ReadLine());
            double fuelConsumptionInLt = double.Parse(Console.ReadLine());
            double gasPriceForLt = double.Parse(Console.ReadLine());

            double litersPerGM = fuelConsumptionInLt / 100.0;
            double pricePerGM = litersPerGM * gasPriceForLt;

            double totalPriceTrip = distanceFromEarthInGm * pricePerGM;

            double leftoverMoney = 1.0 * budgetIvan - totalPriceTrip;

            if (leftoverMoney >= 0)
            {
                Console.WriteLine($"Off to {destinationStar} with ${leftoverMoney:f2} for snacks");
            }
            else
            {
                Console.WriteLine($"Maybe another time, need ${Math.Abs(leftoverMoney):f2} more");
            }

        }
    }
}
