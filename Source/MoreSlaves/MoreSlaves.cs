using Mlie;
using UnityEngine;
using Verse;

namespace MoreSlaves;

public class MoreSlaves : Mod
{
    public static MoreSlavesSettings Settings;
    private static string currentVersion;

    public MoreSlaves(ModContentPack content)
        : base(content)
    {
        Settings = GetSettings<MoreSlavesSettings>();
        currentVersion = VersionFromManifest.GetVersionFromModMetaData(content.ModMetaData);
    }

    public override string SettingsCategory()
    {
        return "MoreSlavesSettingsLabel".Translate();
    }

    public override void DoSettingsWindowContents(Rect inRect)
    {
        var listingStandard = new Listing_Standard();
        listingStandard.Begin(inRect);
        listingStandard.Label("MoreSlavesSettingSlaveCount".Translate(), -1f,
            "MoreSlavesSettingsSlaveCountTooltip".Translate());
        listingStandard.IntRange(ref Settings.SlaveCount, 0, 20);
        if (currentVersion != null)
        {
            listingStandard.Gap();
            GUI.contentColor = Color.gray;
            listingStandard.Label("MoreSlavesCurrentModVersion".Translate(currentVersion));
            GUI.contentColor = Color.white;
        }

        listingStandard.End();
    }
}