using RomanNumeralConverter.Resources;
using System;
using System.Collections.Generic;

public class RomanNumeralToTextConverter
{
    RomanNumeralDictionaries dictionaries = new RomanNumeralDictionaries();
    public RomanNumeralToTextConverter()
	{
        
	}
    public int ConvertSingleRomanNumeralToNumber(string romanNumeral)
    {
        int romanValue = dictionaries.singleItemDict[romanNumeral];
        return romanValue;
    }
    public int FindSubtractedRomanNumeralPair(string romanNumeral)
    {
        int romanValue = dictionaries.singleItemDict[romanNumeral];
        return romanValue;
    }
    public int ConvertMultiRomanNumeralToNumber(string romanNumeral)
    {
        int romanValue = dictionaries.singleItemDict[romanNumeral];
        return romanValue;
    }

}
