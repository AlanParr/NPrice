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

        [Theory]
        [InlineData(20, 0.2)]
        [InlineData(5, 0.05)]
        public void FromDecimalPercentage(decimal percentage, decimal expectedRateValue)
        {
            var result = TaxRate.FromPercentage(percentage);
            Assert.Equal(expectedRateValue, result.GetAsFractionOfZero());
        }

        [Theory]
        [InlineData(20d, 0.2)]
        [InlineData(5d, 0.05)]
        public void FromDoublePercentage(double percentage, decimal expectedRateValue)
        {
            var result = TaxRate.FromPercentage(percentage);
            Assert.Equal(expectedRateValue, result.GetAsFractionOfZero());
        }
    }
}