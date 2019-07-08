namespace _01.Usernames_27January2019
{
    using System;

    class Usernames
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                bool isValid = true;

                for (int i = 0; i < input.Length; i++)
                {
                    char symb = input[i];

                    if (!char.IsLetter(symb))
                    {
                        isValid = false;
                        Console.WriteLine("Invalid username!");
                        break;
                    }
                }

                if (isValid)
                {
                    break;
                }
            }
        }
    }
}
