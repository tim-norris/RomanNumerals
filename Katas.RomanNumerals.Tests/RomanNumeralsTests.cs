namespace Katas.RomanNumerals.Tests;

public class RomanNumeralsTests
{
    [Fact]
    public void ShouldStartWithMIfNumberHas4DigitsAndFirstDigitIs1()
    {
        var inputNumber = 1000;
        var expected = "M";

        var actual = RomanNumeralConverter.Convert(inputNumber);

        Assert.StartsWith(expected, actual);
        
    }

    [Fact]
    public void ShouldStartWithMMIfNumberHas4DigitsAndFirstDigitIs2()
    {
        var inputNumber = 2000;
        var expected = "MM";

        var actual = RomanNumeralConverter.Convert(inputNumber);

        Assert.StartsWith(expected, actual);

    }

    [Fact]
    public void ShouldStartWithMMMIfNumberHas4DigitsAndFirstDigitIs3()
    {
        var inputNumber = 3000;
        var expected = "MMM";

        var actual = RomanNumeralConverter.Convert(inputNumber);

        Assert.StartsWith(expected, actual);

    }

    [Fact]
    //hundreds indicator should be c if hundred digit is 1

    public void ShouldStartWithCAfterThousandConverionIfNumberHasHundredDigitOf1()
    {
        var inputNumber = 3100;
        var expected = "MMMC";

        var actual = RomanNumeralConverter.Convert(inputNumber);

        Assert.Equal(expected, actual);

    }

}