using RimWorld;
using Verse;

namespace AnimalStabilizer
{
    public class HediffComp_StabilizerEffect : HediffComp
    {
        public HediffCompProperties_StabilizerEffect Props => (HediffCompProperties_StabilizerEffect)props;

        public override void CompPostTick(ref float severityAdjustment)
        {
            Log.Error("THE DEF IS" + Props.StabilizerDurationInTicks);

        }
    }
}