using Xunit;

namespace NPrice.Tests.Unit;

public class CurrencyLinkedPriceTests
{
    [Fact]
    public void CurrencyLinkedGrossPriceCreationTest()
    {
        var linkedGross = new CurrencyLinkedGrossPrice(12, 2, new Currency("GBP"));
        Assert.Equal("GBP", linkedGross.Currency.CurrencyCode);
    }
    
    [Fact]
    public void CurrencyLinkedNetPriceCreationTest()
    {
        var linkedGross = new CurrencyLinkedNetPrice(12, 2, new Currency("GBP"));
        Assert.Equal("GBP", linkedGross.Currency.CurrencyCode);
    }
    
    [Fact]
    public void CurrencyLinkedGrossPriceToNet_CurrencyCodeTransfers()
    {
        var linkedOriginal = new CurrencyLinkedGrossPrice(12, 2, new Currency("GBP"));
        var linkedConverted = linkedOriginal.ToNet(new TaxRate(20m));
        Assert.Equal("GBP", linkedConverted.Currency.CurrencyCode);
    }
    
    [Fact]
    public void CurrencyLinkedNetPriceToGross_CurrencyCodeTransfers()
    {
        var linkedOriginal = new CurrencyLinkedNetPrice(12, 2, new Currency("GBP"));
        var linkedConverted = linkedOriginal.ToGross(new TaxRate(20m));
        Assert.Equal("GBP", linkedConverted.Currency.CurrencyCode);
    }
    
    [Fact]
    public void CurrencyLinkedGrossPrice_ToCurrency_ResultsInObjectOfCorrectCurrency()
    {
        var linkedOriginal = new CurrencyLinkedGrossPrice(12, 2, new Currency("GBP"));
        var linkedToUSD = linkedOriginal.ToCurrency(new Currency("USD"));
        Assert.Equal("USD", linkedToUSD.Currency.CurrencyCode);
    }
    
    [Fact]
    public void CurrencyLinkedNetPrice_ToCurrency_ResultsInObjectOfCorrectCurrency()
    {
        var linkedOriginal = new CurrencyLinkedNetPrice(12, 2, new Currency("GBP"));
        var linkedToUSD = linkedOriginal.ToCurrency(new Currency("USD"));
        Assert.Equal("USD", linkedToUSD.Currency.CurrencyCode);
    }
}