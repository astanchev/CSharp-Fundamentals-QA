using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace _27._Array_Manipulator
{
    class ArrayManipulator
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine()
                                .Split(' ')
                                .Select(int.Parse)
                                .ToList();

            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                if (input[0] == "print")
                {
                    break;
                }

                string command = input[0];

                switch (command)
                {
                    case "add":
                        {
                            int index = int.Parse(input[1]);
                            int numberToAdd = int.Parse(input[2]);
                            if (IsIndexCorrect(index, inputList))
                            {
                                inputList.Insert(index, numberToAdd);
                            }
                            else if (index == inputList.Count)
                            {
                                inputList.Add(numberToAdd);
                            }
                        }
                        break;
                    case "addMany":
                        {
                            int index = int.Parse(input[1]);
                            int[] numbersToAdd = input.Skip(2).Select(int.Parse).ToArray();
                            if (IsIndexCorrect(index, inputList))
                            {
                                inputList.InsertRange(index, numbersToAdd);
                            }
                            else if (index == inputList.Count)
                            {
                                inputList.AddRange(numbersToAdd);
                            }
                        }
                        break;
                    case "contains":
                        {
                            int element = int.Parse(input[1]);

                            if (inputList.Contains(element))
                            {
                                Console.WriteLine(inputList.IndexOf(element));
                            }
                            else
                            {
                                Console.WriteLine(-1);
                            }
                        }
                        break;
                    case "remove":
                        {
                            int index = int.Parse(input[1]);

                            if (IsIndexCorrect(index, inputList))
                            {
                                inputList.RemoveAt(index);
                            }
                        }
                        break;
                    case "shift":
                        {
                            int numberOfShifts = int.Parse(input[1]);

                            for (int i = 0; i < numberOfShifts; i++)
                            {
                                int temp = inputList[0];
                                inputList.RemoveAt(0);
                                inputList.Add(temp);
                            }
                        }
                        break;
                    case "sumPairs":
                        {
                            List<int> temp = new List<int>();

                            for (int i = 1; i < inputList.Count; i += 2)
                            {
                                temp.Add(inputList[i] + inputList[i - 1]);

                            }

                            if (inputList.Count % 2 != 0)
                            {
                                temp.Add(inputList.Last());
                            }


                            inputList = temp;
                        }
                        break;
                    default: break;
                }
            }

            Print(inputList);
        }

        private static void Print(List<int> inputList)
        {
            Console.WriteLine("[" + string.Join(", ", inputList) + "]");
        }

        private static bool IsIndexCorrect(int index, List<int> inputList)
        {
            return index >= 0 && index < inputList.Count;
        }
    }
}
