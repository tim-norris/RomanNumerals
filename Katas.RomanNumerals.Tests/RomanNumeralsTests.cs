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

    //TODO: Add test should not start with M if number has less than 4 digits

    [Fact]
    //hundreds indicator should be c if hundred digit is 1

    public void ShouldStartWithCAfterThousandConverionIfNumberHasHundredDigitOf1()
    {
        var inputNumber = 3100;
        var expected = "MMMC";

        var actual = RomanNumeralConverter.Convert(inputNumber);

        Assert.Equal(expected, actual);

    }

    [Fact]
    public void ShouldStartWithCCAfterThousandConverionIfNumberHasHundredDigitOf2()
    {
        var inputNumber = 3200;
        var expected = "MMMCC";

        var actual = RomanNumeralConverter.Convert(inputNumber);

        Assert.Equal(expected, actual);

    }

    [Fact]
    public void ShouldStartWithCCCAfterThousandConverionIfNumberHasHundredDigitOf3()
    {
        var inputNumber = 3300;
        var expected = "MMMCCC";

        var actual = RomanNumeralConverter.Convert(inputNumber);

        Assert.Equal(expected, actual);

    }

    [Fact]
    public void ShouldStartWithCDAfterThousandConverionIfNumberHasHundredDigitOf4()
    {
        var inputNumber = 3400;
        var expected = "MMMCD";

        var actual = RomanNumeralConverter.Convert(inputNumber);

        Assert.Equal(expected, actual);

    }

    [Fact]
    public void ShouldStartWithDAfterThousandConverionIfNumberHasHundredDigitOf5()
    {
        var inputNumber = 3500;
        var expected = "MMMD";

        var actual = RomanNumeralConverter.Convert(inputNumber);

        Assert.Equal(expected, actual);

    }

    [Fact]
    public void ShouldStartWithDCAfterThousandConverionIfNumberHasHundredDigitOf6()
    {
        var inputNumber = 3600;
        var expected = "MMMDC";

        var actual = RomanNumeralConverter.Convert(inputNumber);

        Assert.Equal(expected, actual);

    }

    [Fact]
    public void ShouldStartWithDCCAfterThousandConverionIfNumberHasHundredDigitOf7()
    {
        var inputNumber = 3700;
        var expected = "MMMDCC";

        var actual = RomanNumeralConverter.Convert(inputNumber);

        Assert.Equal(expected, actual);

    }

    [Fact]
    public void ShouldStartWithDCCCAfterThousandConverionIfNumberHasHundredDigitOf8()
    {
        var inputNumber = 3800;
        var expected = "MMMDCCC";

        var actual = RomanNumeralConverter.Convert(inputNumber);

        Assert.Equal(expected, actual);

    }

    [Fact]
    public void ShouldStartWithCMAfterThousandConverionIfNumberHasHundredDigitOf9()
    {
        var inputNumber = 3900;
        var expected = "MMMCM";

        var actual = RomanNumeralConverter.Convert(inputNumber);

        Assert.Equal(expected, actual);

    }

}