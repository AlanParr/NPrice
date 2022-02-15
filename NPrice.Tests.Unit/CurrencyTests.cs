using Xunit;

namespace NPrice.Tests.Unit;

public class CurrencyTests
{
    [Theory]
    [InlineData("GBP")]
    [InlineData("USD")]
    [InlineData("BRL")]
    public void TestCurrencyCreation(string currencyCode)
    {
        var sut = new Currency(currencyCode);
        Assert.Equal(currencyCode, sut.CurrencyCode);
    }
}