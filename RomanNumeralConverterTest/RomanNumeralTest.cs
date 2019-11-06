using NUnit.Framework;
using System.Text.RegularExpressions;

namespace RomanNumeralConverterTest
{
    public class Tests
    {
        RomanNumeralToTextConverter RomanNumeralConverter= new RomanNumeralToTextConverter();
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("IV", 4)]
        [TestCase("VI", 6)]
        [TestCase("V", 5)]
        [TestCase("VII", 7)]
        [TestCase("XCI", 91)]
        [TestCase("CLIV", 154)]
        [TestCase("allbad yes", 0)]
        public void CalculateRomanNumeralTest(string romanNumeralString, int convertedValue)
        {
            int answer = RomanNumeralConverter.CalculateTotalRomanNumeralNumber(romanNumeralString);
            Assert.AreEqual(convertedValue, answer);
        }

        [TestCase("I", 1)]
        [TestCase("V", 5)]
        [TestCase("X", 10)]
        [TestCase("L", 50)]
        [TestCase("C", 100)]
        [TestCase("D", 500)]
        [TestCase("M", 1000)]
        [TestCase("f", 0)]
        public void SingleRomanNumeralConvertsToCorrectInteger(string romanNumeral, int convertedValue)
        {
            var answer = RomanNumeralConverter.ConvertSingleRomanNumeralToNumber(romanNumeral);
            Assert.AreEqual(convertedValue, answer);
        }
        [TestCase("IV", 4)]
        [TestCase("IX", 9)]
        [TestCase("XL", 40)]
        [TestCase("XC", 90)]
        [TestCase("CD", 400)]
        [TestCase("CM", 900)]
        [TestCase("NO", 0)]
        public void RomanNumeralSubtractionTests(string romanNumeral, int convertedValue)
        {
            var answer = RomanNumeralConverter.ConvertMultiRomanNumeralToNumber(romanNumeral);
            Assert.AreEqual(convertedValue, answer);
        }

        [TestCase("CD", true)]
        [TestCase("LVDJDKS", false)]
        [TestCase("   IV", false)]
        [TestCase("", true)]
        [TestCase("I", true)]
        [TestCase("XCDMIV", true)]
        public void TestInputIsCorrectRomanNumerals(string romanNumeralString, bool answer)
        {
            Assert.AreEqual(answer, RomanNumeralConverter.IsStringValidRomanNumeralInput(romanNumeralString));
        }
    }
}