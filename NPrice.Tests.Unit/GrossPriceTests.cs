using Xunit;

namespace NPrice.Tests.Unit
{
    public class GrossPriceTests : PriceDerivedClassTestBase
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void TestCreation(TestDataObjects.NetPriceTestData testData)
        {
            var sut = new GrossPrice(testData.InputValue, testData.RoundingPrecision);
            TestCreationBase(sut, testData);
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void TestImplicitConversion(TestDataObjects.NetPriceTestData testData)
        {
            var sut = new GrossPrice(testData.InputValue, testData.RoundingPrecision);
            TestCreationBase(sut, testData);
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void TestGetRoundedValue(TestDataObjects.NetPriceTestData testData)
        {
            var sut = new GrossPrice(testData.InputValue, testData.RoundingPrecision);
            TestGetRoundedValueBase(sut, testData);
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void TestGetToStringValue(TestDataObjects.NetPriceTestData testData)
        {
            var sut = new GrossPrice(testData.InputValue, testData.RoundingPrecision);
            TestGetToStringValueBase(sut, testData);
        }

    }
}