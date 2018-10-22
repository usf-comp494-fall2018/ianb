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

        [Fact]
        public void TestMean1Through10()
        {
            double[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            double expected = 5.5;
            var calc = new CalculatorLib.Calculator();
            double actual = calc.Mean(arr);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMeanEvens10Through30()
        {
            double[] arr = { 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30 };
            double expected = (double)20;
            var calc = new CalculatorLib.Calculator();
            double actual = calc.Mean(arr);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMedian1Through10()
        {
            double[] arr = { 1, 10, 2, 9, 3, 8, 4, 7, 5, 6 };
            double expected = (double)5.5;
            var calc = new CalculatorLib.Calculator();
            double actual = calc.Median(arr);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMedianEvens10TThrough30()
        {
            double[] arr = { 20, 18, 22, 16, 24, 14, 26, 12, 28, 10, 30 };
            double expected = (double)20;
            var calc = new CalculatorLib.Calculator();
            double actual = calc.Median(arr);
            Assert.Equal(expected, actual);
        }
    }
}
