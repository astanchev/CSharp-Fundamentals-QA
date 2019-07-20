namespace _01.WorldOfCodecraft_27May2018
{
    using System;

    class WorldOfCodecraft
    {
        static void Main(string[] args)
        {
            bool isBelow10 = false;
            bool isAbove45 = false;
            int countBelowZero = 0;
            decimal minimumTemperature = Decimal.MaxValue;

            for (int i = 0; i < 10; i++)
            {
                decimal temperature = decimal.Parse(Console.ReadLine());

                if (temperature < minimumTemperature)
                {
                    minimumTemperature = temperature;
                }

                if (temperature < 0)
                {
                    countBelowZero++;
                }

                if (temperature < -10.0m)
                {
                    isBelow10 = true;
                }
                else if (temperature > 45)
                {
                    isAbove45 = true;
                }
            }

            if (isAbove45 || isBelow10 || countBelowZero >= 5)
            {
                Console.WriteLine($"The lowest temperature is {minimumTemperature:f1} degrees. The coders rest.");
            }
            else
            {
                Console.WriteLine($"The lowest temperature is {minimumTemperature:f1} degrees. The coders are off to battle!");
            }
        }
    }
}
