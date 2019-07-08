namespace _01.AnonymousDownsiteExamPreparation
{
    using System;
    using System.Numerics;
    using System.Text;

    class AnonymousDownsite
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            int numberWebsites = int.Parse(Console.ReadLine());
            int securityKey = int.Parse(Console.ReadLine());
            decimal totalLoss = 0.0M;

            for (int i = 0; i < numberWebsites; i++)
            {
                string[] input = Console.ReadLine().Split();

                string siteName = input[0];
                long visits = long.Parse(input[1]);
                decimal price = decimal.Parse(input[2]);

                totalLoss += visits * price;

                sb.AppendLine(siteName);
            }

            Console.WriteLine(sb.ToString().TrimEnd());
            
            Console.WriteLine($"Total Loss: {totalLoss:f20}");

            Console.WriteLine($"Security Token: {BigInteger.Pow(new BigInteger(securityKey), numberWebsites)}");
        }
    }
}
