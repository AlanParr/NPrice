namespace NPrice.Tests.Unit;

/// <summary>
/// These tests are not so much to test behavior as to test the usability of the API.
/// </summary>
public class UsageTests
{
    public void CreateLinkedPriceFromScratch()
    {
        var databaseEntity = new
        {
            Price = 24, Currency = "GBP"
        };

        var price = new CurrencyLinkedNetPrice(databaseEntity.Price, 2, new Currency(databaseEntity.Currency));
        
        //Thoughts:
        // Should there be an implicit conversion from string to Currency?
        //This would make the above:
        // var price = new CurrencyLinkedNetPrice(databaseEntity.Price, 2, databaseEntity.Currency);
    }
}