using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.AnonymousThreatExamPreparation
{
    using System;

    class AnonymousThreat
    {
        private static List<string> data;
        static void Main(string[] args)
        {
            data = Console.ReadLine().Split().ToList();

            while (true)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0] == "3:1")
                {
                    break;
                }
                else if (input[0] == "merge")
                {
                    int startIndex = int.Parse(input[1]);
                    int endIndex = int.Parse(input[2]);

                    Merge(startIndex, endIndex);
                }
                else if (input[0] == "divide")
                {
                    int index = int.Parse(input[1]);
                    int partitions = int.Parse(input[2]);

                    Divide(index, partitions);
                }
            }

            Console.WriteLine(string.Join(" ", data));
        }

        private static void Divide(int index, int partitions)
        {
            if (index < 0 || index > data.Count)
            {
                return;
            }

            string elementToDivide = data[index];

            if (elementToDivide.Length % partitions == 0)
            {
                ExactlyDivision(elementToDivide, partitions, index);
            }
            else
            {
                NotExactlyDivision(elementToDivide, partitions, index);
            }
        }

        private static void NotExactlyDivision(string elementToDivide, int partitions, int index)
        {
            List<char> tempList = elementToDivide.ToCharArray().ToList();
            List<string> result = new List<string>();

            int partitionLenght = elementToDivide.Length / partitions;

            for (int i = 0; i < partitions - 1; i++)
            {
                StringBuilder sb = new StringBuilder();

                for (int j = 0; j < partitionLenght; j++)
                {
                    sb.Append(tempList[j]);
                }

                result.Add(sb.ToString());
                tempList.RemoveRange(0,partitionLenght);
            }

            string restChars = new string(tempList.ToArray());
            result.Add(restChars);
            data.InsertRange(index, result);
            data.RemoveAt(index + partitions);
        }

        private static void ExactlyDivision(string elementToDivide, int partitions, int index)
        {
            List<char> tempList = elementToDivide.ToCharArray().ToList();
            List<string> result = new List<string>();

            int partitionLenght = elementToDivide.Length / partitions;
            
            for (int i = 0; i < partitions; i++)
            {
                StringBuilder sb = new StringBuilder();

                for (int j = 0; j < partitionLenght; j++)
                {
                    sb.Append(tempList[j]);
                }

                result.Add(sb.ToString());
                tempList.RemoveRange(0,partitionLenght);
            }

            data.InsertRange(index, result);
            data.RemoveAt(index + partitions);
        }

        private static void Merge(int startIndex, int endIndex)
        {
            if (startIndex > data.Count || endIndex < 0)
            {
                return;
            }

            if (startIndex < 0)
            {
                startIndex = 0;
            }

            if (endIndex > data.Count - 1)
            {
                endIndex = data.Count - 1;
            }

            int range = endIndex - startIndex + 1;

            StringBuilder result = new StringBuilder();
            for (int i = startIndex; i <= endIndex; i++)
            {
                result.Append(data[i]);
            }

            data.Insert(startIndex, result.ToString());
            data.RemoveRange(startIndex + 1, range);
        }
    }
}
