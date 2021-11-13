namespace NPrice
{
    public class GrossPrice : Price
	{
		public GrossPrice(decimal initialValue, int outputPrecision) : base(initialValue, outputPrecision) { }
		public NetPrice ToNet(TaxRate vatRate)
		{
			return new NetPrice(Value / vatRate.GetAsFractionOfOne(), OutputPrecision);
		}

		public void AddPrice(GrossPrice grossPrice)
		{
			_value += grossPrice.GetRawValue();
		}

		public static GrossPrice operator +(GrossPrice leftPrice, GrossPrice rightPrice)
		{
			leftPrice.AddPrice(rightPrice);
			return leftPrice;
		}

		public static GrossPrice operator -(GrossPrice leftPrice, GrossPrice rightPrice)
		{
			leftPrice.SubtractPrice(rightPrice);
			return leftPrice;
		}
	}
}