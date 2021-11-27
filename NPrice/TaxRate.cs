using System;

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

        public static TaxRate FromPercentage(decimal percentageValue)
        {
            if (percentageValue == 0m) return new TaxRate(percentageValue);

            return new TaxRate(percentageValue / 100);
        }

        public static TaxRate FromPercentage(double percentageValue)
        {
            if (percentageValue == 0d) return new TaxRate(Convert.ToDecimal(percentageValue));

            return new TaxRate(Convert.ToDecimal(percentageValue) / 100);
        }
    }
}