using System;
using Shouldly;

namespace NorwegianShouldly
{
    //
    //  Translates StringNullOrEmptyTestExtensions.cs in the Shouldly codebase
    //

    public static class StringNullOrEmptyTestExtensions
    {
        public static void SkalVæreNullEllerTom(this string faktisk)
        {
            SkalVæreNullEllerTom(faktisk, () => null);
        }

        public static void SkalVæreNullEllerTom(this string faktisk, string egendefinertMelding)
        {
            SkalVæreNullEllerTom(faktisk, () => egendefinertMelding);
        }

        public static void SkalVæreNullEllerTom(this string faktisk, Func<string> egendefinertMelding)
        {
            faktisk.ShouldBeNullOrEmpty(egendefinertMelding);
        }

        public static void SkalIkkeVæreNullEllerTom(this string faktisk)
        {
            SkalIkkeVæreNullEllerTom(faktisk, () => null);
        }

        public static void SkalIkkeVæreNullEllerTom(this string faktisk, string egendefinertMelding)
        {
            SkalIkkeVæreNullEllerTom(faktisk, () => egendefinertMelding);
        }

        public static void SkalIkkeVæreNullEllerTom(this string faktisk, Func<string> egendefinertMelding)
        {
            faktisk.ShouldNotBeNullOrEmpty(egendefinertMelding);
        }
    }
}
