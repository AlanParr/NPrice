using Xunit;
using Xunit.Abstractions;

namespace NPrice.Tests.Unit;

/// <summary>
/// These tests are not so much to test behavior as to test the usability of the API.
/// </summary>
public class UsageTests
{
    private readonly ITestOutputHelper _outputHelper;

    public UsageTests(ITestOutputHelper outputHelper)
    {
        _outputHelper = outputHelper;
    }
    
    [Fact]
    public void CreateLinkedPriceFromScratch()
    {
        var databaseEntity = new
        {
            Price = 24.675m, Currency = "GBP"
        };

        var price = new CurrencyLinkedNetPrice(databaseEntity.Price, 2, new Currency(databaseEntity.Currency));

        var currencyGrossPrice = price.ToGross(new TaxRate(20m));

        var simpleNetPrice = new NetPrice(databaseEntity.Price, 2);
        simpleNetPrice.ToCurrency(new Currency(databaseEntity.Currency));
        MethodThatIsExpectingANetPrice(price);
        //Thoughts:
        // Should there be an implicit conversion from string to Currency?
        //This would make the above:
        // var price = new CurrencyLinkedNetPrice(databaseEntity.Price, 2, databaseEntity.Currency);
        
        //Just to make it pass, change to false if test is showing an undesirable pattern of usage.
        Assert.True(true);
    }

    private void MethodThatIsExpectingANetPrice(NetPrice netPrice)
    {
        _outputHelper.WriteLine($"Object of type {netPrice.GetType()} received with value {netPrice.Value}");
    }
}