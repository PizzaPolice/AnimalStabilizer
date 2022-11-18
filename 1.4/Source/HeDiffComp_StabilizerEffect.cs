using RimWorld;
using Verse;


public class HediffComp_StabilizerEffect : HediffComp
{
	public HediffCompProperties_StabilizerEffect Props => (HediffCompProperties_StabilizerEffect)props;

    public override void CompPostTick(ref float severityAdjustment)
    {
	    base.CompPostTick(ref severityAdjustment);
    }
}