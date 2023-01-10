using RimWorld;
using Verse;

namespace AnimalStabilizer
{
    public class HediffComp_StabilizerEffect : HediffComp
    {
        public HediffCompProperties_StabilizerEffect Props => (HediffCompProperties_StabilizerEffect)props;
     

        private HediffDef stabilization = DefDatabase<HediffDef>.GetNamed("EmergencyStabilization");
        

        public override void CompPostTick(ref float severityAdjustment)
        {
            //Only check every 250 ticks (rare tick)
            if(Find.TickManager.TicksGame % 250 != 0) {
                return;
            }
            
            //Do not re-apply stabilization effect if already present
            if (Pawn.health.hediffSet.GetFirstHediffOfDef(stabilization) != null) {
                return;
            }

            //Only apply if pawn is downed
            if (!Pawn.Downed) {
                return;
            }

            //And pawn is at most 12 hours from bleeding to death
            if (HealthUtility.TicksUntilDeathDueToBloodLoss(Pawn) < Props.BleedToDeathTicksActivationThreshold) {
                Pawn.health.AddHediff(stabilization);
            }

        }
    }
}