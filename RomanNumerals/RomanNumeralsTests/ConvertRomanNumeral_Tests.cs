using System;
using FluentAssertions;
using RomanNumeralsApp;
using Xunit;

namespace RomanNumeralsTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("I", 1)]
        [InlineData("V", 5)]
        [InlineData("X", 10)]
        [InlineData("L", 50)]
        [InlineData("C", 100)]
        [InlineData("D", 500)]
        [InlineData("M", 1000)]
        public void Should_Return1IfRomanNumeralIIsPassed(string romanNumeral, int value)
        {
            int number = RomanNumeral.ConvertRomanNumeral(romanNumeral);

            number.Should().Be(value);
        }

        [Fact]
        public void Should_ThrowAnExceptionIfNullIsPassed()
        {
            Action action = () => RomanNumeral.ConvertRomanNumeral(null);

            action.Should().Throw<NullReferenceException>();
        }

        [Fact]
        public void Should_ValidatedIfStringPassedIsEmpty()
        {
            int number = RomanNumeral.ConvertRomanNumeral("");
            number.Should().Be(0);
        }

        [Theory]
        [InlineData("IV", 4)]
        [InlineData("IX", 9)]
        [InlineData("XL", 40)]
        [InlineData("XC", 90)]
        [InlineData("CD", 400)]
        [InlineData("CM", 900)]
        public void Should_ReturnValueIfMultipleCharacterRomanNumeralPassed(string romanNumeral, int value)
        {
            int number = RomanNumeral.ConvertRomanNumeral(romanNumeral);

            number.Should().Be(value);
        }

        [Fact]
        public void Should_ReturnValueIfRomanNumeral3_OrMoreCharacter()
        {
            int number = RomanNumeral.ConvertRomanNumeral("MMVI");

            number.Should().Be(2006);
        }
    }
}