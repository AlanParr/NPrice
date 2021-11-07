using System.Collections.Generic;
using Xunit;

namespace NPrice.Tests.Unit
{
    public class PriceDerivedClassTestBase
    {
        public void TestCreationBase(Price priceObject, TestDataObjects.NetPriceTestData testData)
        {
            Assert.Equal(testData.ExpectedRoundedValue, priceObject.Value);
        }

        public void TestImplicitConversionBase(Price priceObject, TestDataObjects.NetPriceTestData testData)
        {
            Assert.Equal(testData.InputValue, priceObject);
        }

        public void TestGetRoundedValueBase(Price priceObject, TestDataObjects.NetPriceTestData testData)
        {
            Assert.Equal(testData.ExpectedRoundedValue, priceObject.GetRoundedValue(testData.RoundingPrecision));
        }

        public void TestGetToStringValueBase(Price priceObject, TestDataObjects.NetPriceTestData testData)
        {
            Assert.Equal(testData.ExpectedToStringValue, priceObject.ToString(testData.RoundingPrecision));
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
