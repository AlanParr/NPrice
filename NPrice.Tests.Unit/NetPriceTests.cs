using Xunit;

namespace NPrice.Tests.Unit
{
    public class NetPriceTests: PriceDerivedClassTestBase
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void TestCreation(TestDataObjects.PriceTestData testData)
        {
            var sut = new NetPrice(testData.NetValue, testData.RoundingPrecision);
            TestCreationBase(sut, testData.ExpectedNetRoundedValue);
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void TestImplicitConversion(TestDataObjects.PriceTestData testData)
        {
            var sut = new NetPrice(testData.NetValue, testData.RoundingPrecision);
            TestImplicitConversionBase(sut, testData.NetValue);
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void TestGetRoundedValue(TestDataObjects.PriceTestData testData)
        {
            var sut = new NetPrice(testData.NetValue, testData.RoundingPrecision);
            TestGetRoundedValueBase(sut, testData.ExpectedNetRoundedValue, testData.RoundingPrecision);
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void TestGetToStringValue(TestDataObjects.PriceTestData testData)
        {
            var sut = new NetPrice(testData.NetValue, testData.RoundingPrecision);
            TestGetToStringWithPrecisionValueBase(sut, testData.ExpectedNetToStringValue, testData.RoundingPrecision);
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void TestGetToStringValueWithoutPrecision(TestDataObjects.PriceTestData testData)
        {
            var sut = new NetPrice(testData.NetValue, testData.RoundingPrecision);
            TestGetToStringValueBase(sut, testData.ExpectedNetToStringValue);
        }
        
        [Theory]
        [MemberData(nameof(Data))]
        public void TestToGrossConversion(TestDataObjects.PriceTestData testData)
        {
            var sut = new NetPrice(testData.NetValue, testData.RoundingPrecision);
            var gross = new GrossPrice(testData.GrossValue, testData.RoundingPrecision);
            Assert.Equal(gross.Value, sut.ToGross(new TaxRate(testData.TaxRate)).Value);
        }
        
    }
}