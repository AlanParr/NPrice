## NPrice
Is a simple domain model for working with Net/Gross prices and Tax Rates in a strongly-typed manner.

<a href="https://www.nuget.org/packages/NPrice" rel="NuHet">![NuGet](https://img.shields.io/nuget/vpre/NPrice.svg)</a>

![Build](https://github.com/AlanParr/NPrice/actions/workflows/dotnet.yml/badge.svg)

## What problem does it solve?
When working in a system that operates with gross and net prices, tax rates, etc, these often get passed around as decimals, making it easy to pass a net price in as a gross price parameter. Additionally, if you've got a price in hand, it may not always be clear what it is.

Tax rates can also often take different forms (20% can be represented as 0.2, 1.2, 20.00), which involves adding a lot of extra logic to handle these eventualities.

This is a very simple domain model around the concepts of pricing to add some type safety and simple conversions between different types of prices.

## Usage

Create a tax rate:
```csharp
var taxRate = new TaxRate(0.2m);
taxRate.GetAsFractionOfOne()  //Returns 1.2.
taxRate.GetAsFractionOfZero() //Returns 0.2.
```

Create a tax rate from a percentage:
```csharp
var taxRate = TaxRate.FromPercentage(20m);
taxRate.GetAsFractionOfOne()  //Returns 1.2.
taxRate.GetAsFractionOfZero() //Returns 0.2.
```

Create a net price:
```csharp
var netPrice = new NetPrice(10m);
```

Convert to gross:
```csharp
var grossPrice = netPrice.ToGross(new TaxRate(0.2m));
```

Get rounded price:
```csharp
grossPrice.GetRoundedValue(2);  //Returns 12.0
grossPrice.ToString(2);         //Returns "12.00"
```

### Currency linked prices usage
Create a price linked to a currency:
```csharp
var databaseEntity = new
{
	Price = 24.675m,
	Currency = "GBP"
};

var price = new CurrencyLinkedNetPrice(databaseEntity.Price, 2, new Currency(databaseEntity.Currency));
```

In the above, we have an entity which we'll pretend came from our database.

We then create a CurrencyLinkedNetPrice which contains both the numerical representation of the price and the currency that it is in.


The currency can follow the price through in to being a gross price.

```csharp
    price.ToGross(new TaxRate(20m));
```

Additionally, if you have a currency-unaware price, you can easily convert it to be currency-aware.

```csharp
    var simpleNetPrice = new NetPrice(databaseEntity.Price, 2);
    simpleNetPrice.ToCurrency(new Currency(databaseEntity.Currency));
```