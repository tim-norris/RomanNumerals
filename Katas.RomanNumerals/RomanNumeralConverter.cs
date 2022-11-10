namespace Katas.RomanNumerals;
public static class RomanNumeralConverter
{
    public static string Convert(int inputNumber)
    {
        var inputNumberAsString = inputNumber.ToString();
        if (inputNumberAsString.Length != 4)
            return String.Empty;

        var firstDigit = inputNumber.ToString().Substring(0, 1);
        if (firstDigit == "1")
            return "M";
        else if (firstDigit == "2")
            return "MM";
        else if (firstDigit == "3")
            return "MMM";
        else
            return String.Empty;

    }

}
