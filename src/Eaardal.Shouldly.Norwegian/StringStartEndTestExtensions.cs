using System;
using Shouldly;

namespace Eaardal.Shouldly.Norwegian
{
    //
    //  Translates StringStartEndTestExtensions.cs in the Shouldly codebase
    //

    public static class StringStartEndTestExtensions
    {
        public static void SkalStarteMed(this string faktisk, string forventet)
        {
            SkalStarteMed(faktisk, forventet, () => null);
        }

        public static void SkalStarteMed(this string faktisk, string forventet, Case caseSensitivity)
        {
            SkalStarteMed(faktisk, forventet, () => null, caseSensitivity);
        }

        public static void SkalStarteMed(this string faktisk, string forventet, string egendefinertMelding, Case caseSensitivity = Case.Insensitive)
        {
            SkalStarteMed(faktisk, forventet, () => egendefinertMelding, caseSensitivity);
        }

        public static void SkalStarteMed(this string faktisk, string forventet, Func<string> egendefinertMelding, Case caseSensitivity = Case.Insensitive)
        {
            faktisk.ShouldStartWith(forventet, egendefinertMelding, caseSensitivity);
        }
        
        public static void SkalSlutteMed(this string faktisk, string forventet)
        {
            SkalSlutteMed(faktisk, forventet, () => null);
        }

        public static void SkalSlutteMed(this string faktisk, string forventet, Case caseSensitivity)
        {
            SkalSlutteMed(faktisk, forventet, () => null, caseSensitivity);
        }

        public static void SkalSlutteMed(this string faktisk, string forventet, string egendefinertMelding, Case caseSensitivity = Case.Insensitive)
        {
            SkalSlutteMed(faktisk, forventet, () => egendefinertMelding, caseSensitivity);
        }

        public static void SkalSlutteMed(this string faktisk, string forventet, Func<string> egendefinertMelding, Case caseSensitivity = Case.Insensitive)
        {
            faktisk.ShouldEndWith(forventet, egendefinertMelding, caseSensitivity);
        }

        public static void SkalIkkeStarteMed(this string faktisk, string forventet)
        {
            SkalIkkeStarteMed(faktisk, forventet, () => null);
        }
        public static void SkalIkkeStarteMed(this string faktisk, string forventet, Case caseSensitivity)
        {
            SkalIkkeStarteMed(faktisk, forventet, () => null, caseSensitivity);
        }

        public static void SkalIkkeStarteMed(this string faktisk, string forventet, string egendefinertMelding, Case caseSensitivity = Case.Insensitive)
        {
            SkalIkkeStarteMed(faktisk, forventet, () => egendefinertMelding, caseSensitivity);
        }

        public static void SkalIkkeStarteMed(this string faktisk, string forventet, Func<string> egendefinertMelding, Case caseSensitivity = Case.Insensitive)
        {
            faktisk.ShouldNotStartWith(forventet, egendefinertMelding, caseSensitivity);
        }
        
        public static void SkalIkkeSlutteMed(this string faktisk, string forventet)
        {
            SkalIkkeSlutteMed(faktisk, forventet, () => null);
        }
        public static void SkalIkkeSlutteMed(this string faktisk, string forventet, Case caseSensitivity)
        {
            SkalIkkeSlutteMed(faktisk, forventet, () => null, caseSensitivity);
        }

        public static void SkalIkkeSlutteMed(this string faktisk, string forventet, string egendefinertMelding, Case caseSensitivity = Case.Insensitive)
        {
            SkalIkkeSlutteMed(faktisk, forventet, () => egendefinertMelding, caseSensitivity);
        }

        public static void SkalIkkeSlutteMed(this string faktisk, string forventet, Func<string> egendefinertMelding, Case caseSensitivity = Case.Insensitive)
        {
            faktisk.ShouldNotEndWith(forventet, egendefinertMelding, caseSensitivity);
        }
    }
}
