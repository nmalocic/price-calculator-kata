using PriceCalculator;
using Xunit;

namespace PriceCalculatorTest
{
    public class PriceCalculatorTests
    {
        [Theory]
        [InlineData(20, 24.30)]
        [InlineData(21, 24.50)]
        public void GetTaxedProduct(int percent, double expected)
        {
            Product book = new Product("The Little Prince", 1234, 20.25m);
            Tax bookTax = new Tax(percent);

            Product taxedBook = bookTax.Apply(book);
            Assert.Equal(expected, (double)taxedBook.Price);
        }
    }
}
