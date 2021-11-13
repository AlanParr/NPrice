namespace NPrice
{
    public class NetPrice : Price
	{
		public NetPrice(decimal initialValue, int outputPrecision) : base(initialValue, outputPrecision) { }
		public GrossPrice ToGross(TaxRate vatRate)
		{
			return new GrossPrice(_value * vatRate.GetAsFractionOfOne(), OutputPrecision);
		}

		public static NetPrice operator+ (NetPrice leftPrice, NetPrice rightPrice)
		{
			leftPrice.AddPrice(rightPrice);
			return leftPrice;
		}

		public static NetPrice operator -(NetPrice leftPrice, NetPrice rightPrice)
		{
			leftPrice.SubtractPrice(rightPrice);
			return leftPrice;
		}
	}
}