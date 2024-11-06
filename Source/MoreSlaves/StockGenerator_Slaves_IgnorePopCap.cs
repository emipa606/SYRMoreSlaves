using System.Collections.Generic;
using System.Linq;
using RimWorld;
using Verse;

namespace MoreSlaves;

public class StockGenerator_Slaves_IgnorePopCap : StockGenerator
{
    public PawnKindDef slaveKindDef;

    public override IEnumerable<Thing> GenerateThings(int forTile, Faction faction = null)
    {
        var count = MoreSlavesSettings.slaveCount.RandomInRange;
        for (var i = 0; i < count; i++)
        {
            if (!Find.FactionManager.AllFactionsVisible
                    .Where(fac => fac != Faction.OfPlayer && fac.def.humanlikeFaction).TryRandomElement(out var result))
            {
                break;
            }

            var developmentalStage = Find.Storyteller.difficulty.ChildrenAllowed
                ? DevelopmentalStage.Child | DevelopmentalStage.Adult
                : DevelopmentalStage.Adult;
            var request = new PawnGenerationRequest(slaveKindDef ?? PawnKindDefOf.Slave, result,
                PawnGenerationContext.NonPlayer, forTile, false, false, false, true, false, 1f, !trader.orbital, true,
                false, true, true, false, false, false, false, 0f, 0f, null, 1f, null, null, null, null, null, null,
                null, null, null, null, null, null, false, false, false, false, null, null, null, null, null, 0f,
                developmentalStage);
            yield return PawnGenerator.GeneratePawn(request);
        }
    }

    public override bool HandlesThingDef(ThingDef thingDef)
    {
        if (thingDef.category == ThingCategory.Pawn && thingDef.race.Humanlike)
        {
            return (int)thingDef.tradeability > 0;
        }

        return false;
    }
}