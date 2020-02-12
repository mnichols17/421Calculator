using Microsoft.VisualStudio.TestTools.UnitTesting;
using basicCalculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace basicCalculator.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        Calculator calculator;

        [TestInitialize()]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [TestMethod()]
        public void AddTest()
        {
            calculator.Add(8.5M, 4);
            Assert.AreEqual(12.5M, calculator.Result);
        }

        [TestMethod()]
        public void AddArrayTest()
        {
            decimal[] arrayList = { 1M, 2M, 3M };
            calculator.Add(arrayList);
            Assert.AreEqual(6M, calculator.Result);
        }
       
        [TestMethod()]
        public void SubtractTest()
        {
            calculator.Subtract(10, 3);
            Assert.AreEqual(7, calculator.Result);
        }

        [TestMethod()]
        public void SubtractArrayTest()
        {
            decimal[] arrayList = { 10M, 2M, 1M };
            calculator.Subtract(arrayList);
            Assert.AreEqual(7M, calculator.Result);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            calculator.Multiply(10, 3);
            Assert.AreEqual(30, calculator.Result);
        }

        [TestMethod()]
        public void MultiplyArrayTest() // Works to an extent with decimals
        {
            int[] arrayList = { 100, 2, 4 };
            calculator.Multiply(arrayList);
            Assert.AreEqual(800, calculator.Result);
        }

        [TestMethod()]
        public void DivideTest()
        {
            calculator.Divide(12, 3);
            Assert.AreEqual(4, calculator.Result);
        }

        [TestMethod()]
        public void DivideArrayTest() // Works to an extent with decimals
        {
            int[] arrayList = { 40, 2, 2 };
            calculator.Divide(arrayList);
            Assert.AreEqual(10, calculator.Result);
        }

        [TestMethod()]
        public void ExponentTest()
        {
            calculator.Exponent(8, 2);
            Assert.AreEqual(64, calculator.Result);
        }

        [TestMethod()]
        public void RootTest()
        {
            calculator.Root(16, 2);
            Assert.AreEqual(4, calculator.Result);
        }

        [TestMethod()]
        public void LogTest()
        {
            calculator.Log(10, 100);
            Assert.AreEqual(2, calculator.Result);
        }
    }
}