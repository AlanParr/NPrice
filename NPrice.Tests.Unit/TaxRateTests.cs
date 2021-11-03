using Xunit;

namespace NPrice.Tests.Unit
{
    public class TaxRateTests
    {
        [Theory]
        [InlineData(0.2, 0.2, 1.2)]
        [InlineData(0, 0, 1.0)]
        public void TestCreation(decimal inputValue, decimal expectedZeroPrefixValue, decimal expectedOnePrefixValue)
        {
            var taxRate = new TaxRate(inputValue);
            Assert.Equal(expectedZeroPrefixValue, taxRate.GetAsFractionOfZero());
            Assert.Equal(expectedOnePrefixValue, taxRate.GetAsFractionOfOne());
        }
    }
}