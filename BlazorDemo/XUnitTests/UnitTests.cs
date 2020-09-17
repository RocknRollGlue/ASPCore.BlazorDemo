using BlazorDemo.Pages;
using Bunit;
using System;
using Xunit;

namespace XUnitTests
{
    public class UnitTests : TestContext
    {
        [Theory(DisplayName = "Add numbers")]
        [InlineData("5", "7", "12")]
        [InlineData("0", "0", "0")]
        [InlineData("-5", "-8", "-13")]

        public void AddNumbers(string numberOne, string numberTwo, string expected)
        {
            //Arrange
            CalculatorSubstitute calculatorClass = new CalculatorSubstitute();

            //Act
            var result = calculatorClass.AddNumbers(numberOne, numberTwo);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory(DisplayName = "Subtract numbers")]
        [InlineData("5", "7", "-2")]
        [InlineData("0", "0", "0")]
        [InlineData("-5", "-8", "3")]
        public void SubtractNumbers(string numberOne, string numberTwo, string expected)
        {
            //Arrange
            CalculatorSubstitute calculatorClass = new CalculatorSubstitute();

            //Act
            var result = calculatorClass.SubtractNumbers(numberOne, numberTwo);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory(DisplayName = "SquareRoot")]
        [InlineData("25", "5")]
        [InlineData("0", "0")]
        [InlineData("64", "8")]
        public void SquareRoot(string numberOne, string expected)
        {
            //Arrange
            CalculatorSubstitute calculatorClass = new CalculatorSubstitute();

            //Act
            string result = calculatorClass.SquareRoot(numberOne);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void SquareRootWithNegatives()
        {
            //Arrange
            CalculatorSubstitute calculatorClass = new CalculatorSubstitute();

            //Act
            string result = calculatorClass.SquareRoot("-5");

            //Assert
            Assert.Equal("Invalid input.", result.ToString());
        }

        [Theory(DisplayName = "Percent")]
        [InlineData("100", "10", "10")]
        [InlineData("250", "20", "50")]
        [InlineData("360", "60", "216")]
        public void Percent(string numberOne, string numberTwo, string expected)
        {
            //Arrange
            CalculatorSubstitute calculatorClass = new CalculatorSubstitute();

            //Act
            string result = calculatorClass.Percent(numberOne, numberTwo);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory(DisplayName = "Power")]
        [InlineData("10", "2", "100")]
        [InlineData("5", "3", "125")]
        [InlineData("3", "5", "243")]
        [InlineData("1", "0", "1")]
        public void Power(string numberOne, string numberTwo, string expected)
        {
            //Arrange
            CalculatorSubstitute calculatorClass = new CalculatorSubstitute();

            //Act
            string result = calculatorClass.Power(numberOne, numberTwo);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}
