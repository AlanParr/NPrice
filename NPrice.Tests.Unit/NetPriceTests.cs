using Xunit;

namespace NPrice.Tests.Unit
{
    public class NetPriceTests: PriceDerivedClassTestBase
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void TestCreation(TestDataObjects.NetPriceTestData testData)
        {
            var sut = new NetPrice(testData.InputValue, testData.RoundingPrecision);
            TestCreationBase(sut, testData);
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void TestImplicitConversion(TestDataObjects.NetPriceTestData testData)
        {
            var sut = new NetPrice(testData.InputValue, testData.RoundingPrecision);
            TestImplicitConversionBase(sut, testData);
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void TestGetRoundedValue(TestDataObjects.NetPriceTestData testData)
        {
            var sut = new NetPrice(testData.InputValue, testData.RoundingPrecision);
            TestGetRoundedValueBase(sut, testData);
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void TestGetToStringValue(TestDataObjects.NetPriceTestData testData)
        {
            var sut = new NetPrice(testData.InputValue, testData.RoundingPrecision);
            TestGetToStringValueBase(sut, testData);
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void TestToGrossConversion(TestDataObjects.NetPriceTestData testData)
        {
            var sut = new NetPrice(testData.InputValue, testData.RoundingPrecision);
            Assert.Equal(testData.ExpectedGrossValue, sut.ToGross(new TaxRate(testData.TaxRate)));
        }
    }
}