using FluentAssertions;
using RomanNumeralsApp;
using Xunit;

namespace RomanNumeralsTests
{
    public class NewTest
    {
        // [InlineData("IV", 4)]
        // [InlineData("IX", 9)]
        // [InlineData("XL", 40)]
        // [InlineData("XC", 90)]
        // [InlineData("CD", 400)]
        // [InlineData("CM", 900)]
        // public void Should_ReturnValueIfMultipleCharacterRomanNumeralPassed(string romanNumeral, int value)
        // {
        //     int number = RomanNumeral.(romanNumeral);
        //
        //     number.Should().Be(value);
        // }

        [Fact]
        public void Test()
        {
            int number = RomanNumeral.Convert("IV");

            number.Should().Be(4);


        }
        
    }
}