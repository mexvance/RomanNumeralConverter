using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumeralConverter.Resources
{
    public class RomanNumeralDictionaries
    {
        public IDictionary<string, int> singleItemDict = new Dictionary<string, int>() {
        { "I", 1 },
        { "V", 5 },
        { "X", 10 },
        { "L", 50 },
        { "C", 100 },
        { "D", 500 },
        { "M", 1000 }
    };
        public IDictionary<string, int> multiItemDict = new Dictionary<string, int>() {
        { "IV", 4 },
        { "IX", 9 },
        { "XL", 40 },
        { "XC", 90 },
        { "CD", 400 },
        { "CM", 900 }
    };
    }
}
