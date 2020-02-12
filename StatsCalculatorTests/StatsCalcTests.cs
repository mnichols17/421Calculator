using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatsCalculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatsCalculator.Tests
{
    [TestClass()]
    public class StatsCalcTests
    {
        [TestMethod()]
        public void MeanTest()
        {
            StatsCalc sc = new StatsCalc();
            decimal[] dataPoints = { 1M, 2M, 3M };
            Assert.AreEqual(2, sc.Mean(dataPoints));
        }
    }
}