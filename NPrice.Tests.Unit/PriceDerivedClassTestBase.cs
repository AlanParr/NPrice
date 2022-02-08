using System.Collections.Generic;
using Xunit;

namespace NPrice.Tests.Unit
{
    public class PriceDerivedClassTestBase
    {
        public void TestCreationBase(Price priceObject, TestDataObjects.PriceTestData testData)
        {
            Assert.Equal(testData.ExpectedNetRoundedValue, priceObject.Value);
        }

        public void TestImplicitConversionBase(Price priceObject, TestDataObjects.PriceTestData testData)
        {
            Assert.Equal(testData.NetValue, priceObject);
        }

        public void TestGetRoundedValueBase(Price priceObject, TestDataObjects.PriceTestData testData)
        {
            Assert.Equal(testData.ExpectedNetRoundedValue, priceObject.GetRoundedValue(testData.RoundingPrecision));
        }

        public void TestGetToStringValueBase(Price priceObject, TestDataObjects.PriceTestData testData)
        {
            Assert.Equal(testData.ExpectedNetToStringValue, priceObject.ToString(testData.RoundingPrecision));
        }

        public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
            new object[]{ new TestDataObjects.PriceTestData(10, 2, 10, "10.00", 12, "12.00", 0.2m, 12m) },
            new object[]{ new TestDataObjects.PriceTestData(15.746m, 2, 15.75m, "15.75", 18.90m, "18.89", 0.2m, 18.8952m) },
            new object[]{ new TestDataObjects.PriceTestData(200, 2, 200, "200.00", 240m, "240", 0.2m, 240m) },
            new object[]{ new TestDataObjects.PriceTestData(12.244m, 2, 12.24m, "12.24", 14.69m, "14.69", 0.2m, 14.6928m) },
            new object[]{ new TestDataObjects.PriceTestData(12.244m, 4, 12.244m, "12.2440", 14.69m, "14.69", 0.2m, 14.6928m) },
        };
    }
}
