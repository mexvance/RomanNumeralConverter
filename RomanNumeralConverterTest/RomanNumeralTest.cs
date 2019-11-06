using NUnit.Framework;

namespace RomanNumeralConverterTest
{
    public class Tests
    {
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
        public void EachRomanNumeralConvertsToCorrectInteger(string romanNumeral, int convertedValue)
        {
            int answer = 0;
            Assert.AreEqual(convertedValue, answer);
        }
    }
}