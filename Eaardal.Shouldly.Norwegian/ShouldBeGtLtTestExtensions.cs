using System;
using Shouldly;

namespace Eaardal.Shouldly.Norwegian
{
    //
    //  Translates ShouldBeGtLtTestExtensions.cs in the Shouldly codebase
    //

    public static class ShouldBeGtLtTestExtensions
    {
        public static void SkalVæreStørreEnn<T>(this T faktisk, T forventet) where T : IComparable<T>
        {
            SkalVæreStørreEnn(faktisk, forventet, () => null);
        }

        public static void SkalVæreStørreEnn<T>(this T faktisk, T forventet, string customMessage) where T : IComparable<T>
        {
            SkalVæreStørreEnn(faktisk, forventet, () => customMessage);
        }

        public static void SkalVæreStørreEnn<T>(this T faktisk, T forventet, Func<string> customMessage) where T : IComparable<T>
        {
            faktisk.ShouldBeGreaterThan(forventet, customMessage);
        }

        public static void SkalVæreMindreEnn<T>(this T faktisk, T forventet) where T : IComparable<T>
        {
            SkalVæreMindreEnn(faktisk, forventet, () => null);
        }

        public static void SkalVæreMindreEnn<T>(this T faktisk, T forventet, string customMessage) where T : IComparable<T>
        {
            SkalVæreMindreEnn(faktisk, forventet, () => customMessage);
        }

        public static void SkalVæreMindreEnn<T>(this T faktisk, T forventet, Func<string> customMessage) where T : IComparable<T>
        {
            faktisk.ShouldBeLessThan(forventet, customMessage);
        }

        public static void SkalVæreStørreEllerLik<T>(this T faktisk, T forventet) where T : IComparable<T>
        {
            SkalVæreStørreEllerLik(faktisk, forventet, () => null);
        }

        public static void SkalVæreStørreEllerLik<T>(this T faktisk, T forventet, string customMessage) where T : IComparable<T>
        {
            SkalVæreStørreEllerLik(faktisk, forventet, () => customMessage);
        }

        public static void SkalVæreStørreEllerLik<T>(this T faktisk, T forventet, Func<string> customMessage) where T : IComparable<T>
        {
            faktisk.ShouldBeGreaterThanOrEqualTo(forventet, customMessage);
        }

        public static void SkalVæreMindreEllerLik<T>(this T faktisk, T forventet) where T : IComparable<T>
        {
            SkalVæreMindreEllerLik(faktisk, forventet, () => null);
        }

        public static void SkalVæreMindreEllerLik<T>(this T faktisk, T forventet, string customMessage) where T : IComparable<T>
        {
            SkalVæreMindreEllerLik(faktisk, forventet, () => customMessage);
        }

        public static void SkalVæreMindreEllerLik<T>(this T faktisk, T forventet, Func<string> customMessage) where T : IComparable<T>
        {
            faktisk.ShouldBeLessThanOrEqualTo(forventet, customMessage);
        }
    }
}
