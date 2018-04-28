using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Adding_2_And_2_Should_Return_4()
        {
            var calculator = new Calculator();

            var result = calculator.Add(2, 2);

            Assert.AreEqual<int>(4, result);
        }
    }
}
