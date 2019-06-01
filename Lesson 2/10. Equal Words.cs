using System;

namespace _10._Equal_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1 = Console.ReadLine()?.ToLower();
            string word2 = Console.ReadLine()?.ToLower();

            if (word1.Equals(word2))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
