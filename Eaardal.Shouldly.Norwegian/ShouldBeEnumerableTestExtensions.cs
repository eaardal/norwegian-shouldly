using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Shouldly;

namespace Eaardal.Shouldly.Norwegian
{
    //
    //  Translates ShouldBeEnumerableTestExtensions.cs in the Shouldly codebase
    //

    public static class ShouldBeEnumerableTestExtensions
    {
        public static void SkalInneholde<T>(this IEnumerable<T> faktisk, T forventet)
        {
            SkalInneholde(faktisk, forventet, () => null);
        }

        public static void SkalInneholde<T>(this IEnumerable<T> faktisk, T forventet, string egendefinertMelding)
        {
            SkalInneholde(faktisk, forventet, () => egendefinertMelding);
        }

        public static void SkalInneholde<T>(this IEnumerable<T> faktisk, T forventet, Func<string> egendefinertMelding)
        {
            faktisk.ShouldContain(forventet, egendefinertMelding);
        }

        public static void SkalIkkeInneholde<T>(this IEnumerable<T> faktisk, T forventet)
        {
            SkalIkkeInneholde(faktisk, forventet, () => null);
        }

        public static void SkalIkkeInneholde<T>(this IEnumerable<T> faktisk, T forventet, string egendefinertMelding)
        {
            SkalIkkeInneholde(faktisk, forventet, () => egendefinertMelding);
        }

        public static void SkalIkkeInneholde<T>(this IEnumerable<T> faktisk, T forventet, Func<string> egendefinertMelding)
        {
            faktisk.ShouldNotContain(forventet, egendefinertMelding);
        }

        public static void SkalInneholde<T>(this IEnumerable<T> faktisk,  Expression<Func<T, bool>> elementPredicate)
        {
            SkalInneholde(faktisk, elementPredicate, () => null);
        }

        public static void SkalInneholde<T>(this IEnumerable<T> faktisk,  Expression<Func<T, bool>> elementPredicate, string egendefinertMelding)
        {
            SkalInneholde(faktisk, elementPredicate, () => egendefinertMelding);
        }

        public static void SkalInneholde<T>(this IEnumerable<T> faktisk,  Expression<Func<T, bool>> elementPredicate, Func<string> egendefinertMelding)
        {
            faktisk.ShouldContain(elementPredicate, egendefinertMelding);
        }

        public static void SkalIkkeInneholde<T>(this IEnumerable<T> faktisk,  Expression<Func<T, bool>> elementPredicate)
        {
            SkalIkkeInneholde(faktisk, elementPredicate, () => null);
        }

        public static void SkalIkkeInneholde<T>(this IEnumerable<T> faktisk,  Expression<Func<T, bool>> elementPredicate, string egendefinertMelding)
        {
            SkalIkkeInneholde(faktisk, elementPredicate, () => egendefinertMelding);
        }

        public static void SkalIkkeInneholde<T>(this IEnumerable<T> faktisk,  Expression<Func<T, bool>> elementPredicate, Func<string> egendefinertMelding)
        {
            faktisk.ShouldNotContain(elementPredicate, egendefinertMelding);
        }

        public static void SkalAlleVære<T>(this IEnumerable<T> faktisk,  Expression<Func<T, bool>> elementPredicate)
        {
            SkalAlleVære(faktisk, elementPredicate, () => null);
        }

        public static void SkalAlleVære<T>(this IEnumerable<T> faktisk,  Expression<Func<T, bool>> elementPredicate, string egendefinertMelding)
        {
            SkalAlleVære(faktisk, elementPredicate, () => egendefinertMelding);
        }

        public static void SkalAlleVære<T>(this IEnumerable<T> faktisk,  Expression<Func<T, bool>> elementPredicate,  Func<string> egendefinertMelding)
        {
            faktisk.ShouldAllBe(elementPredicate, egendefinertMelding);
        }

        public static void SkalVæreTom<T>(this IEnumerable<T> faktisk)
        {
            SkalVæreTom(faktisk, () => null);
        }

        public static void SkalVæreTom<T>(this IEnumerable<T> faktisk, string egendefinertMelding)
        {
            SkalVæreTom(faktisk, () => egendefinertMelding);
        }

        public static void SkalVæreTom<T>(this IEnumerable<T> faktisk,  Func<string> egendefinertMelding)
        {
            faktisk.ShouldBeEmpty(egendefinertMelding);
        }

        public static void SkalIkkeVæreTom<T>(this IEnumerable<T> faktisk)
        {
            SkalIkkeVæreTom(faktisk, () => null);
        }

        public static void SkalIkkeVæreTom<T>(this IEnumerable<T> faktisk, string egendefinertMelding)
        {
            SkalIkkeVæreTom(faktisk, () => egendefinertMelding);
        }

        public static void SkalIkkeVæreTom<T>(this IEnumerable<T> faktisk,  Func<string> egendefinertMelding)
        {
            faktisk.ShouldNotBeEmpty(egendefinertMelding);
        }

        public static void SkalInneholde(this IEnumerable<float> faktisk, float forventet, double toleranse)
        {
            SkalInneholde(faktisk, forventet, toleranse, () => null);
        }

        public static void SkalInneholde(this IEnumerable<float> faktisk, float forventet, double toleranse, string egendefinertMelding)
        {
            SkalInneholde(faktisk, forventet, toleranse, () => egendefinertMelding);
        }

        public static void SkalInneholde(this IEnumerable<float> faktisk, float forventet, double toleranse,  Func<string> egendefinertMelding)
        {
            faktisk.ShouldContain(forventet, toleranse, egendefinertMelding);
        }

        public static void SkalInneholde(this IEnumerable<double> faktisk, double forventet, double toleranse)
        {
            SkalInneholde(faktisk, forventet, toleranse, () => null);
        }

        public static void SkalInneholde(this IEnumerable<double> faktisk, double forventet, double toleranse, string egendefinertMelding)
        {
            SkalInneholde(faktisk, forventet, toleranse, () => egendefinertMelding);
        }

        public static void SkalInneholde(this IEnumerable<double> faktisk, double forventet, double toleranse,  Func<string> egendefinertMelding)
        {
            faktisk.ShouldContain(forventet, toleranse, egendefinertMelding);
        }

        public static void SkalVæreUndersettAv<T>(this IEnumerable<T> faktisk, IEnumerable<T> forventet)
        {
            SkalVæreUndersettAv(faktisk, forventet, () => null);
        }

        public static void SkalVæreUndersettAv<T>(this IEnumerable<T> faktisk, IEnumerable<T> forventet, string egendefinertMelding)
        {
            SkalVæreUndersettAv(faktisk, forventet, () => egendefinertMelding);
        }

        public static void SkalVæreUndersettAv<T>(this IEnumerable<T> faktisk, IEnumerable<T> forventet,  Func<string> egendefinertMelding)
        {
            faktisk.ShouldBeSubsetOf(forventet, egendefinertMelding);
        }

        public static void SkalVæreUnik<T>(this IEnumerable<T> faktisk)
        {
            SkalVæreUnik(faktisk, () => null);
        }

        public static void SkalVæreUnik<T>(this IEnumerable<T> faktisk, string egendefinertMelding)
        {
            SkalVæreUnik(faktisk, () => egendefinertMelding);
        }

        public static void SkalVæreUnik<T>(this IEnumerable<T> faktisk,  Func<string> egendefinertMelding)
        {
            faktisk.ShouldBeUnique(egendefinertMelding);
        }

        public static void SkalVære(this IEnumerable<string> faktisk, IEnumerable<string> forventet, Case caseSensitivity)
        {
            SkalVære(faktisk, forventet, caseSensitivity, () => null);
        }

        public static void SkalVære(this IEnumerable<string> faktisk, IEnumerable<string> forventet, Case caseSensitivity, string egendefinertMelding)
        {
            SkalVære(faktisk, forventet, caseSensitivity, () => egendefinertMelding);
        }

        public static void SkalVære(this IEnumerable<string> faktisk, IEnumerable<string> forventet, Case caseSensitivity,  Func<string> egendefinertMelding)
        {
            faktisk.ShouldBe(forventet, caseSensitivity, egendefinertMelding);
        }
    }
}
