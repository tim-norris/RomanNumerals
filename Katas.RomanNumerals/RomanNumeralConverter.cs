using System.Text;

namespace Katas.RomanNumerals;
public static class RomanNumeralConverter
{
    public static string Convert(int inputNumber)
    {
        var inputNumberArray = inputNumber.ToString().PadLeft(4, '#').ToArray();
        var sbRomanNumerals = new StringBuilder();

        var thousandthsDigit = inputNumberArray[0].ToString();

        if (thousandthsDigit != "#")
        {
            var convertedThousandthsDigit = ConvertThousandthsDigit(thousandthsDigit);
            sbRomanNumerals.Append(convertedThousandthsDigit);

        }

        var hundredthsDigit = inputNumberArray[1].ToString();
        if (hundredthsDigit != "#")
        {
            var convertedHundredthdsDigit = ConvertHundredthsDigit(hundredthsDigit);
            sbRomanNumerals.Append(convertedHundredthdsDigit);
        }


        return sbRomanNumerals.ToString();

    }
    private static string ConvertThousandthsDigit(string thousandthsDigit)
    {

        var converted = string.Empty;

        switch (thousandthsDigit)
        {
            case "1":
                converted = "M";
                break;
            case "2":
                converted = "MM";
                break;
            case "3":
                converted = "MMM";
                break;
        }

        return converted;
    }


    private static string ConvertHundredthsDigit(string hundredthsDigit)
    {
        var converted = string.Empty;

        switch (hundredthsDigit)
        {
            case "1":
                converted = "C";
                break;
            case "2":
                converted = "CC";
                break;
            case "3":
                converted = "CCC";
                break;
            case "4":
                converted = "CD";
                break;
        }

        return converted;
    }

}
