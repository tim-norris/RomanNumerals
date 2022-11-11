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

        var tenthsDigit = inputNumberArray[2].ToString();
        if (tenthsDigit != "#")
        {
            var convertedTenthsDigit = ConvertTenthsDigit(tenthsDigit);
            sbRomanNumerals.Append(convertedTenthsDigit);
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
            case "5":
                converted = "D";
                break;
            case "6":
                converted = "DC";
                break;
            case "7":
                converted = "DCC";
                break;
            case "8":
                converted = "DCCC";
                break;
            case "9":
                converted = "CM";
                break;
        }

        return converted;
    }

    private static string ConvertTenthsDigit(string tenthsDigit)
    {
        var converted = string.Empty;

        switch (tenthsDigit)
        {
            case "1":
                converted = "X";
                break;
            case "2":
                converted = "XX";
                break;
            case "3":
                converted = "XXX";
                break;
            case "4":
                converted = "XL";
                break;
            case "5":
                converted = "L";
                break;
            case "6":
                converted = "LX";
                break;
            case "7":
                converted = "LXX";
                break;
            case "8":
                converted = "LXXX";
                break;
            case "9":
                converted = "XC";
                break;
        }

        return converted;
    }

}
