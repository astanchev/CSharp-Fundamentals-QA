using System;

namespace _12._Time_plus_15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int allMinutes = hours * 60 + minutes + 15;

            int currentHours = allMinutes / 60;
            int currentMinutes = allMinutes % 60;

            if (currentHours > 23)
            {
                currentHours -= 24;
            }

            Console.WriteLine($"{currentHours}:{currentMinutes:00}");
        }
    }
}
