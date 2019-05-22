using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class CalculatorEngineTest
    {
        private readonly CalculatorEngine _calculatorEngine = new CalculatorEngine();

        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultForNonSymbolOperation()
        {
            double number1 = 1;
            double number2 = 2;
            double result = _calculatorEngine.Calculate("add", number1, number2);
            Assert.AreEqual(3, result);

        }

        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultForSymbolOperation()
        {
            double number1 = 1;
            double number2 = 2;
            double result = _calculatorEngine.Calculate("+", number1, number2);
            Assert.AreEqual(3, result);

        }

        [TestMethod]
        public void SubtractsTwoNumbersAndReturnsValidResultForSymbolOperation()
        {
            double number1 = 5;
            double number2 = 2;
            double result = _calculatorEngine.Calculate("-", number1, number2);
            Assert.AreEqual(3, result);

        }

        [TestMethod]
        public void SubtractsTwoNumbersAndReturnsValidResultForNonSymbolOperation()
        {
            double number1 = 5;
            double number2 = 2;
            double result = _calculatorEngine.Calculate("subtract", number1, number2);
            Assert.AreEqual(3, result);

        }

        [TestMethod]
        public void MultipliesTwoNumbersAndReturnsValidResultForSymbolOperation()
        {
            double number1 = 5;
            double number2 = 2;
            double result = _calculatorEngine.Calculate("*", number1, number2);
            Assert.AreEqual(10, result);

        }

        [TestMethod]
        public void MultipliesTwoNumbersAndReturnsValidResultForNonSymbolOperation()
        {
            double number1 = 5;
            double number2 = 2;
            double result = _calculatorEngine.Calculate("multiply", number1, number2);
            Assert.AreEqual(10, result);

        }

        [TestMethod]
        public void DividesTwoNumbersAndReturnsValidResultForSymbolOperation()
        {
            double number1 = 5;
            double number2 = 2;
            double result = _calculatorEngine.Calculate("/", number1, number2);
            Assert.AreEqual(2.5, result);

        }

        [TestMethod]
        public void DividesTwoNumbersAndReturnsValidResultForNonSymbolOperation()
        {
            double number1 = 5;
            double number2 = 2;
            double result = _calculatorEngine.Calculate("divide", number1, number2);
            Assert.AreEqual(2.5, result);

        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void FailsToProcessUnrecognizedOperation()
        {
            double number1 = 1;
            double number2 = 2;
            double result = _calculatorEngine.Calculate("unrecognised", number1, number2);
            
        }
    }
}
