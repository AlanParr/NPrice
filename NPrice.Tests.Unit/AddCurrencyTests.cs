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
    }
}
