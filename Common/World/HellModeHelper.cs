using Argos.Common.Config;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Argos.Common.World;

public abstract class HellModeModified : GlobalItem
{
    private static string RecipeChanged => "Changed by Argos - Hell Mode";

    public override bool IsLoadingEnabled(Mod mod)
    {
        return ModContent.GetInstance<ArgosConfig>().HellMode;
    }

    public override void ModifyTooltips(Item item,
            List<TooltipLine> tooltips)
    {
        tooltips.Add(new TooltipLine(Mod, "Tooltip0", RecipeChanged) { OverrideColor = Colors.RarityRed });
    }
}

public class TorchHell : HellModeModified
{
    public override bool AppliesToEntity(Item item,
            bool lateInstantiation)
    {
        return item.type == ItemID.Torch;
    }
}

public class EnchantedNightcrawlerHell : HellModeModified
{
    public override bool AppliesToEntity(Item item,
            bool lateInstantiation)
    {
        return item.type == ItemID.EnchantedNightcrawler;
    }
}

public class ZenithHell : HellModeModified
{
    public override bool AppliesToEntity(Item item,
            bool lateInstantiation)
    {
        return item.type == ItemID.Zenith;
    }
}
