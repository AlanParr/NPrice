namespace NPrice
{
    public class NetPrice : Price
	{
		public NetPrice(decimal initialValue) : base(initialValue) { }
		public GrossPrice ToGross(TaxRate vatRate)
		{
			return new GrossPrice(Value * vatRate.GetAsFractionOfOne());
		}
	}
}