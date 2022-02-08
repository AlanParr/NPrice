namespace NPrice.Tests.Unit.TestDataObjects
{
    public class PriceTestData
    {
        public PriceTestData(decimal netValue, int roundingPrecision, 
            decimal expectedNetRoundedValue, string expectedNetToStringValue,
            decimal expectedGrossRoundedValue, string expectedGrossToStringValue,
            decimal taxRate, decimal grossValue)
        {
            NetValue = netValue;
            RoundingPrecision = roundingPrecision;
            ExpectedNetRoundedValue = expectedNetRoundedValue;
            ExpectedNetToStringValue = expectedNetToStringValue;
            ExpectedGrossRoundedValue = expectedGrossRoundedValue;
            ExpectedGrossToStringValue = expectedGrossToStringValue;
            TaxRate = taxRate;
            GrossValue = grossValue;
        }
        public decimal NetValue { get; set; }
        public int RoundingPrecision { get; set; }
        public decimal ExpectedNetRoundedValue { get; set; }
        public string ExpectedNetToStringValue { get; set; }
        public decimal ExpectedGrossRoundedValue { get; }
        public string ExpectedGrossToStringValue { get; }
        public decimal TaxRate { get; }
        public decimal GrossValue { get; }
    }
}