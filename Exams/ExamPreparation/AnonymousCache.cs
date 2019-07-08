using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.AnonymousCacheExamPreparation
{
    class AnonymousCache
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> setKeySize = new Dictionary<string, Dictionary<string, long>>();

            Dictionary<string, Dictionary<string, long>> cache = new Dictionary<string, Dictionary<string, long>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "thetinggoesskrra")
                {
                    break;
                }

                if (input.Contains('|'))
                {
                    string[] inputData = input
                        .Split(new[] {" -> ", " | "}, StringSplitOptions.RemoveEmptyEntries);

                    string dataKey = inputData[0];
                    long dataSize = long.Parse(inputData[1]);
                    string dataSet = inputData[2];

                    if (setKeySize.ContainsKey(dataSet))
                    {
                        setKeySize[dataSet].Add(dataKey, dataSize);
                    }
                    else
                    {
                        if (!cache.ContainsKey(dataSet))
                        {
                            cache[dataSet] = new Dictionary<string, long>();
                        }

                        cache[dataSet].Add(dataKey, dataSize);
                    }
                }
                else
                {
                    string dataSet = input;

                    if (!setKeySize.ContainsKey(dataSet))
                    {
                        setKeySize[dataSet] = new Dictionary<string, long>();
                    }

                    if (cache.ContainsKey(dataSet))
                    {
                        foreach (var key in cache[dataSet])
                        {
                            setKeySize[dataSet].Add(key.Key, key.Value);
                        }
                    }
                }
            }

            if (setKeySize.Count > 0)
            {
                var bestSet = setKeySize.OrderByDescending(s => s.Value.Values.Sum()).First();

                Console.WriteLine($"Data Set: {bestSet.Key}, Total Size: {bestSet.Value.Values.Sum()}");
                foreach (var dataKey in bestSet.Value)
                {
                    Console.WriteLine($"$.{dataKey.Key}");
                }
            }
        }
    }
}
