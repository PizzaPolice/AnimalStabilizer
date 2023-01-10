using RimWorld;
using Verse;


namespace AnimalStabilizer
{
    public class HediffCompProperties_StabilizerEffect : HediffCompProperties
    {
        public int BleedToDeathTicksActivationThreshold;


        public HediffCompProperties_StabilizerEffect()
        {
            compClass = typeof(HediffComp_StabilizerEffect);
        }
    }
}
