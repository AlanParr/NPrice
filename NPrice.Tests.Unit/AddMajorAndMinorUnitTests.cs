using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace NPrice.Tests.Unit
{
    
    public class AddCurrencyTests
    {
        [Theory]
        [InlineData(10.99, 2, 1, 11.99)]
        [InlineData(110.27, 2, 12, 122.27)]
        [InlineData(118.23587, 2, 8, 126.24)]
        [InlineData(10.99, 3, 1, 11.99)]
        [InlineData(110.27, 3, 12, 122.27)]
        [InlineData(118.23587, 3, 8, 126.236)]
        [InlineData(118.23587, 4, 8, 126.2359)]
        [InlineData(118.23587534, 6, 8, 126.235875)]
        public void TestAddMajorUnit(decimal startingValue, int roundingPrecision, int valueToAdd, decimal expectedValue)
        {
            var sut = new NetPrice(startingValue, roundingPrecision);
            sut.AddMajorUnit(valueToAdd);
            Assert.Equal(expectedValue, sut.Value);
        }

        [Theory]
        [InlineData(10.99, 2, 1, 11.00)]
        [InlineData(110.27, 2, 12, 110.39)]
        [InlineData(118.23587, 2, 121, 119.45)]
        public void TestAddMinorUnit(decimal startingValue, int roundingPrecision, int valueToAdd, decimal expectedValue)
        {
            var sut = new NetPrice(startingValue, roundingPrecision);
            sut.AddMinorUnit(valueToAdd);
            Assert.Equal(expectedValue, sut.Value);
        }

        [Fact]
        public void TestAddMultipleUnits()
        {
            var sut = new NetPrice(12.99m, 2);
            sut.AddMajorUnit(4);
            sut.AddMinorUnit(99);

            Assert.Equal(17.98m, sut.Value);
        }

        [Fact]
        public void TestAddMultipleUnitsHighPrecision()
        {
            var sut = new NetPrice(12.99m, 6);
            sut.AddMajorUnit(4);
            sut.AddMinorUnit(99);
            sut.AddMinorUnit(21);

            Assert.Equal(18.19m, sut.Value);
        }
    }
}
