using System;

namespace NPrice
{
    public class TaxRate
    {
        private readonly decimal _value;
        public TaxRate(decimal vatRate)
        {
            _value = vatRate;
        }

        public decimal GetAsFractionOfZero() => _value > 1 ? _value - 1 : _value;
        public decimal GetAsFractionOfOne() => _value < 1 ? _value + 1 : _value;

        public static TaxRate FromPercentage(decimal percentageValue)
        {
            return percentageValue == 0m 
                ? new TaxRate(percentageValue) 
                : new TaxRate(percentageValue / 100);
        }

        public static TaxRate FromPercentage(double percentageValue)
        {
            return percentageValue == 0d 
                ? new TaxRate(Convert.ToDecimal(percentageValue)) 
                : new TaxRate(Convert.ToDecimal(percentageValue) / 100);
        }
    }
}