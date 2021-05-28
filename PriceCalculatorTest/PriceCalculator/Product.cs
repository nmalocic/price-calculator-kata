using System;

namespace PriceCalculator
{
    public class Product
    {
        private decimal _price;
        public Product(string name, int uPC, decimal price)
        {
            Name = name;
            UPC = uPC;
            _price = price;
        }

        public string Name { get; private set; }
        public int UPC { get; private set; }
        public decimal Price => Math.Round(_price, 2, MidpointRounding.AwayFromZero);
    }
}
