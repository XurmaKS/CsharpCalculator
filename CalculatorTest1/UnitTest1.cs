using System;
using Calculator2._0;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTest1
{
    [TestClass]
    public class CalculatorMathOperationTests
    {
        [TestMethod]
        public void MathOperationAdditionTest()
        {
            NumberForCalculate numberForTest = new NumberForCalculate();
            numberForTest.OneNumber = 7.9;
            numberForTest.TwoNumber = 8.25;
            double expected  = 16.15;
            MathOperation testoperation = new MathOperation();

            double actual  = testoperation.Addition(numberForTest);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void MathOperationSubtractionTest()
        {
            NumberForCalculate numberForTest = new NumberForCalculate();
            numberForTest.OneNumber = 7;
            numberForTest.TwoNumber = 381;
            double expected  = -374;
            MathOperation testoperation = new MathOperation();

            double actual = testoperation.Subtraction(numberForTest);

            Assert.AreEqual(expected , actual);
        }

        [TestMethod]
        public void MathOperationMultiplicationTest()
        {
            NumberForCalculate numberForTest = new NumberForCalculate();
            numberForTest.OneNumber = 7.5;
            numberForTest.TwoNumber = -3;
            double expected = -22.5;
            MathOperation testoperation = new MathOperation();

            double actual = testoperation.Multiplication(numberForTest);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MathOperationDivisionTest()
        {
            NumberForCalculate numberForTestDivision = new NumberForCalculate();
            numberForTestDivision.OneNumber = 171;
            numberForTestDivision.TwoNumber = 45;
            double expected = 3.8;
            MathOperation testoperation = new MathOperation();

            double actual = testoperation.Division(numberForTestDivision);

            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void MathOperationDivisionWhenZeroTest()
        {
            NumberForCalculate numberForTest = new NumberForCalculate();
            numberForTest.OneNumber = 171;
            numberForTest.TwoNumber = 0;
           MathOperation testoperation = new MathOperation();

            Assert.ThrowsException<System.Exception>(() => testoperation.Division(numberForTest));
            
        }
    }
}