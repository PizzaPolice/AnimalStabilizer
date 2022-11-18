using RimWorld;
using Verse;

namespace AnimalStabilizer
{
    public class HediffComp_StabilizerEffect : HediffComp
    {
        public HediffCompProperties_StabilizerEffect Props => (HediffCompProperties_StabilizerEffect)props;

        public override void CompPostTick(ref float severityAdjustment)
        {
            //Only check every 250 ticks (rare tick)
            if(Find.TickManager.TicksGame % 250 != 0) {
                return;
            }

            if(Pawn.Downed) {
                Pawn.health.AddHediff(HediffDefOf.FoodPoisoning);
                Log.Error("MAN DOWN MAN DOWN");
            }

        }
    }
}