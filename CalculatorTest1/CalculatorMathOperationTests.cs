using System;
using Calculator2._0;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTest1
{
    [TestClass]
    public class CalculatorMathOperationTests
    {
        [TestMethod]
        public void MathOperation_Addition_Test()
        {
            var numberForTest = new NumberForCalculate();
            numberForTest.OneNumber = 7.9;
            numberForTest.TwoNumber = 8.25;
            var expected = 16.15;
            var testoperation = new MathOperation();

            var actual = testoperation.Addition(numberForTest);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MathOperation_Subtraction_Test()
        {
            var numberForTest = new NumberForCalculate();
            numberForTest.OneNumber = 7;
            numberForTest.TwoNumber = 381;
            var expected = -374;
            var testoperation = new MathOperation();

            var actual = testoperation.Subtraction(numberForTest);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MathOperation_Multiplication_Test()
        {
            var numberForTest = new NumberForCalculate();
            numberForTest.OneNumber = 7.5;
            numberForTest.TwoNumber = -3;
            var expected = -22.5;
            var testoperation = new MathOperation();

            var actual = testoperation.Multiplication(numberForTest);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MathOperation_Division_Test()
        {
            var numberForTestDivision = new NumberForCalculate();
            numberForTestDivision.OneNumber = 171;
            numberForTestDivision.TwoNumber = 45;
            var expected = 3.8;
            var testoperation = new MathOperation();

            var actual = testoperation.Division(numberForTestDivision);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MathOperation_Division_WhenZero_Test()
        {
            var numberForTest = new NumberForCalculate();
            numberForTest.OneNumber = 171;
            numberForTest.TwoNumber = 0;
            var testoperation = new MathOperation();

            Assert.ThrowsException<Exception>(() => testoperation.Division(numberForTest));
        }
    }
}