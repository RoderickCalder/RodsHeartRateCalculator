using System;
using HeartRate;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void WhenTestingTheCalculatorReturnsValue()
        {
           var heartRates = HeartRateCalculator.CalculateHeartRate(65, 20);

            var result = (heartRates != null);

            Assert.IsTrue(result);
        }

       

    }
}
