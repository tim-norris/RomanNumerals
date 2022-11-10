namespace Katas.RomanNumerals.Tests;

public class RomanNumeralsTests
{
    [Fact]
    public void ShouldStartWithOneMIfNumberHas4DigitsAndFirstDigitIsAOne()
    {
        var inputNumber = 1000;
        var expected = "M";

        var actual = RomanNumeralConverter.Convert(inputNumber);

        Assert.Equal(expected, actual);
        
    }
}