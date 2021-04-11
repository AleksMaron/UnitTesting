using System;
using Xunit;

namespace Calculator_TEST
{
    public class FunctionalityTest
    {
        [Fact]

        public void Multiply_Result_Test()
        {
            CalculatorProgram.Calculator calculator = new CalculatorProgram.Calculator();
            Assert.Equal(9, calculator.Multiply(2, 4));
        }
    }
}
