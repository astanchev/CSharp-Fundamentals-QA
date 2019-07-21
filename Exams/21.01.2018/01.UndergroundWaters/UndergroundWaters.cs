namespace _01.UndergroundWaters_21January2018
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class UndergroundWaters
    {
        private static List<int> airValues;
        private static List<int> rainValues;
        private static List<int> airLocalMaxValues;

        static int biggestValueAir;
        static int biggestValueRain;
        static void Main(string[] args)
        {
            airValues = new List<int>();
            rainValues = new List<int>();
            airLocalMaxValues = new List<int>();

            string inputAir = Console.ReadLine();
            string inputRain = Console.ReadLine();


            if (inputAir != string.Empty)
            {
                airValues = inputAir.Split().Select(int.Parse).ToList();
            }

            if (inputRain != String.Empty)
            {
                rainValues = inputRain.Split().Select(int.Parse).ToList();
            }

            FindAirLocalMaxValues();

            SubstractMaxCount();

            FindBiggestAirValue();

            FindBiggestRainValue();


            if (biggestValueRain == biggestValueAir)
            {
                Console.WriteLine("Something interesting was found!");
                Console.WriteLine($"Sum: {biggestValueRain + biggestValueAir}");
            }
            else
            {
                Console.WriteLine("There is nothing unordinary!");
                Console.WriteLine($"Difference: {Math.Abs(biggestValueAir - biggestValueRain)}");
            }
        }

        private static void FindBiggestRainValue()
        {
            if (rainValues.Count == 1)
            {
                biggestValueRain = rainValues[0];
            }
            else
            {
                int temp = int.MinValue;

                for (int i = 0; i < rainValues.Count; i++)
                {
                    for (int j = 0; j < rainValues.Count; j++)
                    {
                        if (i == j)
                        {
                            continue;
                        }
                        else if (rainValues[i] > rainValues[j])
                        {
                            temp = rainValues[i];
                        }

                        if (temp > biggestValueRain)
                        {
                            biggestValueRain = temp;
                        }
                    }
                }
            }
        }

        private static void FindBiggestAirValue()
        {
            if (airLocalMaxValues.Count > 0)
            {
                biggestValueAir = airLocalMaxValues.Max();
            }
        }

        private static void SubstractMaxCount()
        {
            for (int i = 0; i < rainValues.Count; i++)
            {
                rainValues[i] -= airLocalMaxValues.Count;
                if (rainValues[i] <= 0)
                {
                    rainValues.Remove(rainValues[i]);
                    i--;
                }
            }
        }

        private static void FindAirLocalMaxValues()
        {
            if (airValues.Count == 1)
            {
                airLocalMaxValues.Add(airValues[0]);
            }
            else
            {
                for (int i = 0; i < airValues.Count; i++)
                {
                    if (i == 0
                        && airValues[i] > 0
                        && airValues[i] > airValues[i + 1])
                    {
                        airLocalMaxValues.Add(airValues[i]);
                    }
                    else if (i == airValues.Count - 1
                             && airValues[i] > 0
                             && airValues[i] > airValues[i - 1])
                    {
                        airLocalMaxValues.Add(airValues[airValues.Count - 1]);
                    }
                    else if (i > 0
                             && airValues[i] > airValues[i - 1]
                             && airValues[i] > airValues[i + 1])
                    {
                        airLocalMaxValues.Add(airValues[i]);
                    }
                }
            }
        }
    }
}
