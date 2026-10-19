using FluentAssertions;

namespace CalculatriceLib.Tests.Unit;

public class CalculatriceTests
{
    public readonly Calculatrice _sut = new();
    
    [Theory]
    [InlineData(5, 5, 10)]
    [InlineData(-5, 5, 0)]
    [InlineData(-15, -5, -20)]
    public void Additionner_ShouldAddTwoNumbers_WhenToNumberAreIntegers(int a, int b, int expected)
    {
        //Act
        var result = _sut.Additionner(a, b);
        
        //Assert
        result.Should().Be(expected);
    }
    
    [Theory]
    [InlineData(5, 5, 0)]
    [InlineData(15, 5, 10)]
    [InlineData(-5, -5, 0)]
    [InlineData(-15, -5, -10)]
    [InlineData(5, 10, -5)]
    public void Additionner_ShouldSubtractTwoNumbers_WhenToNumberAreIntegers(int a, int b, int expected)
    {
        //Act
        var result = _sut.Soustraire(a, b);
        
        //Assert
        result.Should().Be(expected);
    }
    
    [Theory]
    [InlineData(5, 5, 25)]
    [InlineData(50, 0, 0)]
    [InlineData(-5, 5, -25)]
    public void Additionner_ShoulMultiplyTwoNumbers_WhenToNumberAreIntegers(int a, int b, int expected)
    {
        //Act
        var result = _sut.Multiplier(a, b);
        
        //Assert
        result.Should().Be(expected);
    }
    
    [Theory]
    [InlineData(5, 5, 1)]
    [InlineData(15, 5, 3)]
    [InlineData(1, 0, 2, Skip = "Ignorer un cas impossible de division par 0")]
    public void Additionner_ShoulDivideTwoNumbers_WhenToNumberAreIntegers(int a, int b, int expected)
    {
        //Act
        var result = _sut.Diviser(a, b);
        
        //Assert
        result.Should().Be(expected);
    }
}