## NPrice
Is a simple domain model for pricing.

## What problem does it solve?
When working in a system that operates with gross and net prices, tax rates, etc, these often get passed around as decimals, making it easy to pass a net price in as a gross price parameter. If you've got a price in hand, it may not always be clear what it is.
Tax rates can also often take different forms (20% can be represented as 0.2, 1.2, 20.00), which involves adding a lot of extra logic to handle these eventualities.

This is a very simple domain model around the concepts of pricing to add some type safety and simple conversions between different types of prices.

## To Do
** Better (and more tested) rounding to handle penny-rounding issues.
** Add more implicit/explicit conversions to make integrating in to an existing code-base easier.
** Support creating tax rate from % (20.00)