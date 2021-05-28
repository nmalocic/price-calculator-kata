namespace PriceCalculator
{
    public class Tax
    {
        public Tax(int tax)
        {
            _tax = tax;
        }

        private int _tax { get; set; }

        public Product Apply(Product product)
        {
            decimal newPrice = this.Percent(product.Price) + product.Price;
            return new Product(product.Name, product.UPC, newPrice);
        }

        public decimal Percent(decimal ammount)
        {
            return ((decimal)this._tax / 100) * ammount;
        }

    }
}
