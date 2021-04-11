using System;
using Xunit;

namespace Calculator_TEST_UTP
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            CalculatorProgram.Calculator calculator = new CalculatorProgram.Calculator();
            Assert.Equal(8, calculator.Multiply(2, 4));
        }

        [Fact]
        public void Test2()
        {
            CalculatorProgram.Calculator calculator = new CalculatorProgram.Calculator();
            Assert.Equal(2, calculator.Divide(8, 4));
        }

        [Fact]
        public void Test3()
        {
            CalculatorProgram.Calculator calculator = new CalculatorProgram.Calculator();
            Assert.Equal(12, calculator.Add(8, 4));
        }

        [Fact]
        public void Test4()
        {
            CalculatorProgram.Calculator calculator = new CalculatorProgram.Calculator();
            Assert.Equal(4, calculator.Substract(8, 4));
        }
    }
}
