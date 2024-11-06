using Mlie;
using UnityEngine;
using Verse;

namespace MoreSlaves;

public class MoreSlaves : Mod
{
    public static MoreSlavesSettings settings;
    private static string currentVersion;

    public MoreSlaves(ModContentPack content)
        : base(content)
    {
        settings = GetSettings<MoreSlavesSettings>();
        currentVersion = VersionFromManifest.GetVersionFromModMetaData(content.ModMetaData);
    }

    public override string SettingsCategory()
    {
        return "MoreSlavesSettingsLabel".Translate();
    }

    public override void DoSettingsWindowContents(Rect inRect)
    {
        var listing_Standard = new Listing_Standard();
        listing_Standard.Begin(inRect);
        listing_Standard.Label("MoreSlavesSettingSlaveCount".Translate(), -1f,
            "MoreSlavesSettingsSlaveCountTooltip".Translate());
        listing_Standard.IntRange(ref MoreSlavesSettings.slaveCount, 0, 20);
        if (currentVersion != null)
        {
            listing_Standard.Gap();
            GUI.contentColor = Color.gray;
            listing_Standard.Label("MoreSlavesCurrentModVersion".Translate(currentVersion));
            GUI.contentColor = Color.white;
        }

        listing_Standard.End();
    }
}