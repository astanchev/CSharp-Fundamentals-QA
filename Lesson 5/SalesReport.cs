using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace _16._Sales_Report
{
    class SalesReport
    {
        public static Dictionary<string, double> townSales;
        public class Sale
        {
            public string Town { get; set; }
            public string Product { get; set; }
            public double Price { get; set; }
            public double Quantity { get; set; }

            public Sale(string town, string product, double price, double quantity)
            {
                Town = town;
                Product = product;
                Price = price;
                Quantity = quantity;
            }

        }
        static void Main(string[] args)
        {
            townSales = new Dictionary<string, double>();

            int numberSales = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberSales; i++)
            {
                Sale currentSale = ReadSale();

                AddSale(currentSale);
            }

            PrintSales();

        }

        private static Sale ReadSale()
        {
            string[] input = Console.ReadLine().Split();
            string town = input[0];
            string product = input[1];
            double price = double.Parse(input[2]);
            double quantity = double.Parse(input[3]);

            return new Sale(town, product, price, quantity);
        }

        private static void PrintSales()
        {
            foreach (var town in townSales.OrderBy(t => t.Key))
            {
                Console.WriteLine($"{town.Key} -> {town.Value:f2}");
            }
        }

        private static void AddSale(Sale sale)
        {
            double totalSale = sale.Price * sale.Quantity;

            if (!townSales.ContainsKey(sale.Town))
            {
                townSales[sale.Town] = 0.0;
            }

            townSales[sale.Town] += totalSale;
        }
    }
}
