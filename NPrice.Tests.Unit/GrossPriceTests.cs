using Xunit;

namespace NPrice.Tests.Unit
{
    public class GrossPriceTests : PriceDerivedClassTestBase
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void TestCreation(TestDataObjects.PriceTestData testData)
        {
            var sut = new GrossPrice(testData.GrossValue, testData.RoundingPrecision);
            TestCreationBase(sut, testData.ExpectedGrossRoundedValue);
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void TestImplicitConversion(TestDataObjects.PriceTestData testData)
        {
            var sut = new GrossPrice(testData.GrossValue, testData.RoundingPrecision);
            TestImplicitConversionBase(sut, testData.GrossValue);
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void TestGetRoundedValue(TestDataObjects.PriceTestData testData)
        {
            var sut = new GrossPrice(testData.GrossValue, testData.RoundingPrecision);
            TestGetRoundedValueBase(sut, testData.ExpectedGrossRoundedValue, testData.RoundingPrecision);
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void TestGetToStringValue(TestDataObjects.PriceTestData testData)
        {
            var sut = new GrossPrice(testData.GrossValue, testData.RoundingPrecision);
            TestGetToStringWithPrecisionValueBase(sut, testData.ExpectedGrossToStringValue, testData.RoundingPrecision);
        }
        
        [Theory]
        [MemberData(nameof(Data))]
        public void TestGetToStringValueWithoutPrecision(TestDataObjects.PriceTestData testData)
        {
            var sut = new GrossPrice(testData.GrossValue, testData.RoundingPrecision);
            TestGetToStringValueBase(sut, testData.ExpectedGrossToStringValue);
        }
        
        [Fact]
        public void ToCurrency_ResultsInCorrectObject()
        {
            var originalPrice = new GrossPrice(12, 2);
            var linkedPrice = originalPrice.ToCurrency(new Currency("GBP"));
            Assert.Equal("GBP", linkedPrice.Currency.CurrencyCode);
            Assert.Equal(12, linkedPrice.Value);
            Assert.Equal(2, linkedPrice.OutputPrecision);
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void TestToNetConversion(TestDataObjects.PriceTestData testData)
        {
            var sut = new GrossPrice(testData.GrossValue, testData.RoundingPrecision);
            var net = new NetPrice(testData.NetValue, testData.RoundingPrecision);
            Assert.Equal(net.Value, sut.ToNet(new TaxRate(testData.TaxRate)).Value);
        }
    }
}