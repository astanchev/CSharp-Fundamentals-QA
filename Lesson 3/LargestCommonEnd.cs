using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Largest_Common_End
{
    class LargestCommonEnd
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split();
            string[] arr2 = Console.ReadLine().Split();

            int maxLength = Math.Max(arr1.Length, arr2.Length);
            int minLength = Math.Min(arr1.Length, arr2.Length);

            int difference = maxLength - minLength; 
            int startCount = 0;
            int endCount = 0;

            for (int i = 0; i < minLength; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    startCount++;
                }
                else 
                {
                    break;
                }
            }

            Array.Reverse(arr1);
            Array.Reverse(arr2);
            
            for (int i = 0; i < minLength; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    endCount++;
                }
                else 
                {
                    break;
                }
            }

            Console.WriteLine(Math.Max(startCount, endCount));
        }
    }
}
