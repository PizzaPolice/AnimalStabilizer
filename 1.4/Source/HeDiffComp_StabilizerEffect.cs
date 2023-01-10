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

            if (Pawn.health.hediffSet.GetFirstHediffOfDef(stabilization) != null) {
                Log.Error("FOUND STABLIIZATION ALREADY");
                return;
            }

            if (!Pawn.Downed) {
                Log.Error("PAWN NOT DOWNED YET");
                return;
            }

            if (HealthUtility.TicksUntilDeathDueToBloodLoss(Pawn) < Props.BleedToDeathTicksActivationThreshold) {
                Pawn.health.AddHediff(stabilization);
                Log.Error("MAN DOWN MAN DOWN");
            } 
                
           

        }
    }
}