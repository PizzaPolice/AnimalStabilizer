using RimWorld;
using Verse;


namespace AnimalStabilizer
{
    public class HediffCompProperties_StabilizerEffect : HediffCompProperties
    {
        public int StabilizerDurationInTicks;

        public HediffCompProperties_StabilizerEffect()
        {
            compClass = typeof(HediffComp_StabilizerEffect);
        }
    }
}
