using System;
using Shouldly;

namespace NorwegianShouldly
{
    //
    //  Translates ShouldUtførInnenExtensions.cs in the Shouldly codebase
    //

    public static class SatisfyAllvilkårExtensions
    {
        public static void SkalTilfredstilleAlleVilkår(this object faktisk, params Action[] vilkår)
        {
            SkalTilfredstilleAlleVilkår(faktisk, () => null, vilkår);
        }

        public static void SkalTilfredstilleAlleVilkår(this object faktisk, string egendefinertMelding, params Action[] vilkår)
        {
            SkalTilfredstilleAlleVilkår(faktisk, () => egendefinertMelding, vilkår);
        }

        public static void SkalTilfredstilleAlleVilkår(this object faktisk, Func<string> egendefinertMelding, params Action[] vilkår)
        {
            faktisk.ShouldSatisfyAllConditions(egendefinertMelding, vilkår);
        }
    }
}
