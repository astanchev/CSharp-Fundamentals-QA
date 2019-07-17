namespace _02.Herlock_sCode
{
    using System;
    using System.Text.RegularExpressions;

    class HerlocksCode
    {
        static void Main(string[] args)
        {
            string[] facts = Console.ReadLine().Split();
            long resultLastOperation = 0;
            bool isLastOperation = false;

            string patternUpperCase = @"[A-Z]{3}";
            string patternDigits = @"[0-9]{3}";
            string patternStars = @"(?<!\d)\*{1,3}(?!\d)";

            long totalSum = 0;

            while (true)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0] == "END")
                {
                    break;
                }

                int index = int.Parse(command[0]);
                string modifier = command[1];

                long currentOperation = 0;

                if (index < 0 || index >= facts.Length)
                {
                    continue;
                }

                string fact = facts[index];

                if (Regex.IsMatch(fact, patternUpperCase)
                && fact.Length == 3)
                {
                    if (modifier == "Basic")
                    {
                        currentOperation = (fact[0] + fact[1]) * fact[2];
                    }
                    else if (modifier == "Weird")
                    {
                        currentOperation = Math.Abs(fact[1] - fact[2]);
                    }
                }
                else if (Regex.IsMatch(fact, patternDigits)
                                && fact.Length == 3)
                {
                    if (modifier == "Basic")
                    {
                        currentOperation = ((fact[0] - 48) + (fact[1] - 48)) * (fact[2] - 48);
                    }
                    else if (modifier == "Weird")
                    {
                        currentOperation = Math.Abs((fact[1] - 48) - (fact[2] - 48));
                    }
                }
                else if (Regex.IsMatch(fact, patternStars))
                {
                    if (!isLastOperation)
                    {
                        continue;
                    }

                    int countStars = fact.Length;

                    currentOperation += resultLastOperation * countStars;
                }

                totalSum += currentOperation;
                resultLastOperation = currentOperation;
                isLastOperation = true;
            }

            Console.WriteLine(totalSum);
        }
    }
}
