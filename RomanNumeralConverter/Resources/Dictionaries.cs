using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumeralConverter.Resources
{
    public class Dictionaries
    {
        IDictionary<int, string> dict = new Dictionary<int, string>()
                                            {
                                                {1,"I"},
                                                {5, "V"},
                                                {10,"X"},
                                                {50,"L"},
                                                {100,"C"},
                                                {500,"D"},
                                                {1000,"M"},

                                            };
    }
}
