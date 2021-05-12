using System;

namespace RomanNumeralsApp
{
    public static class RomanNumeral
    {
        public static int ConvertRomanNumeral(string romanNumeral)
        {
            if (romanNumeral is null)
            {
                throw new NullReferenceException();
            }
            else if (romanNumeral == "I")
            {
                return 1;
            }

            return 0;
        }

        public static void Main()
        {
        }
    }
}