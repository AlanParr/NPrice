using System;

namespace NPrice
{
    public class Price
	{
		protected decimal _value;
        public int OutputPrecision { get; }
		public decimal Value => GetRoundedValue(OutputPrecision);

        protected Price(decimal initialValue, int outputPrecision)
		{
			_value = initialValue;
            OutputPrecision = outputPrecision;
        }

		public decimal GetRoundedValue(int precision)
		{
			return Math.Round(_value, precision, MidpointRounding.AwayFromZero);
		}

		public string ToString(int decimalPlaces)
		{
			return GetRoundedValue(decimalPlaces).ToString($"N{decimalPlaces}");
		}
        public override string ToString()
        {
			return GetRoundedValue(OutputPrecision).ToString($"N{OutputPrecision}");
		}

		public void AddPounds(int poundsToAdd) => _value += poundsToAdd;
		public void AddPennies(int penniesToAdd) => _value += (penniesToAdd / 100m);

        public static implicit operator decimal(Price price)
		{
			return price._value;
		}
	}
}