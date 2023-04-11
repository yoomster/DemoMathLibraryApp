using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMathLibrary.Test
{
    public class MathOperationsTest
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(10, 5, 15)]
        [InlineData(10, 10, 20)]
        [InlineData(29, 32, 61)]

        public void MathOperationsShouldAdd(int x, int y, int expected)
        {
            //Arrange
            MathOperations MathOpperationAdding = new MathOperations();

            //Act
            int actual = MathOpperationAdding.Add(x, y);

            //Assert
            Assert.Equal (expected, actual);
        }

        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(12, 7, 5)]
        [InlineData(50, 25, 25)]
        [InlineData(100, 18, 82)]
        public void MathOperationShouldSubtract(int x, int y, int expected)
        {
            //Arrange
            MathOperations MathOpperationExtracting = new MathOperations();

            //Act
            int actual = MathOpperationExtracting.Subtract(x, y);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 1, 2)]
        [InlineData(10, 4, 40)]
        [InlineData(3, 3, 9)]
        [InlineData(6, 60, 360)]
        public void MathOperationShouldMultiply(int x, int y, int expected)
        {
            //Arrange
            MathOperations multiply = new MathOperations();

            //Act
            int actual = multiply.Multiply(x, y);
            
            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(3, 3, 1)]
        [InlineData(9, 3, 3)]

        public void MathOperationShouldDivide (float x, float y, float expected)
        {
            //Arrange
            MathOperations divide = new MathOperations ();

            //Act
            float actual = divide.Divide(x, y);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
