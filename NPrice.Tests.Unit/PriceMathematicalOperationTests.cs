using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace NPrice.Tests.Unit
{
    public class PriceMathematicalOperationTests
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void AddMultipleNetPricesTogether(TestDataObjects.MathematicalOperationsTestsData data)
        {
            var firstPrice = new NetPrice(data.Values[0], 2);

            var result = firstPrice;
            foreach(var price in data.Values.Skip(1))
            {
                result += new NetPrice(price, 2);
            }

            Assert.IsType<NetPrice>(result);
            Assert.Equal(data.ExpectedAdditionResult, result);
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void SubtractMultipleNetPrices(TestDataObjects.MathematicalOperationsTestsData data)
        {
            var firstPrice = new NetPrice(data.Values[0], 2);

            var result = firstPrice;
            foreach (var price in data.Values.Skip(1))
            {
                result -= new NetPrice(price, 2);
            }

            Assert.IsType<NetPrice>(result);
            Assert.Equal(data.ExpectedSubtractionResult, result);
        }

        public static IEnumerable<object[]> Data =>
        new List<object[]> {
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(15, 5, 10, 5) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(36.00234m, 31.99766m, 34m,2.00234m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(73.00446m, 18.59334m, 45.7989m,11.68090m,15.52466m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(48.54489m, 35.45511m, 42m,6.54489m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(161.705m, 23.845m, 92.775m,68.93m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(4.11762m, 1.88238m, 3m,1.11762m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(68.1m, -21.7m, 23.2m,16.3m,28.6m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(109.42604m, 71.44604m, 90.43604m,18.99m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(3.137m, 2.463m, 2.8m,0.337m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(2.2161m, 2.1839m, 2.20m,0.0161m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(137.1748m, 40.7748m, 88.9748m,48.20m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(51.11512m, 15.43512m, 33.27512m,14.86m,2.98m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(4.8467m, 4.8467m, 4.8467m,0m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(73.34m, 15.26m, 44.3m,29.04m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(43.9159m, 23.9159m, 33.9159m,5m,5m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(14.59m, 11.41m, 13m,1.59m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(61.84m, 28.16m, 45m,16.84m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(82.311m, 12.889m, 47.6m,16.968m,17.743m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(41.39m, 29.79m, 35.59m,3.0m,2.8m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(28.23720m, 4.67740m, 16.45730m,11.77990m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(0.1126m, 0.1126m, 0.1126m,0m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(25.51649m, 18.48351m, 22m,3.51649m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(40.336m, 22.336m, 31.336m,1.6m,7.4m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(59.71970m, 1.70250m, 30.7111m,29.00860m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(47.2m, 46.8m, 47m,0.2m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(44.1334m, 39.3534m, 41.7434m,2.39m,0m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(46.41649m, 4.61849m, 25.51749m,13.060m,7.839m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(25.48555m, 12.63445m, 19.06m,4.55342m,1.87213m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(11.637m, 8.417m, 10.027m,1.610m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(20.0870m, 7.5130m, 13.80m,1.0894m,5.1976m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(29.59m, 17.59m, 23.59m,3m,3m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(28.8814m, 12.8814m, 20.8814m,8m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(40.2190m, 2.3810m, 21.3m,0.3038m,18.6152m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(15.4981m, 11.9981m, 13.7481m,1.57m,0.18m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(55.02m, 7.02m, 31.02m,10m,14m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(11.70608m, 8.21192m, 9.959m,1.74708m,0m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(27.1528m, 15.0472m, 21.1m,0.0020m,6.0508m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(7.59048m, 3.79048m, 5.69048m,1.65m,0.25m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(52.4610m, 49.5390m, 51m,1.4610m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(19.6140m, 10.3860m, 15m,4.6140m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(8.1252m, 1.0146m, 4.5699m,3.5553m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(30.52187m, 29.70187m, 30.11187m,0.41m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(15.9m, 11.9m, 13.9m,2m,0m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(2.88182m, 1.92022m, 2.40102m,0.4808m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(66.2m, 44.2m, 55.2m,1m,10m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(27.075m, 18.675m, 22.875m,4.2m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(14.9076m, 3.3856m, 9.1466m,2.4605m,3.3005m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(40.75072m, 7.30928m, 24.03m,16.72072m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(55.12563m, 54.85037m, 54.988m,0.13763m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(42.394m, 42.394m, 42.394m,0m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(40.9218m, 12.9186m, 26.9202m,14.0016m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(8.5m, 4.3m, 6.4m,2.1m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(53.05813m, 1.13987m, 27.099m,15.41349m,10.54564m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(72.461m, 41.539m, 57m,15.461m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(19.363m, 17.363m, 18.363m,1.0m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(67.92731m, 47.06731m, 57.49731m,3.465m,6.965m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(32.0720m, 10.3280m, 21.20m,8.8687m,2.0033m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(1.93514m, 1.39086m, 1.663m,0.27214m,0m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(34.06310m, 32.08632m, 33.07471m,0.19180m,0.79659m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(77.57006m, 62.42994m, 70m,7.57006m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(49.67218m, 40.22582m, 44.949m,4.72318m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(10.43m, 9.97m, 10.2m,0.23m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(29.759m, 27.639m, 28.699m,1.06m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(23.6807m, 15.9907m, 19.8357m,0.611m,3.234m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(26.35683m, 21.38317m, 23.870m,1.48208m,1.00475m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(17.7m, 11.7m, 14.7m,3m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(21.49308m, 14.51308m, 18.00308m,3.49m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(69.8693m, 17.9907m, 43.93m,18.3174m,7.6219m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(79.1559m, 49.4759m, 64.3159m,14.84m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(106.79450m, 28.19450m, 67.49450m,25.3m,14.0m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(1m, 1m, 1m,0m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(44.1487m, 21.4887m, 32.8187m,11.33m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(41.38031m, 16.30843m, 28.84437m,12.53594m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(17.022m, 12.978m, 15m,2.022m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(38.5982m, 34.8018m, 36.7m,1.8982m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(85.815m, 25.775m, 55.795m,30.02m,0m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(38.02840m, 31.97160m, 35m,3.02840m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(111.1694m, 72.8306m, 92m,19.1694m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(61.89135m, 29.64189m, 45.76662m,4.98293m,11.14180m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(15.43730m, 9.74270m, 12.59m,2.84730m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(14.0m, 10.0m, 12.0m,2m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(29.25780m, 8.61740m, 18.93760m,10.3202m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(38.8304m, 7.7704m, 23.3004m,10.09m,5.44m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(101.1116m, 58.2884m, 79.7m,13.0566m,8.3550m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(20.046m, -1.954m, 9.046m,3m,8m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(31.99320m, 23.57260m, 27.7829m,1.25874m,2.95156m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(12.069m, 9.931m, 11m,1.069m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(22.8m, 21.2m, 22m,0.8m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(64.2m, 42.2m, 53.2m,6m,5m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(42.03211m, 23.96789m, 33m,9.03211m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(102.93684m, -16.89164m, 43.0226m,41.10881m,18.80543m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(30.10825m, 26.05755m, 28.0829m,2.02535m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(36.08743m, 29.91257m, 33m,3.08743m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(28.3720m, 24.1320m, 26.2520m,2.1200m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(5.70723m, 4.29277m, 5m,0.70723m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(5.1800m, 3.0600m, 4.12m,1.0600m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(9.6581m, 7.6581m, 8.6581m,1m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(42.03460m, 35.96540m, 39m,3.03460m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(5.39m, 5.39m, 5.39m,0m,0m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(79.85m, 43.95m, 61.9m,13.13m,4.82m) },
                new object[]{ new TestDataObjects.MathematicalOperationsTestsData(91.2436m, -7.9964m, 41.6236m,13.76m,35.86m) },
            };
    }
}
