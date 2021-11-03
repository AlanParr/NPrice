namespace NPrice
{
    public class GrossPrice : Price
	{
		public GrossPrice(decimal initialValue) : base(initialValue) { }
		public NetPrice ToNet(TaxRate vatRate)
		{
			return new NetPrice(Value / vatRate.GetAsFractionOfOne());
		}
	}
}