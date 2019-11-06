using NUnit.Framework;

namespace RomanNumeralConverterTest
{
    public class Tests
    {
        RomanNumeralToTextConverter RomanNumeralConverter= new RomanNumeralToTextConverter();
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void RegularRomanNumeralAddition()
        {
            int answer = 0;
            Assert.AreEqual(8, answer);
        }

        [TestCase("I", 1)]
        [TestCase("V", 5)]
        [TestCase("X", 10)]
        [TestCase("L", 50)]
        [TestCase("C", 100)]
        [TestCase("D", 500)]
        [TestCase("M", 1000)]
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
        public void RomanNumeralSubtractionTests(string romanNumeral, int convertedValue)
        {
            var answer = RomanNumeralConverter.ConvertMultiRomanNumeralToNumber(romanNumeral);
            Assert.AreEqual(convertedValue, answer);
        }
    }
}