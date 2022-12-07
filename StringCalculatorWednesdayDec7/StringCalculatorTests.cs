
namespace StringCalculator;

public class StringCalculatorTests
{
    [Fact]
    public void EmptyStringReturnsZero(string numbers, int expected)
    {
        var calculator = new StringCalculator();

        var result = calculator.Add(numbers);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1, 1", 2)]
    [InlineData("1, 2", 3)]
    [InlineData("8, 9", 17)]
    [InlineData("12, 8", 20)]
    [InlineData("100, 42", 142)]
    public void TwoDigits(string numbers, int expected)
    {
        var calculator = new StringCalculator();

        var result = calculator.Add(numbers);
        
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1,2,3", 6)]

    public void ArbitraryNumbers(string numbers, int expected)
    {
        var calculator = new StringCalculator();

        var result = calculator.Add(numbers);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1\n2\n3", 6)]
    [InlineData("100\n200\n8", 308)]

    public void MixedDelimeters(string numbers, int expected)
    {
        var calculator = new StringCalculator();

        var result = calculator.Add(numbers);

        Assert.Equal(expected, result);
    }
}
