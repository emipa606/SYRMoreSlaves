using Verse;

namespace MoreSlaves;

public class MoreSlavesSettings : ModSettings
{
    public IntRange SlaveCount = new(3, 5);

    public override void ExposeData()
    {
        base.ExposeData();
        Scribe_Values.Look(ref SlaveCount, "slaveCount", new IntRange(3, 5), true);
    }
}