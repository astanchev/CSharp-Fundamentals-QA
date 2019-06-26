using System;

namespace _01._Blank_Receipt
{
    class BlankReceipt
    {
        static void Main(string[] args)
        {
            PrintReceipt();
        }

        private static void PrintReceipt()
        {
            PrintReceiptHeader();
            PrintReceiptBody();
            PrintReceiptFooter();
        }

        private static void PrintReceiptFooter()
        {
            Console.WriteLine(new string('-',30));
            Console.WriteLine("\u00A9 SoftUni");
        }

        private static void PrintReceiptBody()
        {
            Console.WriteLine("Charged to" + new string('_',20));
            Console.WriteLine("Received by" + new string('_',19));
        }

        private static void PrintReceiptHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine(new string('-',30));
        }
    }
}