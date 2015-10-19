using System;
using Shouldly;

namespace Eaardal.Shouldly.Norwegian
{
    //
    //  Translates SkalVæreNullExtensions.cs in the Shouldly codebase
    //

    public static class NullExtensions
    {
        public static void SkalVæreNull<T>(this T faktisk)
        {
            SkalVæreNull(faktisk, () => null);
        }

        public static void SkalVæreNull<T>(this T faktisk, string egendefinertMelding)
        {
            SkalVæreNull(faktisk, () => egendefinertMelding);
        }

        public static void SkalVæreNull<T>(this T faktisk, Func<string> egendefinertMelding)
        {
            faktisk.ShouldBeNull(egendefinertMelding);
        }

        public static void SkalIkkeVæreNull<T>(this T faktisk)
        {
            SkalIkkeVæreNull(faktisk, () => null);
        }

        public static void SkalIkkeVæreNull<T>(this T faktisk, string egendefinertMelding)
        {
            SkalIkkeVæreNull(faktisk, () => egendefinertMelding);
        }

        public static void SkalIkkeVæreNull<T>(this T faktisk, Func<string> egendefinertMelding)
        {
            faktisk.ShouldNotBeNull(egendefinertMelding);
        }
    }
}
