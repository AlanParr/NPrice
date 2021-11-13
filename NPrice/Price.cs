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

        public void AddPrice(Price price)
        {
            _value += price.GetRawValue();
        }

        public void SubtractPrice(Price price)
        {
            _value -= price.GetRawValue();
        }

        internal decimal GetRawValue() => _value;

        public decimal GetRoundedValue(int precision) => Math.Round(_value, precision, MidpointRounding.AwayFromZero);

        public string ToString(int decimalPlaces) => GetRoundedValue(decimalPlaces).ToString($"N{decimalPlaces}");
        
		public override string ToString() => GetRoundedValue(OutputPrecision).ToString($"N{OutputPrecision}");

        public void AddMajorUnit(int poundsToAdd) => _value += poundsToAdd;
		public void AddMinorUnit(int penniesToAdd) => _value += (penniesToAdd / 100m);

        public static implicit operator decimal(Price price) => price._value;
    }
}