//using System;
//using System.Reflection;
//using System.Threading;
//using System.Threading.Tasks;
//using Shouldly;

//namespace Eaardal.Shouldly.Norwegian
//{
//    //
//    //  Translates ShouldUtførInnenExtensions.cs in the Shouldly codebase
//    //

//    public static class UtførInnenExtensions
//    {
//        /*** UtførInnen(Action) ***/
//        public static void UtførInnen(Action action, TimeSpan tidsgrense)
//        {
            
//            var faktisk = Task.Factory.StartNew(action, CancellationToken.None, TaskCreationOptions.None,
//                        TaskScheduler.Default);

//            UtførInnen(faktisk, tidsgrense, () => null);
//        }
//        public static void UtførInnen(Action action, TimeSpan tidsgrense, string egendefinertMelding)
//        {
//            UtførInnen(action, tidsgrense, () => egendefinertMelding);
//        }
//        public static void UtførInnen(Action action, TimeSpan tidsgrense, Func<string> egendefinertMelding)
//        {
//            var faktisk = Task.Factory.StartNew(action, CancellationToken.None, TaskCreationOptions.None,
//                        TaskScheduler.Default);
//            UtførInnen(faktisk, tidsgrense, egendefinertMelding, "Delegate");
//        }

//        /*** UtførInnen(Func<T>) ***/
//        public static T UtførInnen<T>(Func<T> function, TimeSpan tidsgrense)
//        {
//            return UtførInnen(function, tidsgrense, () => null);
//        }
//        public static T UtførInnen<T>(Func<T> function, TimeSpan tidsgrense, string egendefinertMelding)
//        {
//            return UtførInnen(function, tidsgrense, () => egendefinertMelding);
//        }
//        public static T UtførInnen<T>(Func<T> function, TimeSpan tidsgrense, Func<string> egendefinertMelding)
//        {
//            var faktisk = Task.Factory.StartNew(function, CancellationToken.None, TaskCreationOptions.None,
//                        TaskScheduler.Default);

//            return UtførInnen(faktisk, tidsgrense, egendefinertMelding, "Delegate");
//        }

//        /*** UtførInnen(Func<Task>) ***/
//        public static void UtførInnen(Func<Task> faktisk, TimeSpan tidsgrense)
//        {
//            UtførInnen(faktisk, tidsgrense, () => null);
//        }
//        public static void UtførInnen(Func<Task> faktisk, TimeSpan tidsgrense, string egendefinertMelding)
//        {
//            UtførInnen(faktisk, tidsgrense, () => egendefinertMelding);
//        }
//        public static void UtførInnen(Func<Task> faktisk, TimeSpan tidsgrense, Func<string> egendefinertMelding)
//        {
//            UtførInnen(faktisk(), tidsgrense, egendefinertMelding, "Task");
//        }

//        /*** UtførInnen(Func<Task<T>>) ***/
//        public static T UtførInnen<T>(Func<Task<T>> faktisk, TimeSpan tidsgrense)
//        {
//            return UtførInnen(faktisk, tidsgrense, () => null);
//        }
//        public static T UtførInnen<T>(Func<Task<T>> faktisk, TimeSpan tidsgrense, string egendefinertMelding)
//        {
//            return UtførInnen(faktisk, tidsgrense, () => egendefinertMelding);
//        }
//        public static T UtførInnen<T>(Func<Task<T>> faktisk, TimeSpan tidsgrense, Func<string> egendefinertMelding)
//        {
//            return UtførInnen(faktisk(), tidsgrense, egendefinertMelding, "Task");
//        }

//        /*** UtførInnen(Task<T>) ***/
//        public static void UtførInnen(Task faktisk, TimeSpan tidsgrense)
//        {
//            UtførInnen(faktisk, tidsgrense, () => null);
//        }
//        public static void UtførInnen(Task faktisk, TimeSpan tidsgrense, string egendefinertMelding)
//        {
//            UtførInnen(faktisk, tidsgrense, () => egendefinertMelding);
//        }
//        public static void UtførInnen(Task faktisk, TimeSpan tidsgrense, Func<string> egendefinertMelding)
//        {
//            UtførInnen(faktisk, tidsgrense, egendefinertMelding, "Task");
//        }

//        /*** UtførInnen(Task<T>) ***/
//        public static T UtførInnen<T>(Task<T> faktisk, TimeSpan tidsgrense)
//        {
//            UtførInnen(faktisk, tidsgrense, () => null);
//            return faktisk.Result;
//        }
//        public static T UtførInnen<T>(Task<T> faktisk, TimeSpan tidsgrense, string egendefinertMelding)
//        {
//            UtførInnen(faktisk, tidsgrense, () => egendefinertMelding);
//            return faktisk.Result;
//        }
//        public static T UtførInnen<T>(Task<T> faktisk, TimeSpan tidsgrense, Func<string> egendefinertMelding)
//        {
//            return UtførInnen(faktisk, tidsgrense, egendefinertMelding, "Task");
//        }

//        private static T UtførInnen<T>(Task<T> faktisk, TimeSpan tidsgrense, Func<string> egendefinertMelding, string what)
//        {
//            UtførInnen((Task)faktisk, tidsgrense, egendefinertMelding, what);
//            return faktisk.Result;
//        }

//        private static void UtførInnen(Task faktisk, TimeSpan tidsgrense, Func<string> egendefinertMelding, string what)
//        {
//            try
//            {
//                faktisk.tidsgrenseAfter(tidsgrense).Wait();
//            }
//            catch (AggregateException ae)
//            {
//                var flattened = ae.Flatten();
//                if (flattened.InnerExceptions.Count != 1)
//                    throw;

//                var inner = flattened.InnerException;
//                var exception = inner as tidsgrenseException;
//                // When exception is a tidsgrense exception we can provide a better error, otherwise rethrow
//                if (exception != null)
//                {
//                    var message = new UtførInnenShouldlyMessage(what, tidsgrense, egendefinertMelding).ToString();
//                    throw new ShouldUtførInnenException(message, exception);
//                }

//                PreserveStackTrace(inner);
//                throw inner;
//            }
//        }

//        private static void PreserveStackTrace(Exception exception)
//        {
//            MethodInfo preserveStackTrace = typeof(Exception).GetMethod("InternalPreserveStackTrace",
//              BindingFlags.Instance | BindingFlags.NonPublic);
//            preserveStackTrace.Invoke(exception, null);
//        }
//    }
//}

namespace NorwegianShouldly
{
}