using System;
using Shouldly;

namespace NorwegianShouldly
{
    //
    //  Translates ShouldBeBooleanExtensions.cs in the Shouldly codebase
    //

    public static class ShouldBeBooleanExtensions
    {
        public static void SkalVæreSant(this bool faktisk)
        {
            SkalVæreSant(faktisk, () => null);
        }

        public static void SkalVæreSant(this bool faktisk, string egendefinertMelding)
        {
            SkalVæreSant(faktisk, () => egendefinertMelding);
        }

        public static void SkalVæreSant(this bool faktisk, Func<string> egendefinertMelding)
        {
            faktisk.ShouldBeTrue(egendefinertMelding);
        }

        public static void SkalVæreUsant(this bool faktisk)
        {
            SkalVæreUsant(faktisk, () => null);
        }

        public static void SkalVæreUsant(this bool faktisk, string egendefinertMelding)
        {
            SkalVæreUsant(faktisk, () => egendefinertMelding);
        }

        public static void SkalVæreUsant(this bool faktisk, Func<string> egendefinertMelding)
        {
            faktisk.ShouldBeFalse(egendefinertMelding);
        }
    }
}
