using System;
using System.Collections.Generic;

namespace _21._Split_by_Word_Casing
{
    class SplitbyWordCasing
    {
        static void Main(string[] args)
        {
            List<string> lower = new List<string>();
            List<string> upper = new List<string>();
            List<string> mixed = new List<string>();

            char[] separators = { ',', ';', ':', '.',
                                '!', '(', ')', '\"', '\'',
                                '\\', '/', '[', ']', ' '};

            string[] input = Console.ReadLine()
                .Split(separators, StringSplitOptions.RemoveEmptyEntries);
            
            foreach (var word in input)
            {
                int lowerCases = 0;
                int upperCases = 0;
                
                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsUpper(word[i]))
                    {
                        upperCases++;
                    }
                    if (char.IsLower(word[i]))
                    {
                        lowerCases++;
                    }
                }

                if (lowerCases == word.Length)
                {
                    lower.Add(word);
                }
                else if (upperCases == word.Length)
                {
                    upper.Add(word);
                }
                else
                {
                    mixed.Add(word);
                }
            }

            Console.WriteLine("Lower-case: " + string.Join(", ", lower));
            Console.WriteLine("Mixed-case: " + string.Join(", ", mixed));
            Console.WriteLine("Upper-case: " + string.Join(", ", upper));
        }
    }
}
