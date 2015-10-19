using System;
using Shouldly;

namespace Eaardal.Shouldly.Norwegian
{
    //
    //  Translates ShouldBeTypeTestExtensions.cs in the Shouldly codebase
    //

    public static class ShouldBeTypeTestExtensions
    {
        public static T SkalKunneTilordnes<T>(this object faktisk)
        {
            return SkalKunneTilordnes<T>(faktisk, () => null);
        }

        public static T SkalKunneTilordnes<T>(this object faktisk, string egendefinertMelding)
        {
            return SkalKunneTilordnes<T>(faktisk, () => egendefinertMelding);
        }

        public static T SkalKunneTilordnes<T>(this object faktisk,  Func<string> egendefinertMelding)
        {
            SkalKunneTilordnes(faktisk, typeof(T), egendefinertMelding);
            return (T)faktisk;
        }

        public static void SkalKunneTilordnes(this object faktisk, Type forventet)
        {
            SkalKunneTilordnes(faktisk, forventet, () => null);
        }

        public static void SkalKunneTilordnes(this object faktisk, Type forventet, string egendefinertMelding)
        {
            SkalKunneTilordnes(faktisk, forventet, () => egendefinertMelding);
        }

        public static void SkalKunneTilordnes(this object faktisk, Type forventet,  Func<string> egendefinertMelding)
        {
            faktisk.ShouldBeAssignableTo(forventet, egendefinertMelding);
        }

        public static T SkalVæreAvType<T>(this object faktisk)
        {
            return SkalVæreAvType<T>(faktisk, () => null);
        }

        public static T SkalVæreAvType<T>(this object faktisk, string egendefinertMelding)
        {
            return SkalVæreAvType<T>(faktisk, () => egendefinertMelding);
        }

        public static T SkalVæreAvType<T>(this object faktisk,  Func<string> egendefinertMelding)
        {
            SkalVæreAvType(faktisk, typeof(T), egendefinertMelding);
            return (T)faktisk;
        }

        public static void SkalVæreAvType(this object faktisk, Type forventet)
        {
            SkalVæreAvType(faktisk, forventet, () => null);
        }

        public static void SkalVæreAvType(this object faktisk, Type forventet, string egendefinertMelding)
        {
            SkalVæreAvType(faktisk, forventet, () => egendefinertMelding);
        }

        public static void SkalVæreAvType(this object faktisk, Type forventet,  Func<string> egendefinertMelding)
        {
            faktisk.ShouldBeOfType(forventet, egendefinertMelding);
        }

        public static void SkalIkkeKunneTilordnes<T>(this object faktisk)
        {
            SkalIkkeKunneTilordnes<T>(faktisk, () => null);
        }

        public static void SkalIkkeKunneTilordnes<T>(this object faktisk, string egendefinertMelding)
        {
            SkalIkkeKunneTilordnes<T>(faktisk, () => egendefinertMelding);
        }

        public static void SkalIkkeKunneTilordnes<T>(this object faktisk,  Func<string> egendefinertMelding)
        {
            SkalIkkeKunneTilordnes(faktisk, typeof(T), egendefinertMelding);
        }

        public static void SkalIkkeKunneTilordnes(this object faktisk, Type forventet)
        {
            SkalIkkeKunneTilordnes(faktisk, forventet, () => null);
        }

        public static void SkalIkkeKunneTilordnes(this object faktisk, Type forventet, string egendefinertMelding)
        {
            SkalIkkeKunneTilordnes(faktisk, forventet, () => egendefinertMelding);
        }

        public static void SkalIkkeKunneTilordnes(this object faktisk, Type forventet,  Func<string> egendefinertMelding)
        {
            faktisk.ShouldNotBeAssignableTo(forventet, egendefinertMelding);
        }

        public static void SkalIkkeVæreAvType<T>(this object faktisk)
        {
            SkalIkkeVæreAvType<T>(faktisk, () => null);
        }

        public static void SkalIkkeVæreAvType<T>(this object faktisk, string egendefinertMelding)
        {
            SkalIkkeVæreAvType<T>(faktisk, () => egendefinertMelding);
        }

        public static void SkalIkkeVæreAvType<T>(this object faktisk,  Func<string> egendefinertMelding)
        {
            SkalIkkeVæreAvType(faktisk, typeof(T), egendefinertMelding);
        }

        public static void SkalIkkeVæreAvType(this object faktisk, Type forventet)
        {
            SkalIkkeVæreAvType(faktisk, forventet, () => null);
        }

        public static void SkalIkkeVæreAvType(this object faktisk, Type forventet, string egendefinertMelding)
        {
            SkalIkkeVæreAvType(faktisk, forventet, () => egendefinertMelding);
        }

        public static void SkalIkkeVæreAvType(this object faktisk, Type forventet,  Func<string> egendefinertMelding)
        {
            faktisk.ShouldNotBeOfType(forventet, egendefinertMelding);
        }
    }
}
