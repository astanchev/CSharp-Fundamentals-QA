using System;
using System.Linq;

namespace _11._Compare_Char_Arrays
{
    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            char[] array1 = Console.ReadLine()
                .Split(' ')
                .Select(char.Parse)
                .ToArray();
            char[] array2 = Console.ReadLine()
                .Split(' ')
                .Select(char.Parse)
                .ToArray();

            string word1 = new string(array1);
            string word2 = new string(array2);
            if (word1.CompareTo(word2) > 0)
            {
                Console.WriteLine(word2);
                Console.WriteLine(word1);
            }
            else if (word1.CompareTo(word2) < 0)
            {
                Console.WriteLine(word1);
                Console.WriteLine(word2);
            }
            else
            {
                Console.WriteLine(word1);
                Console.WriteLine(word2);
            }
        }
    }
}
