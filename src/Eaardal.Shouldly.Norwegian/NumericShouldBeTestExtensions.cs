using System;
using System.Collections.Generic;
using Shouldly;

namespace Eaardal.Shouldly.Norwegian
{
    //
    //  Translates NumericShouldBeTestExtensions.cs in the Shouldly codebase
    //

    public static class NumericShouldBeTestExtensions
    {
        public static void SkalVære(this float faktisk, float forventet, double toleranse)
        {
            SkalVære(faktisk, forventet, toleranse, () => null);
        }

        public static void SkalVære(this float faktisk, float forventet, double toleranse, string egendefinertMelding)
        {
            SkalVære(faktisk, forventet, toleranse, () => egendefinertMelding);
        }

        public static void SkalVære(this float faktisk, float forventet, double toleranse, Func<string> egendefinertMelding)
        {
            faktisk.ShouldBe(forventet, toleranse, egendefinertMelding);
        }

        public static void SkalVære(this IEnumerable<double> faktisk, IEnumerable<double> forventet, double toleranse)
        {
            SkalVære(faktisk, forventet, toleranse, () => null);
        }

        public static void SkalVære(this IEnumerable<double> faktisk, IEnumerable<double> forventet, double toleranse, string egendefinertMelding)
        {
            SkalVære(faktisk, forventet, toleranse, () => egendefinertMelding);
        }

        public static void SkalVære(this IEnumerable<double> faktisk, IEnumerable<double> forventet, double toleranse, Func<string> egendefinertMelding)
        {
            faktisk.ShouldBe(forventet, toleranse, egendefinertMelding);
        }

        public static void SkalVære(this IEnumerable<float> faktisk, IEnumerable<float> forventet, double toleranse)
        {
            SkalVære(faktisk, forventet, toleranse, () => null);
        }

        public static void SkalVære(this IEnumerable<float> faktisk, IEnumerable<float> forventet, double toleranse, string egendefinertMelding)
        {
            SkalVære(faktisk, forventet, toleranse, () => egendefinertMelding);
        }

        public static void SkalVære(this IEnumerable<float> faktisk, IEnumerable<float> forventet, double toleranse, Func<string> egendefinertMelding)
        {
            faktisk.ShouldBe(forventet, toleranse, egendefinertMelding);
        }

        public static void SkalVære(this double faktisk, double forventet, double toleranse)
        {
            SkalVære(faktisk, forventet, toleranse, () => null);
        }

        public static void SkalVære(this double faktisk, double forventet, double toleranse, string egendefinertMelding)
        {
            SkalVære(faktisk, forventet, toleranse, () => egendefinertMelding);
        }

        public static void SkalVære(this double faktisk, double forventet, double toleranse, Func<string> egendefinertMelding)
        {
            faktisk.ShouldBe(forventet, toleranse, egendefinertMelding);
        }

        public static void SkalVære(this decimal faktisk, decimal forventet, decimal toleranse)
        {
            SkalVære(faktisk, forventet, toleranse, () => null);
        }

        public static void SkalVære(this decimal faktisk, decimal forventet, decimal toleranse, string egendefinertMelding)
        {
            SkalVære(faktisk, forventet, toleranse, () => egendefinertMelding);
        }

        public static void SkalVære(this decimal faktisk, decimal forventet, decimal toleranse, Func<string> egendefinertMelding)
        {
            faktisk.ShouldBe(forventet, toleranse, egendefinertMelding);
        }
    }
}
