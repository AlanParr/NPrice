namespace NPrice
{
    public class GrossPrice : Price
	{
		public GrossPrice(decimal initialValue, int outputPrecision) : base(initialValue, outputPrecision) { }
		public NetPrice ToNet(TaxRate vatRate)
		{
			return new NetPrice(Value / vatRate.GetAsFractionOfOne(), OutputPrecision);
		}
	}
}