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
    }
}
