using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Population_Counter
{
    class PopulationCounter
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> countryCityPopulation = 
                new Dictionary<string, Dictionary<string, long>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "report")
                {
                    break;
                }

                string city = input.Split('|')[0];
                string country = input.Split('|')[1];
                int population = int.Parse(input.Split('|')[2]);

                if (!countryCityPopulation.ContainsKey(country))
                {
                    countryCityPopulation[country] = new Dictionary<string, long>();
                }

                if (countryCityPopulation[country].ContainsKey(city))
                {
                    countryCityPopulation[country][city] = 0;
                }

                countryCityPopulation[country][city] = population;
            }

            foreach (var country in countryCityPopulation
                                            .OrderByDescending(c => c.Value.Values.Sum()))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Values.Sum()})");
                foreach (var city in country.Value.OrderByDescending(c => c.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }

        }
    }
}
