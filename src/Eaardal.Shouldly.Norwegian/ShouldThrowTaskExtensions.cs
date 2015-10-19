using System;
using System.Threading.Tasks;
using Shouldly;

namespace Eaardal.Shouldly.Norwegian
{
    //
    //  Translates ShouldThrowTaskExtensions.cs in the Shouldly codebase
    //

    public static class ShouldThrowTaskExtensions
    {
        /*** SkalKaste(Task) ***/
        public static TException SkalKaste<TException>(this Task faktisk) where TException : Exception
        {
            return faktisk.ShouldThrow<TException>();
        }
        public static TException SkalKaste<TException>(this Task faktisk, string egendefinertMelding) where TException : Exception
        {
            return faktisk.ShouldThrow<TException>(egendefinertMelding);
        }
        public static TException SkalKaste<TException>(this Task faktisk,  Func<string> egendefinertMelding) where TException : Exception
        {
            return faktisk.ShouldThrow<TException>(egendefinertMelding);
        }

        /*** SkalKaste(Func<Task>) ***/
        public static TException SkalKaste<TException>(this Func<Task> faktisk) where TException : Exception
        {
            return faktisk.ShouldThrow<TException>();
        }
        public static TException SkalKaste<TException>(this Func<Task> faktisk, string egendefinertMelding) where TException : Exception
        {
            return faktisk.ShouldThrow<TException>(egendefinertMelding);
        }
        public static TException SkalKaste<TException>(this Func<Task> faktisk,  Func<string> egendefinertMelding) where TException : Exception
        {
            return faktisk.ShouldThrow<TException>(egendefinertMelding);
        }

        /*** SkalKaste(Task, TimeSpan) ***/
        public static TException SkalKaste<TException>(this Task faktisk, TimeSpan avbrytEtter) where TException : Exception
        {
            return faktisk.ShouldThrow<TException>(avbrytEtter);
        }
        public static TException SkalKaste<TException>(this Task faktisk, TimeSpan avbrytEtter, string egendefinertMelding) where TException : Exception
        {
            return faktisk.ShouldThrow<TException>(avbrytEtter, egendefinertMelding);
        }
        public static TException SkalKaste<TException>(this Task faktisk, TimeSpan avbrytEtter,  Func<string> egendefinertMelding) where TException : Exception
        {
            return faktisk.ShouldThrow<TException>(avbrytEtter, egendefinertMelding);
        }

        /*** SkalKaste(Func<Task>, TimeSpan) ***/
        public static TException SkalKaste<TException>(this Func<Task> faktisk, TimeSpan avbrytEtter) where TException : Exception
        {
            return faktisk.ShouldThrow<TException>(avbrytEtter);
        }
        public static TException SkalKaste<TException>(this Func<Task> faktisk, TimeSpan avbrytEtter, string egendefinertMelding) where TException : Exception
        {
            return faktisk.ShouldThrow<TException>(avbrytEtter, egendefinertMelding);
        }
        public static TException SkalKaste<TException>(this Func<Task> faktisk, TimeSpan avbrytEtter,  Func<string> egendefinertMelding) where TException : Exception
        {
            return faktisk.ShouldThrow<TException>(avbrytEtter, egendefinertMelding);
        }

        /*** SkalIkkeKaste(Task) ***/
        public static void SkalIkkeKaste(this Task handling)
        {
            handling.ShouldNotThrow();
        }
        public static void SkalIkkeKaste(this Task handling, string egendefinertMelding)
        {
            handling.ShouldNotThrow(egendefinertMelding);
        }
        public static void SkalIkkeKaste(this Task handling,  Func<string> egendefinertMelding)
        {
            handling.ShouldNotThrow(egendefinertMelding);
        }

        /*** SkalIkkeKaste(Task<T>) ***/
        public static T SkalIkkeKaste<T>(this Task<T> handling)
        {
            return handling.ShouldNotThrow<T>();
        }
        public static T SkalIkkeKaste<T>(this Task<T> handling, string egendefinertMelding)
        {
            return handling.ShouldNotThrow<T>(egendefinertMelding);
        }
        public static T SkalIkkeKaste<T>(this Task<T> handling,  Func<string> egendefinertMelding)
        {
            return handling.ShouldNotThrow<T>(egendefinertMelding);
        }

        /*** SkalIkkeKaste(Func<Task>) ***/
        public static void SkalIkkeKaste(this Func<Task> handling)
        {
            handling.ShouldNotThrow();
        }
        public static void SkalIkkeKaste(this Func<Task> handling, string egendefinertMelding)
        {
            handling.ShouldNotThrow(egendefinertMelding);
        }
        public static void SkalIkkeKaste(this Func<Task> handling,  Func<string> egendefinertMelding)
        {
            handling.ShouldNotThrow(egendefinertMelding);
        }

        /*** SkalIkkeKaste(Task, TimeSpan) ***/
        public static void SkalIkkeKaste(this Task handling, TimeSpan avbrytEtter)
        {
            handling.ShouldNotThrow(avbrytEtter);
        }
        public static void SkalIkkeKaste(this Task handling, TimeSpan avbrytEtter, string egendefinertMelding)
        {
            handling.ShouldNotThrow(avbrytEtter, egendefinertMelding);
        }
        public static void SkalIkkeKaste(this Task handling, TimeSpan avbrytEtter,  Func<string> egendefinertMelding)
        {
            handling.ShouldNotThrow(avbrytEtter, egendefinertMelding);
        }

        /*** SkalIkkeKaste(Func<Task>, TimeSpan) ***/
        public static void SkalIkkeKaste(this Func<Task> handling, TimeSpan avbrytEtter)
        {
            handling.ShouldNotThrow(avbrytEtter);
        }
        public static void SkalIkkeKaste(this Func<Task> handling, TimeSpan avbrytEtter, string egendefinertMelding)
        {
            handling.ShouldNotThrow(avbrytEtter, egendefinertMelding);
        }
        public static void SkalIkkeKaste(this Func<Task> handling, TimeSpan avbrytEtter,  Func<string> egendefinertMelding)
        {
            handling.ShouldNotThrow(avbrytEtter, egendefinertMelding);
        }

        /*** SkalIkkeKaste(Func<Task<T>>) ***/
        public static T SkalIkkeKaste<T>(this Func<Task<T>> handling)
        {
            return handling.ShouldNotThrow<T>();
        }
        public static T SkalIkkeKaste<T>(this Func<Task<T>> handling, string egendefinertMelding)
        {
            return handling.ShouldNotThrow<T>(egendefinertMelding);
        }
        public static T SkalIkkeKaste<T>(this Func<Task<T>> handling,  Func<string> egendefinertMelding)
        {
            return handling.ShouldNotThrow<T>(egendefinertMelding);
        }

        /*** SkalIkkeKaste(Task<T>, TimeSpan) ***/
        public static T SkalIkkeKaste<T>(this Task<T> handling, TimeSpan avbrytEtter)
        {
            return handling.ShouldNotThrow<T>(avbrytEtter);
        }
        public static T SkalIkkeKaste<T>(this Task<T> handling, TimeSpan avbrytEtter, string egendefinertMelding)
        {
            return handling.ShouldNotThrow<T>(avbrytEtter, egendefinertMelding);
        }
        public static T SkalIkkeKaste<T>(this Task<T> handling, TimeSpan avbrytEtter,  Func<string> egendefinertMelding)
        {
            return handling.ShouldNotThrow<T>(avbrytEtter, egendefinertMelding);
        }

        /*** SkalIkkeKaste(Func<Task<T>>, TimeSpan) ***/
        public static T SkalIkkeKaste<T>(this Func<Task<T>> handling, TimeSpan avbrytEtter)
        {
            return handling.ShouldNotThrow<T>(avbrytEtter);
        }
        public static T SkalIkkeKaste<T>(this Func<Task<T>> handling, TimeSpan avbrytEtter, string egendefinertMelding)
        {
            return handling.ShouldNotThrow<T>(avbrytEtter, egendefinertMelding);
        }
        public static T SkalIkkeKaste<T>(this Func<Task<T>> handling, TimeSpan avbrytEtter,  Func<string> egendefinertMelding)
        {
            return handling.ShouldNotThrow<T>(avbrytEtter, egendefinertMelding);
        }
    }
}
