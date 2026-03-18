using Xunit;
using MyApp;

namespace MyApp.Tests;

public class CalculatorTests
{
    [Fact]
    public void Add_TwoNumbers_ReturnsCorrectSum()
    {
        // Arrange
        var calc = new Calculator();

        // Act
        int result = calc.Add(2,3);

        // Assert
        Assert.Equal(5, result);
    }
}