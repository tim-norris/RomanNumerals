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

    [Theory]
    [InlineData(1, "M")]
    [InlineData(2, "MM")]
    [InlineData(3, "MMM")]

    public void ShouldConvertThousandthsDigitToRomanNumeralsCorrectly(int thousandthsDigit, string thousandthdsRomanNumerals)
    {
        var inputNumber = thousandthsDigit * 1000;
        var expected = thousandthdsRomanNumerals;

        var actual = RomanNumeralConverter.Convert(inputNumber);

        Assert.Equal(expected, actual);

    }

    [Fact]

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

    [Theory]
    [InlineData(1, "C")]
    [InlineData(2, "CC")]
    [InlineData(3, "CCC")]
    [InlineData(4, "CD")]
    [InlineData(5, "D")]
    [InlineData(6, "DC")]
    [InlineData(7, "DCC")]
    [InlineData(8, "DCCC")]
    [InlineData(9, "CM")]
    public void ShouldConvertHundredthsDigitToRomanNumeralsCorrectly(int hundredthsDigit, string hundredthsRomanNumerals)
    {
        var inputNumber = 3000 + (hundredthsDigit * 100);
        var expected = "MMM" + hundredthsRomanNumerals;

        var actual = RomanNumeralConverter.Convert(inputNumber);

        Assert.Equal(expected, actual);

    }

    [Theory]
    [InlineData(1, "X")]
    [InlineData(2, "XX")]
    [InlineData(3, "XXX")]
    [InlineData(4, "XL")]
    [InlineData(5, "L")]
    [InlineData(6, "LX")]
    [InlineData(7, "LXX")]
    [InlineData(8, "LXXX")]
    [InlineData(9, "XC")]
    public void ShouldConvertTenthsDigitToRomanNumeralsCorrectly(int tenthsDigit, string tenthsRomanNumerals)
    {
        var inputNumber = 3500 + (tenthsDigit * 10);
        var expected = "MMMD" + tenthsRomanNumerals;

        var actual = RomanNumeralConverter.Convert(inputNumber);

        Assert.Equal(expected, actual);

    }

    [Theory]
    [InlineData(1, "I")]
    [InlineData(2, "II")]
    [InlineData(3, "III")]
    [InlineData(4, "IV")]
    [InlineData(5, "V")]
    [InlineData(6, "VI")]
    [InlineData(7, "VII")]
    [InlineData(8, "VIII")]
    [InlineData(9, "IX")]
    public void ShouldConvertOnesDigitToRomanNumeralsCorrectly(int onesDigit, string onesRomanNumerals)
    {
        var inputNumber = 3550 + onesDigit;
        var expected = "MMMDL" + onesRomanNumerals;

        var actual = RomanNumeralConverter.Convert(inputNumber);

        Assert.Equal(expected, actual);

    }

    [Fact]
    public void ShouldConvert3497Properly()
    {
        var inputNumber = 3497;
        var expected = "MMMCDXCVII";
        
        var actual = RomanNumeralConverter.Convert(inputNumber);

        Assert.Equal(expected, actual);

    }

    [Fact]
    public void ShouldConvert497Properly()
    {
        var inputNumber = 497;
        var expected = "CDXCVII";

        var actual = RomanNumeralConverter.Convert(inputNumber);

        Assert.Equal(expected, actual);

    }

    [Fact]
    public void ShouldConvert97Properly()
    {
        var inputNumber = 97;
        var expected = "XCVII";

        var actual = RomanNumeralConverter.Convert(inputNumber);

        Assert.Equal(expected, actual);

    }

    [Fact]
    public void ShouldConvert7Properly()
    {
        var inputNumber = 7;
        var expected = "VII";

        var actual = RomanNumeralConverter.Convert(inputNumber);

        Assert.Equal(expected, actual);

    }

    [Fact]
    public void ShouldConvert0Properly()
    {
        var inputNumber = 0;
        var expected = "";

        var actual = RomanNumeralConverter.Convert(inputNumber);

        Assert.Equal(expected, actual);

    }

}