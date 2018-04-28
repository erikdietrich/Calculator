using System;
using System.Drawing;
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

        [TestMethod]
        public void Dividing_2_By_1_Should_Be_2()
        {
            var calculator = new Calculator();

            var result = calculator.Divide(2, 1);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Dividing_1_By_2_Should_Be_0_Point_5()
        {
            var calculator = new Calculator();

            var result = calculator.Divide(1, 2);

            Assert.AreEqual(.5M, result);
        }
    }
}
