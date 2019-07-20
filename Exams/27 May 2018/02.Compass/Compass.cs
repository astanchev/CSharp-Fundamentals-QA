namespace _02.Compass_27May2018
{
    using System;
    using System.Collections.Generic;

    class Compass
    {
        static void Main(string[] args)
        {
            List<char> directions = new List<char>() {'N', 'E', 'S', 'W' };

            Dictionary<char, string> directionsNames = new Dictionary<char, string>()
            {
                {'N', "North" },
                {'E', "East" },
                {'S', "South" },
                {'W', "West" }
            };


            char startingDirection = char.Parse(Console.ReadLine());

            int startingIndex = directions.IndexOf(startingDirection);

            int sumOfRotations = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }

                int rotation = int.Parse(input);

                sumOfRotations += rotation;
            }

            int rotationDegree = sumOfRotations % 180;

            int indexPositionsToMove = rotationDegree / 45;

            int endIndex = startingIndex + indexPositionsToMove;

            if (endIndex < 0)
            {
                endIndex = directions.Count + endIndex;
            }
            else if (endIndex > directions.Count - 1)
            {
                endIndex = endIndex % directions.Count;
            }

            char endingDirection = directions[endIndex];

            Console.WriteLine($"Starting Position: {directionsNames[startingDirection]}");
            Console.WriteLine($"Position After Rotating: {directionsNames[endingDirection]}");
        }
    }
}
