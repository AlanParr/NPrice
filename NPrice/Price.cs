using System;

namespace NPrice
{
    public class Price
	{
		public decimal Value { get; private set; }

		protected Price(decimal initialValue)
		{
			Value = initialValue;
		}

		public decimal GetRoundedValue(int precision)
		{
			return Math.Round(Value, precision, MidpointRounding.AwayFromZero);
		}

		public string ToString(int decimalPlaces)
		{
			return GetRoundedValue(decimalPlaces).ToString($"N{decimalPlaces}");
		}

		public static implicit operator decimal(Price price)
		{
			return price.Value;
		}
	}
}