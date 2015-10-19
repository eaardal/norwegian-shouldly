using System;
using System.Collections.Generic;
using Shouldly;

namespace Eaardal.Shouldly.Norwegian
{
    //
    //  Translates ShouldBeDictionaryTestExtensions.cs in the Shouldly codebase
    //

    public static class ShouldBeDictionaryTestExtensions
    {
        public static void SkalInneholdeNøkkel<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key)
        {
            SkalInneholdeNøkkel(dictionary, key, () => null);
        }

        public static void SkalInneholdeNøkkel<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, string customMessage)
        {
            SkalInneholdeNøkkel(dictionary, key, () => customMessage);
        }

        public static void SkalInneholdeNøkkel<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, Func<string> customMessage)
        {
            dictionary.ShouldContainKey(key, customMessage);
        }

        public static void SkalIkkeInneholdeNøkkel<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key)
        {
            SkalIkkeInneholdeNøkkel(dictionary, key, () => null);
        }

        public static void SkalIkkeInneholdeNøkkel<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, string customMessage)
        {
            SkalIkkeInneholdeNøkkel(dictionary, key, () => customMessage);
        }

        public static void SkalIkkeInneholdeNøkkel<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, Func<string> customMessage)
        {
            dictionary.ShouldNotContainKey(key, customMessage);
        }

        public static void SkalInneholdeNøkkelOgVerdi<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue val)
        {
            SkalInneholdeNøkkelOgVerdi(dictionary, key, val, () => null);
        }

        public static void SkalInneholdeNøkkelOgVerdi<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue val, string customMessage)
        {
            SkalInneholdeNøkkelOgVerdi(dictionary, key, val, () => customMessage);
        }

        public static void SkalInneholdeNøkkelOgVerdi<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue val, Func<string> customMessage)
        {
            dictionary.ShouldContainKeyAndValue(key, val, customMessage);
        }

        public static void SkalIkkeInneholdeVerdiForNøkkel<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue val)
        {
            SkalIkkeInneholdeVerdiForNøkkel(dictionary, key, val, () => null);
        }

        public static void SkalIkkeInneholdeVerdiForNøkkel<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue val, string customMessage)
        {
            SkalIkkeInneholdeVerdiForNøkkel(dictionary, key, val, () => customMessage);
        }

        public static void SkalIkkeInneholdeVerdiForNøkkel<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue val, Func<string> customMessage)
        {
            dictionary.ShouldNotContainValueForKey(key, val, customMessage);
        }
    }
}
