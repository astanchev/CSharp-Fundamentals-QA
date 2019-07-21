namespace _04.MakeitRain_21January2018
{
    using System;

    class MakeitRain
    {
        static void Main(string[] args)
        {
            int tCount = 0;
            int fCount = 0;

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());

                bool canDivide = false;

                try
                {
                    if (a / b == c)
                    {
                        canDivide = true;
                    }
                }
                catch 
                {
                    canDivide = false;
                }


                if (canDivide)
                {
                    tCount += 'T';
                    fCount /= 'T' / 10;
                }
                else
                {
                    fCount += 'F';
                    tCount /= 'F' / 10;
                }
            }

            Console.WriteLine($"T: {tCount}");
            Console.WriteLine($"F: {fCount}");

            bool isRoin = false;

            try
            {
                if ((tCount / fCount) % 2 == 0)
                {
                    isRoin = true;
                }
            }
            catch
            {
                isRoin = false;
            }
            
            Console.WriteLine($"Got a Roin coin: {isRoin}");
        }
    }
}
