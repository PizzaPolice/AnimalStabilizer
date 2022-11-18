using RimWorld;
using Verse;

public class HediffCompProperties_StabilizerEffect : HediffCompProperties
{
	public FleckDef fleck;

	public ThingDef mote;

	public int moteCount = 3;

	public FloatRange moteOffsetRange = new FloatRange(0.2f, 0.4f);

	public ThingDef filth;

	public int filthCount = 4;

	public HediffDef injuryCreatedOnDeath;

	public IntRange injuryCount;

	public SoundDef sound;

	public HediffCompProperties_StabilizerEffect()
	{
		compClass = typeof(HediffComp_StabilizerEffect);
	}
}
