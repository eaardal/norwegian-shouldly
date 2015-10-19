using System;
using Shouldly;

namespace NorwegianShouldly
{
    //
    //  Translates StringShouldBeTestExtensions.cs in the Shouldly codebase
    //

    public static class StringShouldBeTestExtensions
    {
        public static void SkalVære(this string faktisk, string forventet)
        {
            SkalVære(faktisk, forventet, Case.Sensitive, () => null);
        }
        
        public static void SkalVære(this string faktisk, string forventet, Case caseSensitivity)
        {
            SkalVære(faktisk, forventet, caseSensitivity, () => null);
        }

        public static void SkalVære(this string faktisk, string forventet, Case caseSensitivity, string egendefinertMelding)
        {
            SkalVære(faktisk, forventet, caseSensitivity, () => egendefinertMelding);
        }

        public static void SkalVære(this string faktisk, string forventet, Case caseSensitivity, Func<string> egendefinertMelding)
        {
            faktisk.ShouldBe(forventet, caseSensitivity, egendefinertMelding);
        }
    }
}
