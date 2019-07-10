using System;
using System.Collections.Generic;

namespace _04._Shopping_Spree
{
    public class Person
    {
        private string personName;
        private decimal money;
        public Person(string personName, decimal money)
        {
            this.PersonName = personName;
            this.Money = money;
            this.BagOfProducts = new List<Product>();
        }

        public string PersonName
        {
            get
            {
                return this.personName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value == string.Empty)
                {
                    throw new ArgumentException($"Name cannot be empty");
                }

                this.personName = value;
            }
        }

        public decimal Money
        {
            get
            {
                return this.money;
            }
            set
            {
                if (value < 0.0M)
                {
                    throw new ArgumentException($"Money cannot be negative");
                }

                this.money = value;
            }
        }

        public List<Product> BagOfProducts { get; set; }
    }
}