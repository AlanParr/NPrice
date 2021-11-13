namespace NPrice.Tests.Unit.TestDataObjects
{
    public class MathematicalOperationsTestsData
    {
        public MathematicalOperationsTestsData(decimal expectedAdditionResult, decimal expectedSubtractionResult, params decimal[] values)
        {
            ExpectedAdditionResult = expectedAdditionResult;
            ExpectedSubtractionResult = expectedSubtractionResult;
            Values = values;
        }

        public decimal[] Values { get; set; }
        public decimal ExpectedAdditionResult { get; set; }
        public decimal ExpectedSubtractionResult { get; set; }
    }
}