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
            if (thousandthsDigit == "1")
                sbRomanNumerals.Append("M");
            else if (thousandthsDigit == "2")
                sbRomanNumerals.Append("MM");
            else if (thousandthsDigit == "3")
                sbRomanNumerals.Append("MMM");
        }


          
        return sbRomanNumerals.ToString();

    }

}
