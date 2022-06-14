using System;
using Xunit;

namespace Labb3Calculator.Test
{
    public class CalculatorTest
    {

        [Fact]
        public void Addition_Using_1_Add_2_Equals_3()
        {

            // Arrange
            Calculator cal = new Calculator();

            // Act

            var actual = cal.Addition(1, 2);
            var result = 3;

            // Assert
            Assert.Equal(actual, result);

        }
        [Fact]
        public void Subtraction_Using_2_Subtract_1_Equals_1()
        {

            // Arrange
            Calculator cal = new Calculator();

            // Act

            var actual = cal.Subtraction(2 ,1);
            var result = 1;

            // Assert
            Assert.Equal(actual, result);

        }
        [Theory]
        [InlineData(6, 2,3)]
        [InlineData(4, 2,2)]
        [InlineData(8, 4,2)]
        [InlineData(60, 20,3)]
        [InlineData(-3, -2, 1.5)]
        public void Divide_Num_with_Num_and_return_positiv(double a, double b, double expected)
        {
            // Arrange
            Calculator cal = new Calculator();

            // Act

            var actual = cal.Division(a, b);
            var result = expected;

            // Assert
            Assert.Equal(actual, result);


        }
        [Theory]
        [InlineData(6, 2, 12)]
        [InlineData(1.2, 5.5, 6.6)]
        [InlineData(8, 4, 32)]
        [InlineData(60, 20, 1200)]
        [InlineData(-3, -2, 6)]
        public void Multiplication_Num_with_Num_and_return_Result(double a, double b, double expected)
        {
            // Arrange
            Calculator cal = new Calculator();

            // Act

            var actual = cal.Multiplication(a, b);
            var result = expected;

            // Assert
            Assert.Equal(actual, result);


        }
    }
}
