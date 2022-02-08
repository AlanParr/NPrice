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
    
    public class CurrencyLinkedNetPrice : NetPrice
    {
	    public Currency Currency { get; }

	    public CurrencyLinkedNetPrice(decimal initialValue, int outputPrecision, Currency currency) : base(initialValue, outputPrecision)
	    {
		    Currency = currency;
	    }
	    
	    public new CurrencyLinkedGrossPrice ToGross(TaxRate vatRate)
	    {
		    return new CurrencyLinkedGrossPrice(_value * vatRate.GetAsFractionOfOne(), OutputPrecision, Currency);
	    }
	    
	    public CurrencyLinkedNetPrice ToCurrency(Currency currency)
	    {
		    return new CurrencyLinkedNetPrice(Value, OutputPrecision, currency);
	    }
    }
}