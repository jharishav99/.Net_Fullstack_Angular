using Solutionof9A;

namespace CalculatorLibrary.Tests
{
    public class CalculatorTests
    {
         private readonly Calculator _calc = new Calculator();

            [Fact]
            public void Add_SimpleValues_ReturnsSum()
            {
                // Arrange & Act
                double result = _calc.Add(10, 5);

                // Assert
                Assert.Equal(15, result);
            }

            [Fact]
            public void Subtract_EdgeCaseZero_ReturnsCorrectValue()
            {
                double result = _calc.Subtract(10, 0);
                Assert.Equal(10, result);
            }

            [Fact]
            public void Multiply_NegativeNumbers_ReturnsPositive()
            {
                double result = _calc.Multiply(-2, -5);
                Assert.Equal(10, result);
            }

            [Fact]
            public void Divide_ValidInput_ReturnsQuotient()
            {
                double result = _calc.Divide(10, 2);
                Assert.Equal(5, result);
            }

            [Fact]
            public void Divide_ByZero_ThrowsException()
            {
                // Asserting that an exception is thrown
                Assert.Throws<DivideByZeroException>(() => _calc.Divide(10, 0));
            }
        }
    }