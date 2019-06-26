using System;
using System.Collections.Generic;
using System.Linq;

namespace _22._Andrey_And_Billiard
{
    class AndreyAndBilliard
    {
        private static Dictionary<string, decimal> shop;

        private static List<Customer> customers;
        class Customer
        {
            public string Name { get; set; }
            public Dictionary<string, int> ShopList { get; set; }
            public decimal Bill { get; set; }

            public Customer(string name)
            {
                Name = name;
                ShopList = new Dictionary<string, int>();
                this.Bill = 0m;
            }

        }
        static void Main(string[] args)
        {
            shop = new Dictionary<string, decimal>();
            customers = new List<Customer>();

            AddProductsInShop();

            AddCustomers();

            PrintCustomers();

        }

        private static void PrintCustomers()
        {
            decimal totalBill = customers.Sum(c => c.Bill);

            foreach (var customer in customers.OrderBy(c => c.Name))
            {
                Console.WriteLine(customer.Name);
                foreach (var product in customer.ShopList)
                {
                    Console.WriteLine($"-- {product.Key} - {product.Value}");
                }

                Console.WriteLine($"Bill: {customer.Bill:f2}");
            }

            Console.WriteLine($"Total bill: {totalBill:f2}");
        }

        private static void AddCustomers()
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of clients")
                {
                    break;
                }

                string[] inputLine = input.Split('-');
                string customerName = inputLine[0];
                string product = inputLine[1].Split(',')[0];
                int quantity = int.Parse(inputLine[1].Split(',')[1]);

                if (!shop.ContainsKey(product))
                {
                    continue;
                }

                Customer newCustomer = customers.FirstOrDefault(c => c.Name == customerName);

                if (newCustomer == null)
                {
                    Customer currentCustomer = new Customer(customerName);
                    currentCustomer.ShopList[product] = quantity;
                    currentCustomer.Bill = quantity * shop[product];

                    customers.Add(currentCustomer);
                }
                else
                {
                    if (!newCustomer.ShopList.ContainsKey(product))
                    {
                        newCustomer.ShopList[product] = 0;
                    }
                    newCustomer.ShopList[product] += quantity;

                    newCustomer.Bill += quantity * shop[product];
                }
            }
        }
        
        private static void AddProductsInShop()
        {
            int productsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < productsCount; i++)
            {
                string[] input = Console.ReadLine().Split('-');
                string product = input[0];
                decimal price = decimal.Parse(input[1]);

                if (!shop.ContainsKey(product))
                {
                    shop[product] = 0m;
                }
                shop[product] = price;
            }
        }
    }
}
