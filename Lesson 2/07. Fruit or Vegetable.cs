using System;
using System.Linq;

namespace _07._Fruit_or_Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "banana", "apple", "kiwi","cherry", "lemon", "grapes"};
            string[] vegetables = {"tomato", "cucumber", "pepper","carrot"};

            string input = Console.ReadLine();

            if (fruits.Contains(input))
            {
                Console.WriteLine("fruit");
            }
            else if (vegetables.Contains(input))
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
