﻿using System;

namespace _01._Day_of_Week
{
    class DayofWeek
    {
        static void Main(string[] args)
        {
            string[] days = {"Monday", "Tuesday", "Wednesday",
                "Thursday", "Friday", "Saturday", "Sunday"};

            int day = int.Parse(Console.ReadLine());

            if (day > 0 && day < 8)
            {
                Console.WriteLine(days[day - 1]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}
