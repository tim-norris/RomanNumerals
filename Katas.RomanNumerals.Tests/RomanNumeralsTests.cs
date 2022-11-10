namespace Katas.RomanNumerals.Tests;

public class RomanNumeralsTests
{
    [Fact]
    public void ShouldStartWithMIfNumberHas4DigitsAndFirstDigitIs1()
    {
        var inputNumber = 1000;
        var expected = "M";

        var actual = RomanNumeralConverter.Convert(inputNumber);

        Assert.Equal(expected, actual);
        
    }
}