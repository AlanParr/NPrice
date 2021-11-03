using System.Collections.Generic;
using Xunit;

namespace NPrice.Tests.Unit
{
    public class NetPriceTests
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void TestCreation(TestDataObjects.NetPriceTestData testData)
        {
            var sut = new NetPrice(testData.InputValue);
            Assert.Equal(testData.InputValue, sut.Value);
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void TestImplicitConversion(TestDataObjects.NetPriceTestData testData)
        {
            var sut = new NetPrice(testData.InputValue);
            Assert.Equal(testData.InputValue, sut);
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void TestGetRoundedValue(TestDataObjects.NetPriceTestData testData)
        {
            var sut = new NetPrice(testData.InputValue);
            Assert.Equal(testData.ExpectedRoundedValue, sut.GetRoundedValue(testData.RoundingPrecision));
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void TestGetToStringValue(TestDataObjects.NetPriceTestData testData)
        {
            var sut = new NetPrice(testData.InputValue);
            Assert.Equal(testData.ExpectedToStringValue, sut.ToString(testData.RoundingPrecision));
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void TestToGrossConversion(TestDataObjects.NetPriceTestData testData)
        {
            var sut = new NetPrice(testData.InputValue);
            Assert.Equal(testData.ExpectedGrossValue, sut.ToGross(new TaxRate(testData.TaxRate)));
        }

        public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
            new object[]{ new TestDataObjects.NetPriceTestData(10, 2, 10, "10.00", 0.2m, 12m) },
            new object[]{ new TestDataObjects.NetPriceTestData(15.746m, 2, 15.75m, "15.75", 0.2m, 18.8952m) },
            new object[]{ new TestDataObjects.NetPriceTestData(200, 2, 200, "200.00", 0.2m, 240m) },
            new object[]{ new TestDataObjects.NetPriceTestData(12.244m, 2, 12.24m, "12.24", 0.2m, 14.6928m) },
            new object[]{ new TestDataObjects.NetPriceTestData(12.244m, 4, 12.244m, "12.2440", 0.2m, 14.6928m) },
        };
    }
}
