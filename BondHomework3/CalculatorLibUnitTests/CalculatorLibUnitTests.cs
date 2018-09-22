using System;
using Xunit;

namespace CalculatorLibUnitTests
{
    public class CalculatorLibUnitTests
    {
        [Fact]
        public void TestAdd2And2()
        {
            double a = 2;
            double b = 2;
            double expected = 4;
            var calc = new CalculatorLib.Calculator();
            double actual = calc.Add(a, b);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestAdd2And3()
        {
            double a = 2;
            double b = 3;
            double expected = 5;
            var calc = new CalculatorLib.Calculator();
            double actual = calc.Add(a, b);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestSub2And2()
        {
            double a = 2;
            double b = 2;
            double expected = 0;
            var calc = new CalculatorLib.Calculator();
            double actual = calc.Sub(a, b);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestSub2And3()
        {
            double a = 2;
            double b = 3;
            double expected = -1;
            var calc = new CalculatorLib.Calculator();
            double actual = calc.Sub(a, b);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMul2And2()
        {
            double a = 2;
            double b = 2;
            double expected = 4;
            var calc = new CalculatorLib.Calculator();
            double actual = calc.Mul(a, b);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMul2And3()
        {
            double a = 2;
            double b = 3;
            double expected = 6;
            var calc = new CalculatorLib.Calculator();
            double actual = calc.Mul(a, b);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestDiv2And2()
        {
            double a = 2;
            double b = 2;
            double expected = 1;
            var calc = new CalculatorLib.Calculator();
            double actual = calc.Div(a, b);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestDiv2And3()
        {
            double a = 2;
            double b = 3;
            double expected = (double)2 / (double)3;
            var calc = new CalculatorLib.Calculator();
            double actual = calc.Div(a, b);
            Assert.Equal(expected, actual);
        }
    }
}
