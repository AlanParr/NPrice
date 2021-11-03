using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPrice.Tests.Unit.TestDataObjects
{
    public class NetPriceTestData
    {
        public NetPriceTestData(decimal inputValue, int roundingPrecision, decimal expectedRoundedValue, string expectedToStringValue,
            decimal taxRate, decimal expectedGrossValue)
        {
            InputValue = inputValue;
            RoundingPrecision = roundingPrecision;
            ExpectedRoundedValue = expectedRoundedValue;
            ExpectedToStringValue = expectedToStringValue;
            TaxRate = taxRate;
            ExpectedGrossValue = expectedGrossValue;
        }
        public decimal InputValue { get; set; }
        public int RoundingPrecision { get; set; }
        public decimal ExpectedRoundedValue { get; set; }
        public string ExpectedToStringValue { get; set; }
        public decimal TaxRate { get; }
        public decimal ExpectedGrossValue { get; }
    }
}
