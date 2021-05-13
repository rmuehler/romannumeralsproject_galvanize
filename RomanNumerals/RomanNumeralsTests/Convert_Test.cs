using System;
using FluentAssertions;
using RomanNumeralsApp;
using Xunit;

namespace RomanNumeralsTests
{
    public class NewTest
    {
        [Theory]
        [InlineData("IV", 4)]
        [InlineData("IX", 9)]
        [InlineData("XL", 40)]
        [InlineData("XC", 90)]
        [InlineData("CD", 400)]
        [InlineData("CM", 900)]
        public void Should_SubtractIfSecondCharacterIsGreater(string romanNumeral, int value)
        {
            int number = RomanNumeral.Convert(romanNumeral);

            number.Should().Be(value);
        }


        [Fact]
        public void Should_AddIfSecondCharacterIsLessThanFirstCharacter()
        {
            int number = RomanNumeral.Convert("iv");

            number.Should().Be(4);
        }


        [Fact]
        public void Should_ThrowAnExceptionIfNullIsPassed()
        {
            Action action = () => RomanNumeral.Convert(null);

            action.Should().Throw<NullReferenceException>();
        }

        [Theory]
        [InlineData("MMMM")]
        [InlineData("MMMMDD")]
        public void Should_ThrowAnExceptionIfMaxRomanNumeralIsHit(string romanNumeral)
        {
            Action action = () => RomanNumeral.Convert(romanNumeral);
            action.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Theory]
        [InlineData("IIX")]
        [InlineData("CDLXXXMMMDCXLVIII")]
        public void Should_ThrowAnExceptionIfMoreThanOneLowerNumberBeforeHigherNumber(string romanNumeral)
        {
            Action action = () => RomanNumeral.Convert(romanNumeral);
            action.Should().Throw<ArgumentException>();
        }
    }
}