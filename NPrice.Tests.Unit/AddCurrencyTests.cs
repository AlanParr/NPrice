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
        public void TestAddPounds(decimal startingValue, int roundingPrecision, int valueToAdd, decimal expectedValue)
        {
            var sut = new NetPrice(startingValue, roundingPrecision);
            sut.AddPounds(valueToAdd);
            Assert.Equal(expectedValue, sut.Value);
        }
    }
}
