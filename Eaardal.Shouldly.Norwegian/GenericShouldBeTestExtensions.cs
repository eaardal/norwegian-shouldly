using System;
using System.Collections.Generic;
using Shouldly;

namespace Eaardal.Shouldly.Norwegian
{
    //
    //  Translates GenericShouldBeTestExtensions.cs in the Shouldly codebase
    //

    public static class GenericShouldBeTestExtensions
    {
        public static void SkalVære<T>(this T faktisk, T forventet)
        {
            SkalVære(faktisk, forventet, () => null);
        }
        public static void SkalVære<T>(this T faktisk, T forventet, string egendefinertMelding)
        {
            SkalVære(faktisk, forventet, () => egendefinertMelding);
        }
        public static void SkalVære<T>(this T faktisk, T forventet, Func<string> egendefinertMelding)
        {
            faktisk.ShouldBe<T>(forventet, egendefinertMelding);
        }
        
        public static void SkalIkkeVære<T>(this T faktisk, T forventet)
        {
            SkalIkkeVære(faktisk, forventet, () => null);
        }
        
        public static void SkalIkkeVære<T>(this T faktisk, T forventet, string egendefinertMelding)
        {
            SkalIkkeVære(faktisk, forventet, () => egendefinertMelding);
        }
        
        public static void SkalIkkeVære<T>(this T faktisk, T forventet, Func<string> egendefinertMelding)
        {
            faktisk.ShouldNotBe<T>(forventet, egendefinertMelding);
        }

        public static void SkalVære<T>(this IEnumerable<T> faktisk, IEnumerable<T> forventet, bool ignoreOrder = false)
        {
            SkalVære(faktisk, forventet, ignoreOrder, () => null);
        }
        public static void SkalVære<T>(this IEnumerable<T> faktisk, IEnumerable<T> forventet, bool ignoreOrder, string egendefinertMelding)
        {
            SkalVære(faktisk, forventet, ignoreOrder, () => egendefinertMelding);
        }
        public static void SkalVære<T>(this IEnumerable<T> faktisk, IEnumerable<T> forventet, bool ignoreOrder, Func<string> egendefinertMelding)
        {
            faktisk.ShouldBe<T>(forventet, ignoreOrder, egendefinertMelding);
        }

        public static void SkalVære(this IEnumerable<decimal> faktisk, IEnumerable<decimal> forventet, decimal toleranse)
        {
            SkalVære(faktisk, forventet, toleranse, () => null);
        }
        public static void SkalVære(this IEnumerable<decimal> faktisk, IEnumerable<decimal> forventet, decimal toleranse, string egendefinertMelding)
        {
            SkalVære(faktisk, forventet, toleranse, () => egendefinertMelding);
        }
        public static void SkalVære(this IEnumerable<decimal> faktisk, IEnumerable<decimal> forventet, decimal toleranse, Func<string> egendefinertMelding)
        {
            faktisk.ShouldBe(forventet, toleranse, egendefinertMelding);
        }

        public static void SkalVæreSammeSom(this object faktisk, object forventet)
        {
            SkalVæreSammeSom(faktisk, forventet, () => null);
        }
        public static void SkalVæreSammeSom(this object faktisk, object forventet, string egendefinertMelding)
        {
            SkalVæreSammeSom(faktisk, forventet, () => egendefinertMelding);
        }
        public static void SkalVæreSammeSom(this object faktisk, object forventet, Func<string> egendefinertMelding)
        {
            faktisk.ShouldBeSameAs(forventet, egendefinertMelding);
        }

        public static void SkalIkkeVæreSammeSom(this object faktisk, object forventet)
        {
            SkalIkkeVæreSammeSom(faktisk, forventet, () => null);
        }
        public static void SkalIkkeVæreSammeSom(this object faktisk, object forventet, string egendefinertMelding)
        {
            SkalIkkeVæreSammeSom(faktisk, forventet, () => egendefinertMelding);
        }
        public static void SkalIkkeVæreSammeSom(this object faktisk, object forventet, Func<string> egendefinertMelding)
        {
            faktisk.ShouldNotBeSameAs(forventet, egendefinertMelding);
        }
    }
}
