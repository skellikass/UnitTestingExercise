using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(1, 2, 3, 6)]
        [InlineData(10, 10, 10, 30)]
        [InlineData(5, 10, 15, 30)]
        [InlineData(8, 16, 24, 48)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            Calculator challenger = new Calculator();

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual
            var actual = challenger.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 2, 8)]//Add test data <-------
        [InlineData(50, 4, 46)]
        [InlineData(3, 2, 1)]
        [InlineData(1, 0, 1)]
        [InlineData(7, 1, 6)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            Calculator challenger = new Calculator();

            //Act
            var actual = challenger.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 1, 1)]//Add test data <-------
        [InlineData(2, 2, 4)]
        [InlineData(3, 3, 9)]
        [InlineData(4, 4, 16)]
        [InlineData(5, 5, 25)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            Calculator challenger = new Calculator();

            //Act
            var actual = challenger.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 1, 10)]//Add test data <-------
        [InlineData(10, 2, 5)]
        [InlineData(18, 3, 6)]
        [InlineData(72, 6, 12)]
        [InlineData(49, 7, 7)]
        public void DivideTest(int numerator, int denominator, int expected)
        {
            //Arrange
            Calculator challenger = new Calculator();

            //Act
            var actual = challenger.Divide(numerator, denominator);

            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
