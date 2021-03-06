﻿using System;
using Shouldly;

namespace NorwegianShouldly
{
    //
    //  Translates DateTimeShouldBeTestExtensions.cs in the Shouldly codebase
    //

    public static class DateTimeShouldBeTestExtensions
    {
        public static void SkalVære(this DateTime faktisk, DateTime forventet, TimeSpan toleranse)
        {
            SkalVære(faktisk, forventet, toleranse, () => null);
        }

        public static void SkalVære(this DateTime faktisk, DateTime forventet, TimeSpan toleranse, string egendefinertMelding)
        {
            SkalVære(faktisk, forventet, toleranse, () => egendefinertMelding);
        }

        public static void SkalVære(this DateTime faktisk, DateTime forventet, TimeSpan toleranse, Func<string> egendefinertMelding)
        {
            faktisk.ShouldBe(forventet, toleranse, egendefinertMelding);
        }

        public static void SkalVære(this DateTimeOffset faktisk, DateTimeOffset forventet, TimeSpan toleranse)
        {
            SkalVære(faktisk, forventet, toleranse, () => null);
        }

        public static void SkalVære(this DateTimeOffset faktisk, DateTimeOffset forventet, TimeSpan toleranse, string egendefinertMelding)
        {
            SkalVære(faktisk, forventet, toleranse, () => egendefinertMelding);
        }

        public static void SkalVære(this DateTimeOffset faktisk, DateTimeOffset forventet, TimeSpan toleranse, Func<string> egendefinertMelding)
        {
            faktisk.ShouldBe(forventet, toleranse, egendefinertMelding);
        }

        public static void SkalVære(this TimeSpan faktisk, TimeSpan forventet, TimeSpan toleranse)
        {
            SkalVære(faktisk, forventet, toleranse, () => null);
        }

        public static void SkalVære(this TimeSpan faktisk, TimeSpan forventet, TimeSpan toleranse, string egendefinertMelding)
        {
            SkalVære(faktisk, forventet, toleranse, () => egendefinertMelding);
        }

        public static void SkalVære(this TimeSpan faktisk, TimeSpan forventet, TimeSpan toleranse, Func<string> egendefinertMelding)
        {
            faktisk.ShouldBe(forventet, toleranse, egendefinertMelding);
        }

        public static void SkalIkkeVære(this DateTime faktisk, DateTime forventet, TimeSpan toleranse)
        {
            SkalIkkeVære(faktisk, forventet, toleranse, () => null);
        }

        public static void SkalIkkeVære(this DateTime faktisk, DateTime forventet, TimeSpan toleranse, string egendefinertMelding)
        {
            SkalIkkeVære(faktisk, forventet, toleranse, () => egendefinertMelding);
        }

        public static void SkalIkkeVære(this DateTime faktisk, DateTime forventet, TimeSpan toleranse, Func<string> egendefinertMelding)
        {
            faktisk.ShouldNotBe(forventet, toleranse, egendefinertMelding);
        }

        public static void SkalIkkeVære(this DateTimeOffset faktisk, DateTimeOffset forventet, TimeSpan toleranse)
        {
            SkalIkkeVære(faktisk, forventet, toleranse, () => null);
        }

        public static void SkalIkkeVære(this DateTimeOffset faktisk, DateTimeOffset forventet, TimeSpan toleranse, string egendefinertMelding)
        {
            SkalIkkeVære(faktisk, forventet, toleranse, () => egendefinertMelding);
        }

        public static void SkalIkkeVære(this DateTimeOffset faktisk, DateTimeOffset forventet, TimeSpan toleranse, Func<string> egendefinertMelding)
        {
            faktisk.ShouldNotBe(forventet, toleranse, egendefinertMelding);
        }

        public static void SkalIkkeVære(this TimeSpan faktisk, TimeSpan forventet, TimeSpan toleranse)
        {
            SkalIkkeVære(faktisk, forventet, toleranse, () => null);
        }

        public static void SkalIkkeVære(this TimeSpan faktisk, TimeSpan forventet, TimeSpan toleranse, string egendefinertMelding)
        {
            SkalIkkeVære(faktisk, forventet, toleranse, () => egendefinertMelding);
        }

        public static void SkalIkkeVære(this TimeSpan faktisk, TimeSpan forventet, TimeSpan toleranse, Func<string> egendefinertMelding)
        {
            faktisk.ShouldNotBe(forventet, toleranse, egendefinertMelding);
        }
    }
}
