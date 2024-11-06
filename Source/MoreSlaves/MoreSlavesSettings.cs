using Verse;

namespace MoreSlaves;

public class MoreSlavesSettings : ModSettings
{
    public static IntRange slaveCount = new IntRange(3, 5);

    public override void ExposeData()
    {
        base.ExposeData();
        Scribe_Values.Look(ref slaveCount, "slaveCount", new IntRange(3, 5), true);
    }
}