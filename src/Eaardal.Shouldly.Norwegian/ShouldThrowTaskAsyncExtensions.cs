using System;
using System.Threading.Tasks;
using Shouldly;

namespace Eaardal.Shouldly.Norwegian
{
    //
    //  Translates ShouldThrowTaskAsyncExtensions.cs in the Shouldly codebase
    //

    public static class ShouldThrowTaskAsyncExtensions
    {
        /*** SkalKasteAsync(Task) ***/
        public static Task<TException> SkalKasteAsync<TException>(this Task task) where TException : Exception
        {
            return task.ShouldThrowAsync<TException>();
        }
        public static Task<TException> SkalKasteAsync<TException>(this Task task, string customMessage) where TException : Exception
        {
            return task.ShouldThrowAsync<TException>(customMessage);
        }
        public static Task<TException> SkalKasteAsync<TException>(this Task task, Func<string> customMessage) where TException : Exception
        {
            return task.ShouldThrowAsync<TException>(customMessage);
        }

        /*** SkalKasteAsync(Func<Task>) ***/
        public static Task<TException> SkalKasteAsync<TException>(this Func<Task> actual) where TException : Exception
        {
            return actual.ShouldThrowAsync<TException>();
        }
        public static Task<TException> SkalKasteAsync<TException>(this Func<Task> actual, string customMessage) where TException : Exception
        {
            return actual.ShouldThrowAsync<TException>(customMessage);
        }
        public static Task<TException> SkalKasteAsync<TException>(this Func<Task> actual, Func<string> customMessage) where TException : Exception
        {
            return actual.ShouldThrowAsync<TException>(customMessage);
        }
    }
}
