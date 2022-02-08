using Xunit;

namespace NPrice.Tests.Unit
{
    public class GrossPriceTests : PriceDerivedClassTestBase
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void TestCreation(TestDataObjects.PriceTestData testData)
        {
            var sut = new GrossPrice(testData.NetValue, testData.RoundingPrecision);
            TestCreationBase(sut, testData);
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void TestImplicitConversion(TestDataObjects.PriceTestData testData)
        {
            var sut = new GrossPrice(testData.NetValue, testData.RoundingPrecision);
            TestImplicitConversionBase(sut, testData);
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void TestGetRoundedValue(TestDataObjects.PriceTestData testData)
        {
            var sut = new GrossPrice(testData.NetValue, testData.RoundingPrecision);
            TestGetRoundedValueBase(sut, testData);
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void TestGetToStringValue(TestDataObjects.PriceTestData testData)
        {
            var sut = new GrossPrice(testData.NetValue, testData.RoundingPrecision);
            TestGetToStringValueBase(sut, testData);
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