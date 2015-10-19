using System;
using Shouldly;

namespace Eaardal.Shouldly.Norwegian
{
    //
    //  Translates ShouldThrowExtensions.cs in the Shouldly codebase
    //

    public static class ThrowExtensions
    {
        /*** SkalKaste(Action) ***/
        public static TException SkalKaste<TException>(this Action faktisk) where TException : Exception
        {
            return faktisk.ShouldThrow<TException>();
        }
        public static TException SkalKaste<TException>(this Action faktisk, string egendefinertMelding) where TException : Exception
        {
            return faktisk.ShouldThrow<TException>(egendefinertMelding);
        }
        public static TException SkalKaste<TException>(this Action faktisk,  Func<string> egendefinertMelding) where TException : Exception
        {
            return faktisk.ShouldThrow<TException>(egendefinertMelding);
        }

        /*** SkalIkkeKaste(Action) ***/
        public static void SkalIkkeKaste(this Action faktisk)
        {
            faktisk.ShouldNotThrow();
        }
        public static void SkalIkkeKaste(this Action faktisk, string egendefinertMelding)
        {
            faktisk.ShouldNotThrow(egendefinertMelding);
        }
        public static void SkalIkkeKaste(this Action faktisk,  Func<string> egendefinertMelding)
        {
            faktisk.ShouldNotThrow(egendefinertMelding);
        }

        /*** SkalIkkeKaste(Func<T>) ***/
        public static T SkalIkkeKaste<T>(this Func<T> faktisk)
        {
            return faktisk.ShouldNotThrow<T>();
        }

        public static T SkalIkkeKaste<T>(this Func<T> faktisk, string egendefinertMelding)
        {
            return faktisk.ShouldNotThrow<T>(egendefinertMelding);
        }
        public static T SkalIkkeKaste<T>(this Func<T> faktisk,  Func<string> egendefinertMelding)
        {
            return faktisk.ShouldNotThrow<T>(egendefinertMelding);
        }
    }
}
