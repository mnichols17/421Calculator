using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathOperations;
using System;
using System.Collections.Generic;
using System.Text;

namespace MathOperations.Tests
{
    [TestClass()]
    public class MathOperationsTests
    {
        [TestMethod()]
        public void SumTest()
        {
            Assert.AreEqual(7, Addition.Sum(4, 3));
        }

        [TestMethod()]
        public void DifferenceTest()
        {
            Assert.AreEqual(1, Subtraction.Difference(4, 3));
        }

        [TestMethod()]
        public void ProductTest()
        {
            Assert.AreEqual(12, Multiplication.Product(4, 3));
        }

        [TestMethod()]
        public void QuotientTest()
        {
            Assert.AreEqual(4, Division.Quotient(12, 3));
        }

        [TestMethod()]
        public void PowerTest()
        {
            Assert.AreEqual(64, Exponentiation.Power(8, 2));
        }

        [TestMethod()]
        public void RootAnsTest()
        {
            Assert.AreEqual(4, Root.rootAns(16, 2));
        }

        [TestMethod()]
        public void LogTest()
        {
            Assert.AreEqual(2, Logarithm.Log(10, 100));
        }
    }
}