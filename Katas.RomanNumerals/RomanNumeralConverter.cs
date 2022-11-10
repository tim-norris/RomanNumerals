using System.Text;

namespace Katas.RomanNumerals;
public static class RomanNumeralConverter
{
    public static string Convert(int inputNumber)
    {
        var inputNumberArray = inputNumber.ToString().ToArray();
        var sbRomanNumerals = new StringBuilder();

        var thousandthsDigit = inputNumberArray.Length == 4 ? inputNumberArray[0].ToString() : null;

        if (thousandthsDigit != null)
        {
            if (thousandthsDigit == "1")
                sbRomanNumerals.Append("M");
            else if (thousandthsDigit == "2")
                sbRomanNumerals.Append("MM");
            else if (thousandthsDigit == "3")
                sbRomanNumerals.Append("MMM");
        }

        //string hundredthsDigit;

        //if(inputNumberAsString.Length > 3)
        //{
        //    hundredthsDigit = inputNumber.ToString().Substring(1, 2);
        //}
        //else
        //{
        //    hundredthsDigit = inputNumber.ToString().Substring(0, 1);
        //}


        return sbRomanNumerals.ToString();

    }

}
