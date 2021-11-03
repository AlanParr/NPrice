namespace NPrice
{
    public class TaxRate
    {
        private decimal _value;
        public TaxRate(decimal vatRate)
        {
            _value = vatRate;
        }

        public decimal GetAsFractionOfZero() => _value > 1 ? _value - 1 : _value;
        public decimal GetAsFractionOfOne() => _value < 1 ? _value + 1 : _value;
    }
}