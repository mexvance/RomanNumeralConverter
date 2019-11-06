using RomanNumeralConverter.Resources;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class RomanNumeralToTextConverter
{
    RomanNumeralDictionaries dictionaries = new RomanNumeralDictionaries();
    public RomanNumeralToTextConverter()
	{
        
	}
    public int ConvertSingleRomanNumeralToNumber(string romanNumeral)
    {
        int romanValue = 0;
        dictionaries.singleItemDict.TryGetValue(romanNumeral, out romanValue);
        return romanValue;
    }
    public int CalculateTotalRomanNumeralNumber(string romanNumeralString)
    {
        var romanValue = 0;
        for (int i = 0; i < romanNumeralString.Length; i++)
        {
            var value = 0;
            if (i + 1 < romanNumeralString.Length)
            {
                string romanDoubleValues = romanNumeralString.Substring(i, 2);
                value = ConvertMultiRomanNumeralToNumber(romanDoubleValues);
                romanValue += value;
                if (value > 0 )
                {
                    i++;
                }
            }
            romanValue += value == 0 ? ConvertSingleRomanNumeralToNumber(romanNumeralString.Substring(i, 1)) : 0;
        }
        return romanValue;
    }
    public int ConvertMultiRomanNumeralToNumber(string romanNumeral)
    {
        int romanValue = 0;
        dictionaries.multiItemDict.TryGetValue(romanNumeral, out romanValue);
        return romanValue;
    }
    public bool IsStringValidRomanNumeralInput(string romanNumeralString)
    {
        bool val = Regex.IsMatch(romanNumeralString, "^[IVXLCDM]*$");
        return val;
    }

}
