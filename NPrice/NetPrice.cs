namespace NPrice
{
    public class NetPrice : Price
	{
		public NetPrice(decimal initialValue, int outputPrecision) : base(initialValue, outputPrecision) { }
		public GrossPrice ToGross(TaxRate vatRate)
		{
			return new GrossPrice(_value * vatRate.GetAsFractionOfOne(), OutputPrecision);
		}

		public void AddPrice(NetPrice netPrice)
        {
			_value += netPrice.GetRawValue();
        }
	}
}