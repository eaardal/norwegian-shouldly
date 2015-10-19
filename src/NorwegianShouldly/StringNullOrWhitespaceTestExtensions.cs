using System;
using Shouldly;

namespace NorwegianShouldly
{
    //
    //  Translates StringNullOrWhitespaceTestExtensions.cs in the Shouldly codebase
    //

    public static class StringNullOrWhitespaceTestExtensions
    {
        public static void SkalVæreNullEllerMellomrom(this string faktisk)
        {
            SkalVæreNullEllerMellomrom(faktisk, () => null);
        }

        public static void SkalVæreNullEllerMellomrom(this string faktisk, string egendefinertMelding)
        {
            SkalVæreNullEllerMellomrom(faktisk, () => egendefinertMelding);
        }

        public static void SkalVæreNullEllerMellomrom(this string faktisk, Func<string> egendefinertMelding)
        {
            faktisk.ShouldBeNullOrWhiteSpace(egendefinertMelding);
        }

        public static void SkalIkkeVæreNullEllerMellomrom(this string faktisk)
        {
            SkalIkkeVæreNullEllerMellomrom(faktisk, () => null);
        }

        public static void SkalIkkeVæreNullEllerMellomrom(this string faktisk, string egendefinertMelding)
        {
            SkalIkkeVæreNullEllerMellomrom(faktisk, () => egendefinertMelding);
        }

        public static void SkalIkkeVæreNullEllerMellomrom(this string faktisk, Func<string> egendefinertMelding)
        {
            faktisk.ShouldNotBeNullOrWhiteSpace(egendefinertMelding);
        }
    }
}
