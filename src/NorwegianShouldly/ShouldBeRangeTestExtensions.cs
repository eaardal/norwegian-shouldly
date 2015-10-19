using System;
using Shouldly;

namespace NorwegianShouldly
{
    //
    //  Translates ShouldBeRangeTestExtensions.cs in the Shouldly codebase
    //

    public static class ShouldBeRangeTestExtensions
    {
        public static void SkalVæreEnAv<T>(this T faktisk, params T[] forventet)
        {
            SkalVæreEnAv(faktisk, forventet, () => null);
        }
        public static void SkalVæreEnAv<T>(this T faktisk, T[] forventet, string egendefinertMelding)
        {
            SkalVæreEnAv(faktisk, forventet, () => egendefinertMelding);
        }
        public static void SkalVæreEnAv<T>(this T faktisk, T[] forventet,  Func<string> egendefinertMelding)
        {
            faktisk.ShouldBeOneOf<T>(forventet, egendefinertMelding);
        }

        public static void SkalIkkeVæreEnAv<T>(this T faktisk, params T[] forventet)
        {
            SkalIkkeVæreEnAv(faktisk, forventet, () => null);
        }
        public static void SkalIkkeVæreEnAv<T>(this T faktisk, T[] forventet, string egendefinertMelding)
        {
            SkalIkkeVæreEnAv(faktisk, forventet, () => egendefinertMelding);
        }
        public static void SkalIkkeVæreEnAv<T>(this T faktisk, T[] forventet,  Func<string> egendefinertMelding)
        {
            faktisk.ShouldNotBeOneOf<T>(forventet, egendefinertMelding);
        }

        public static void SkalVæreInnenfor<T>(this T faktisk, T from, T to) where T : IComparable<T>
        {
            SkalVæreInnenfor(faktisk, from, to, () => null);
        }
        public static void SkalVæreInnenfor<T>(this T faktisk, T from, T to, string egendefinertMelding) where T : IComparable<T>
        {
            SkalVæreInnenfor(faktisk, from, to, () => egendefinertMelding);
        }
        public static void SkalVæreInnenfor<T>(this T faktisk, T from, T to,  Func<string> egendefinertMelding) where T : IComparable<T>
        {
            faktisk.ShouldBeInRange<T>(from, to, egendefinertMelding);
        }

        public static void SkalIkkeVæreInnenfor<T>(this T faktisk, T from, T to) where T : IComparable<T>
        {
            SkalIkkeVæreInnenfor(faktisk, from, to, () => null);
        }
        public static void SkalIkkeVæreInnenfor<T>(this T faktisk, T from, T to, string egendefinertMelding) where T : IComparable<T>
        {
            SkalIkkeVæreInnenfor(faktisk, from, to, () => egendefinertMelding);
        }
        public static void SkalIkkeVæreInnenfor<T>(this T faktisk, T from, T to,  Func<string> egendefinertMelding) where T : IComparable<T>
        {
            faktisk.ShouldNotBeInRange<T>(from, to, egendefinertMelding);
        }
    }
}
