using System;
using Shouldly;

namespace Eaardal.Shouldly.Norwegian
{
    //
    //  Translates StringContainsTestExtensions.cs in the Shouldly codebase
    //

    public static class StringContainsTestExtensions
    {
        public static void SkalInneholdeUtenMellomrom(this string faktisk, object forventet)
        {
            SkalInneholdeUtenMellomrom(faktisk, forventet, () => null);
        }

        public static void SkalInneholdeUtenMellomrom(this string faktisk, object forventet, string egendefinertMelding)
        {
            SkalInneholdeUtenMellomrom(faktisk, forventet, () => egendefinertMelding);
        }

        public static void SkalInneholdeUtenMellomrom(this string faktisk, object forventet, Func<string> egendefinertMelding)
        {
            faktisk.ShouldContainWithoutWhitespace(forventet, egendefinertMelding);
        }

        public static void SkalInneholde(this string faktisk, string forventet)
        {
            SkalInneholde(faktisk, forventet, () => null, Case.Insensitive);
        }

        public static void SkalInneholde(this string faktisk, string forventet, Case caseSensitivity)
        {
            SkalInneholde(faktisk, forventet, () => null, caseSensitivity);
        }

        public static void SkalInneholde(this string faktisk, string forventet, string egendefinertMelding)
        {
            SkalInneholde(faktisk, forventet, () => egendefinertMelding, Case.Insensitive);
        }

        public static void SkalInneholde(this string faktisk, string forventet, string egendefinertMelding, Case caseSensitivity)
        {
            SkalInneholde(faktisk, forventet, () => egendefinertMelding, caseSensitivity);
        }

        public static void SkalInneholde(this string faktisk, string forventet, Func<string> egendefinertMelding)
        {
            SkalInneholde(faktisk, forventet, egendefinertMelding, Case.Insensitive);
        }

        public static void SkalInneholde(this string faktisk, string forventet, Func<string> egendefinertMelding, Case caseSensitivity)
        {
            faktisk.ShouldContain(forventet, egendefinertMelding, caseSensitivity);
        }

        public static void SkalIkkeInneholde(this string faktisk, string forventet)
        {
            SkalIkkeInneholde(faktisk, forventet, () => null, Case.Insensitive);
        }

        public static void SkalIkkeInneholde(this string faktisk, string forventet, Case caseSensitivity)
        {
            SkalIkkeInneholde(faktisk, forventet, () => null, caseSensitivity);
        }

        public static void SkalIkkeInneholde(this string faktisk, string forventet, string egendefinertMelding)
        {
            SkalIkkeInneholde(faktisk, forventet, () => egendefinertMelding, Case.Insensitive);
        }

        public static void SkalIkkeInneholde(this string faktisk, string forventet, string egendefinertMelding, Case caseSensitivity)
        {
            SkalIkkeInneholde(faktisk, forventet, () => egendefinertMelding, caseSensitivity);
        }

        public static void SkalIkkeInneholde(this string faktisk, string forventet, Func<string> egendefinertMelding)
        {
            SkalIkkeInneholde(faktisk, forventet, egendefinertMelding, Case.Insensitive);
        }

        public static void SkalIkkeInneholde(this string faktisk, string forventet, Func<string> egendefinertMelding, Case caseSensitivity)
        {
            faktisk.ShouldNotContain(forventet, egendefinertMelding, caseSensitivity);
        }

        public static void SkalSamsvare(this string faktisk, string regexMønster)
        {
            SkalSamsvare(faktisk, regexMønster, () => null);
        }

        public static void SkalSamsvare(this string faktisk, string regexMønster, string egendefinertMelding)
        {
            SkalSamsvare(faktisk, regexMønster, () => egendefinertMelding);
        }

        public static void SkalSamsvare(this string faktisk, string regexMønster, Func<string> egendefinertMelding)
        {
            faktisk.ShouldMatch(regexMønster, egendefinertMelding);
        }
    }
}
