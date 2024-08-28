using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Argos.Common.GlobalItems;

public class CactusPickaxe : GlobalItem
{
    public override bool AppliesToEntity(Item item, bool lateInstantiation) {
        return item.type == ItemID.CactusPickaxe;
    }

    public override void SetDefaults(Item item) {
        item.StatsModifiedBy.Add(Mod);
        item.tileBoost = -1;
    }
}

public class CopperPickaxe : GlobalItem
{
    public override bool AppliesToEntity(Item item, bool lateInstantiation) {
        return item.type == ItemID.CopperPickaxe;
    }

    public override void SetDefaults(Item item) {
        item.StatsModifiedBy.Add(Mod);
        item.tileBoost = 0;
    }
}

public class Zenith : GlobalItem
{
    public override bool AppliesToEntity(Item item, bool lateInstantiation) {
        return item.type == ItemID.Zenith;
    }

    public override void SetDefaults(Item item)
    {
        if (EnabledMods.AnyContentModEnabled)
        {
            return;
        }

        item.useTime = 1;  // is originally 30, :troll:
    }
}
