﻿using System;
using Shouldly;

namespace Eaardal.Shouldly.Norwegian
{
    //
    //  Translates StringShouldBeTestExtensions.cs in the Shouldly codebase
    //

    public static class StringShouldBeExtensions
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
