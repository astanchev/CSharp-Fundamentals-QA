using System;

namespace _15._Index_of_Letters
{
    class IndexofLetters
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            foreach (var symb in word)
            {
                Console.WriteLine($"{symb} -> {(int)symb - 97}");
            }
        }
    }
}
