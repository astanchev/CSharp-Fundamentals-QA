namespace _02.RainbowRaindrop_21January2018
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class RainbowRaindrop
    {
        class Raindrop
        {
            public Raindrop(double volume, int red, int green, int blue)
            {
                this.Volume = volume;
                this.Red = red;
                this.Green = green;
                this.Blue = blue;
            }
            public double Volume { get; set; }
            public int Red { get; set; }
            public int Green { get; set; }
            public int Blue { get; set; }
        }

        private static List<Raindrop> raindrops;
        static void Main(string[] args)
        {
            raindrops = new List<Raindrop>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                string[] raindropArgs = input.Split();

                if (raindropArgs.Length != 4)
                {
                    continue;
                }

                double volume = double.Parse(raindropArgs[0]);
                int red = int.Parse(raindropArgs[1]);
                int green = int.Parse(raindropArgs[2]);
                int blue = int.Parse(raindropArgs[3]);

                red = ColorFix(red);
                green = ColorFix(green);
                blue = ColorFix(blue);

                int countAbove200 = CheckAbove200(red, green, blue);
                int countUnder100 = CheckUnder100(red, green, blue);

                AddRainbowRaindrops(countUnder100, countAbove200, volume, red, green, blue);
            }

            PrintRainbowRaindrops();
        }

        private static void AddRainbowRaindrops(int countUnder100, int countAbove200, double volume, int red, int green,
            int blue)
        {
            if (countUnder100 == 2 && countAbove200 == 1)
            {
                Raindrop raindrop = new Raindrop(volume, red, green, blue);

                raindrops.Add(raindrop);
            }
        }

        private static int CheckUnder100(int red, int green, int blue)
        {
            int count = 0;

            count = Count100(red, count);
            count = Count100(green, count);
            count = Count100(blue, count);

            return count;
        }

        private static int Count100(int color, int count)
        {
            if (color < 100)
            {
                count++;
            }

            return count;
        }

        private static int CheckAbove200(int red, int green, int blue)
        {
            int count = 0;

            count = Count200(red, count);
            count = Count200(green, count);
            count = Count200(blue, count);

            return count;
        }

        private static int Count200(int color, int count)
        {
            if (color > 200)
            {
                count++;
            }

            return count;
        }

        private static int ColorFix(int color)
        {
            if (color < 0 || color > 255)
            {
                color = 0;
            }

            return color;
        }

        private static void PrintRainbowRaindrops()
        {
            Console.WriteLine($"Rainbow Raindrops: {raindrops.Count}");

            int count = 0;
            
            foreach (var raindrop in raindrops.OrderBy(r => r.Volume))
            {
                Console.WriteLine($"{++count}. V:{raindrop.Volume:f2} -> R:{raindrop.Red} G:{raindrop.Green} B:{raindrop.Blue}");
            }
        }
    }
}
