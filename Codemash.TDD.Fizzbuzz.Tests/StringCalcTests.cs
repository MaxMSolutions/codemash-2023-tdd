using Xunit;
using Codemash.TDD.Fizzbuzz;
using System;

namespace Fizzbuzz.Tests
{
    public class StringCalcTests
    {
        [Fact]
        public void StringCalculatorShouldReturnEmptyStringForNullOrEmpty()
        {
            var calculator = new StringKataCalculator();
            var result1 = calculator.Add("");
            var result2 = calculator.Add(null);
            var result3 = calculator.Add("0");

            Assert.Equal(0, result1);
            Assert.Equal(0, result2);
            Assert.Equal(0, result3);
        }

        [Fact]
        public void StringCalculatorShouldReturnValueIfOneNumber()
        {
            var calculator = new StringKataCalculator();
            var result1 = calculator.Add("1");
            var result2 = calculator.Add("2");
            var result3 = calculator.Add("3");

            Assert.Equal(1, result1);
            Assert.Equal(2, result2);
            Assert.Equal(3, result3);
            Assert.Throws<ArgumentException>(() => calculator.Add(".11"));
            Assert.Throws<ArgumentException>(() => calculator.Add("xyz"));
            Assert.Throws<ArgumentException>(() => calculator.Add("30000000000000000000"));
        }

        [Fact]
        public void StringCalculatorShouldSumValuesIfMoreThanOneValue()
        {
            var calculator = new StringKataCalculator();
            var result1 = calculator.Add("1,1,1");
            var result2 = calculator.Add("2,2,2");
            var result3 = calculator.Add("3,3,3,3,3");

            Assert.Equal(3, result1);
            Assert.Equal(6, result2);
            Assert.Equal(15, result3);
            Assert.Throws<ArgumentException>(() => calculator.Add(".1,10,0.000"));
            Assert.Throws<ArgumentException>(() => calculator.Add("one,two,three"));
            Assert.Throws<ArgumentException>(() => calculator.Add("30000000000000000000,1,-99"));
        }

        [Fact]
        public void StringCalculatorShouldSupportMultipleDelimiters()
        {
            var calculator = new StringKataCalculator();
            var result1 = calculator.Add($"1{Environment.NewLine}1", Environment.NewLine);
            var result2 = calculator.Add($"2{Environment.NewLine}2{Environment.NewLine}2", Environment.NewLine);
            var result3 = calculator.Add($"3{Environment.NewLine}3{Environment.NewLine}3{Environment.NewLine}3", Environment.NewLine);

            Assert.Equal(2, result1);
            Assert.Equal(6, result2);
            Assert.Equal(12, result3);
            Assert.Throws<ArgumentException>(() => calculator.Add($"2{Environment.NewLine}two{Environment.NewLine}2"));
        }

        [Fact]
        public void StringCalculatorShouldThrowIfNegative()
        {
            var calculator = new StringKataCalculator();

            Assert.Throws<ArgumentException>(() => calculator.Add("-1"));
            Assert.Throws<ArgumentException>(() => calculator.Add("-1, 1"));
            Assert.Throws<ArgumentException>(() => calculator.Add("-1, -1, -1"));
        }

        [Fact]
        public void StringCalculatorShouldIncrementGetCalledCount()
        {
            var calculator = new StringKataCalculator();
            Assert.Equal(0, calculator.GetCalledCount);

            calculator.Add("1,1,1");
            Assert.Equal(1, calculator.GetCalledCount);

            calculator.Add("2,2,2");
            Assert.Equal(2, calculator.GetCalledCount);

            calculator.Add("3,3,3,3,3");
            Assert.Equal(3, calculator.GetCalledCount);
        }
    }
}
