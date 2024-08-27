using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Argos.Common.RecipeEdits.Terraria;

public class Armor : GlobalItem
{
    public override void AddRecipes()
    {
        RecipeHelper.AddRecipe(ItemID.WoodHelmet, [(ItemID.Wood, 22), (ItemID.ClayBlock, 10)], [TileID.WorkBenches]);
        RecipeHelper.AddRecipe(ItemID.WoodBreastplate, [(ItemID.Wood, 35), (ItemID.ClayBlock, 24)],
                [TileID.WorkBenches]);
        RecipeHelper.AddRecipe(ItemID.WoodGreaves, [(ItemID.Wood, 28), (ItemID.ClayBlock, 16)], [TileID.WorkBenches]);

        RecipeHelper.AddRecipe(ItemID.NecroHelmet, [(ItemID.Cobweb, 75), (ItemID.Bone, 50), (ItemID.Spike, 20)], [TileID.BoneWelder]);
        RecipeHelper.AddRecipe(ItemID.NecroBreastplate, [(ItemID.Cobweb, 95), (ItemID.Bone, 75), (ItemID.Spike, 35)], [TileID.BoneWelder]);
        RecipeHelper.AddRecipe(ItemID.NecroGreaves, [(ItemID.Cobweb, 80), (ItemID.Bone, 60), (ItemID.Spike, 28)], [TileID.BoneWelder]);

        RecipeHelper.AddRecipe(ItemID.CopperHelmet, [(ItemID.CopperBar, 18)], [TileID.Anvils]);
        RecipeHelper.AddRecipe(ItemID.CopperChainmail, [(ItemID.CopperBar, 30)], [TileID.Anvils]);
        RecipeHelper.AddRecipe(ItemID.CopperGreaves, [(ItemID.CopperBar, 24)], [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.TinHelmet, [(ItemID.TinBar, 18)], [TileID.Anvils]);
        RecipeHelper.AddRecipe(ItemID.TinChainmail, [(ItemID.TinBar, 30)], [TileID.Anvils]);
        RecipeHelper.AddRecipe(ItemID.TinGreaves, [(ItemID.TinBar, 24)], [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.IronHelmet, [(ItemID.IronBar, 18)], [TileID.Anvils]);
        RecipeHelper.AddRecipe(ItemID.IronChainmail, [(ItemID.IronBar, 30)], [TileID.Anvils]);
        RecipeHelper.AddRecipe(ItemID.IronGreaves, [(ItemID.IronBar, 24)], [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.LeadHelmet, [(ItemID.LeadBar, 18)], [TileID.Anvils]);
        RecipeHelper.AddRecipe(ItemID.LeadChainmail, [(ItemID.LeadBar, 30)], [TileID.Anvils]);
        RecipeHelper.AddRecipe(ItemID.LeadGreaves, [(ItemID.LeadBar, 24)], [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.SilverHelmet, [(ItemID.SilverBar, 18), (ItemID.Sapphire, 2)], [TileID.Anvils]);
        RecipeHelper.AddRecipe(ItemID.SilverChainmail, [(ItemID.SilverBar, 30), (ItemID.Emerald, 1)], [TileID.Anvils]);
        RecipeHelper.AddRecipe(ItemID.SilverGreaves, [(ItemID.SilverBar, 24), (ItemID.Silk, 6)], [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.TungstenHelmet, [(ItemID.TungstenBar, 18), (ItemID.Sapphire, 2)], [TileID.Anvils]);
        RecipeHelper.AddRecipe(ItemID.TungstenChainmail, [(ItemID.TungstenBar, 30), (ItemID.Emerald, 1)], [TileID.Anvils]);
        RecipeHelper.AddRecipe(ItemID.TungstenGreaves, [(ItemID.TungstenBar, 24), (ItemID.Silk, 6)], [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.GoldHelmet, [(ItemID.GoldBar, 18), (ItemID.Ruby, 2)], [TileID.Anvils]);
        RecipeHelper.AddRecipe(ItemID.GoldChainmail, [(ItemID.GoldBar, 30), (ItemID.Ruby, 1)], [TileID.Anvils]);
        RecipeHelper.AddRecipe(ItemID.GoldGreaves, [(ItemID.GoldBar, 24), (ItemID.Silk, 6)], [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.PlatinumHelmet, [(ItemID.PlatinumBar, 18), (ItemID.Ruby, 2)], [TileID.Anvils]);
        RecipeHelper.AddRecipe(ItemID.PlatinumChainmail, [(ItemID.PlatinumBar, 30), (ItemID.Ruby, 1)], [TileID.Anvils]);
        RecipeHelper.AddRecipe(ItemID.PlatinumGreaves, [(ItemID.PlatinumBar, 24), (ItemID.Silk, 6)], [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.CobaltHelmet, [(ItemID.CobaltBar, 18)], [TileID.MythrilAnvil], recipeGroups:[("CopperHelmet", 1)]);
        RecipeHelper.AddRecipe(ItemID.CobaltHat, [(ItemID.CobaltBar, 18)], [TileID.MythrilAnvil], recipeGroups:[("CopperHelmet", 1)]);
        RecipeHelper.AddRecipe(ItemID.CobaltMask, [(ItemID.CobaltBar, 18)], [TileID.MythrilAnvil], recipeGroups:[("CopperHelmet", 1)]);
        RecipeHelper.AddRecipe(ItemID.CobaltBreastplate, [(ItemID.CobaltBar, 30)], [TileID.MythrilAnvil], recipeGroups:[("CopperChainmail", 1)]);
        RecipeHelper.AddRecipe(ItemID.CobaltLeggings, [(ItemID.CobaltBar, 24)], [TileID.MythrilAnvil], recipeGroups:[("CopperGreaves", 1)]);

        RecipeHelper.AddRecipe(ItemID.PalladiumHelmet, [(ItemID.PalladiumBar, 18)], [TileID.MythrilAnvil], recipeGroups:[("CopperHelmet", 1)]);
        RecipeHelper.AddRecipe(ItemID.PalladiumHeadgear, [(ItemID.PalladiumBar, 18)], [TileID.MythrilAnvil], recipeGroups:[("CopperHelmet", 1)]);
        RecipeHelper.AddRecipe(ItemID.PalladiumMask, [(ItemID.PalladiumBar, 18)], [TileID.MythrilAnvil], recipeGroups:[("CopperHelmet", 1)]);
        RecipeHelper.AddRecipe(ItemID.PalladiumBreastplate, [(ItemID.PalladiumBar, 30)], [TileID.MythrilAnvil], recipeGroups:[("CopperChainmail", 1)]);
        RecipeHelper.AddRecipe(ItemID.PalladiumLeggings, [(ItemID.PalladiumBar, 24)], [TileID.MythrilAnvil], recipeGroups:[("CopperGreaves", 1)]);

        RecipeHelper.AddRecipe(ItemID.MythrilHelmet, [(ItemID.MythrilBar, 18)], [TileID.MythrilAnvil], recipeGroups:[("IronHelmet", 1)]);
        RecipeHelper.AddRecipe(ItemID.MythrilHat, [(ItemID.MythrilBar, 18)], [TileID.MythrilAnvil], recipeGroups:[("IronHelmet", 1)]);
        RecipeHelper.AddRecipe(ItemID.MythrilHood, [(ItemID.MythrilBar, 18)], [TileID.MythrilAnvil], recipeGroups:[("IronHelmet", 1)]);
        RecipeHelper.AddRecipe(ItemID.MythrilChainmail, [(ItemID.MythrilBar, 30), (ItemID.AncientBattleArmorMaterial, 1)], [TileID.MythrilAnvil], recipeGroups:[("IronChainmail", 1)]);
        RecipeHelper.AddRecipe(ItemID.MythrilGreaves, [(ItemID.MythrilBar, 24)], [TileID.MythrilAnvil], recipeGroups:[("IronGreaves", 1)]);

        RecipeHelper.AddRecipe(ItemID.OrichalcumHelmet, [(ItemID.OrichalcumBar, 18)], [TileID.MythrilAnvil], recipeGroups:[("IronHelmet", 1)]);
        RecipeHelper.AddRecipe(ItemID.OrichalcumHeadgear, [(ItemID.OrichalcumBar, 18)], [TileID.MythrilAnvil], recipeGroups:[("IronHelmet", 1)]);
        RecipeHelper.AddRecipe(ItemID.OrichalcumMask, [(ItemID.OrichalcumBar, 18)], [TileID.MythrilAnvil], recipeGroups:[("IronHelmet", 1)]);
        RecipeHelper.AddRecipe(ItemID.OrichalcumBreastplate, [(ItemID.OrichalcumBar, 30), (ItemID.AncientBattleArmorMaterial, 1)], [TileID.MythrilAnvil], recipeGroups:[("IronChainmail", 1)]);
        RecipeHelper.AddRecipe(ItemID.OrichalcumLeggings, [(ItemID.OrichalcumBar, 24)], [TileID.MythrilAnvil], recipeGroups:[("IronGreaves", 1)]);

        RecipeHelper.AddRecipe(ItemID.AdamantiteHelmet, [(ItemID.AdamantiteBar, 18)], [TileID.MythrilAnvil], recipeGroups:[("SilverHelmet", 1)]);
        RecipeHelper.AddRecipe(ItemID.AdamantiteMask, [(ItemID.AdamantiteBar, 18)], [TileID.MythrilAnvil], recipeGroups:[("SilverHelmet", 1)]);
        RecipeHelper.AddRecipe(ItemID.AdamantiteHeadgear, [(ItemID.AdamantiteBar, 18)], [TileID.MythrilAnvil], recipeGroups:[("SilverHelmet", 1)]);
        RecipeHelper.AddRecipe(ItemID.AdamantiteBreastplate, [(ItemID.AdamantiteBar, 30), (ItemID.FrostCore, 1)], [TileID.MythrilAnvil], recipeGroups:[("SilverChainmail", 1)]);
        RecipeHelper.AddRecipe(ItemID.AdamantiteLeggings, [(ItemID.AdamantiteBar, 24)], [TileID.MythrilAnvil], recipeGroups:[("SilverGreaves", 1)]);

        RecipeHelper.AddRecipe(ItemID.TitaniumHelmet, [(ItemID.TitaniumBar, 18)], [TileID.MythrilAnvil], recipeGroups:[("SilverHelmet", 1)]);
        RecipeHelper.AddRecipe(ItemID.TitaniumHeadgear, [(ItemID.TitaniumBar, 18)], [TileID.MythrilAnvil], recipeGroups:[("SilverHelmet", 1)]);
        RecipeHelper.AddRecipe(ItemID.TitaniumMask, [(ItemID.TitaniumBar, 18)], [TileID.MythrilAnvil], recipeGroups:[("SilverHelmet", 1)]);
        RecipeHelper.AddRecipe(ItemID.TitaniumBreastplate, [(ItemID.TitaniumBar, 30), (ItemID.FrostCore, 1)], [TileID.MythrilAnvil], recipeGroups:[("SilverChainmail", 1)]);
        RecipeHelper.AddRecipe(ItemID.TitaniumLeggings, [(ItemID.TitaniumBar, 24)], [TileID.MythrilAnvil], recipeGroups:[("SilverGreaves", 1)]);

        RecipeHelper.AddRecipe(ItemID.HallowedHelmet, [(ItemID.HallowedBar, 18)], [TileID.MythrilAnvil], recipeGroups:[("GoldHelmet", 1)]);
        RecipeHelper.AddRecipe(ItemID.HallowedHeadgear, [(ItemID.HallowedBar, 18)], [TileID.MythrilAnvil], recipeGroups:[("GoldHelmet", 1)]);
        RecipeHelper.AddRecipe(ItemID.HallowedHood, [(ItemID.HallowedBar, 18)], [TileID.MythrilAnvil], recipeGroups:[("GoldHelmet", 1)]);
        RecipeHelper.AddRecipe(ItemID.HallowedMask, [(ItemID.HallowedBar, 18)], [TileID.MythrilAnvil], recipeGroups:[("GoldHelmet", 1)]);
        RecipeHelper.AddRecipe(ItemID.HallowedPlateMail, [(ItemID.HallowedBar, 30), (ItemID.RedCape, 1)], [TileID.MythrilAnvil], recipeGroups:[("GoldChainmail", 1)]);
        RecipeHelper.AddRecipe(ItemID.HallowedGreaves, [(ItemID.HallowedBar, 24), (ItemID.AsphaltBlock, 35)], [TileID.MythrilAnvil], recipeGroups:[("GoldGreaves", 1)]);

        RecipeHelper.AddRecipe(ItemID.MeteorHelmet,
                [(ItemID.MeteoriteBar, 12), (ItemID.Lens, 2), (ItemID.Obsidian, 15)], [TileID.Anvils]);
        RecipeHelper.AddRecipe(ItemID.MeteorSuit, [(ItemID.MeteoriteBar, 25), (ItemID.Obsidian, 20)], [TileID.Anvils]);
        RecipeHelper.AddRecipe(ItemID.MeteorLeggings, [(ItemID.MeteoriteBar, 20), (ItemID.Obsidian, 15)],
                [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.BeeHeadgear, [(ItemID.BeeWax, 10), (ItemID.Stinger, 12)],
                [TileID.HoneyDispenser]);
        RecipeHelper.AddRecipe(ItemID.BeeBreastplate,
                [(ItemID.BeeWax, 14), (ItemID.Stinger, 16), (ItemID.BottledHoney, 8)], [TileID.HoneyDispenser]);
        RecipeHelper.AddRecipe(ItemID.BeeGreaves, [(ItemID.BeeWax, 12), (ItemID.Stinger, 10)], [TileID.HoneyDispenser]);

        RecipeHelper.AddRecipe(ItemID.MoltenHelmet,
                [(ItemID.HellstoneBar, 20), (ItemID.LavaBucket, 12), (ItemID.AshWoodHelmet, 1)], [TileID.Hellforge],
                [Condition.NearLava]);
        RecipeHelper.AddRecipe(ItemID.MoltenBreastplate,
                [(ItemID.HellstoneBar, 30), (ItemID.LavaBucket, 20), (ItemID.AshWoodBreastplate, 1)],
                [TileID.Hellforge], [Condition.NearLava]);
        RecipeHelper.AddRecipe(ItemID.MoltenGreaves,
                [(ItemID.HellstoneBar, 25), (ItemID.LavaBucket, 16), (ItemID.AshWoodGreaves, 1)], [TileID.Hellforge],
                [Condition.NearLava]);

        RecipeHelper.AddRecipe(ItemID.JungleHat,
                [(ItemID.JungleSpores, 10), (ItemID.Vine, 3), (ItemID.RichMahoganyHelmet, 1)], [TileID.LivingLoom]);
        RecipeHelper.AddRecipe(ItemID.JungleShirt,
                [(ItemID.JungleSpores, 22), (ItemID.Stinger, 8), (ItemID.Vine, 3), (ItemID.RichMahoganyBreastplate, 1)],
                [TileID.LivingLoom]);
        RecipeHelper.AddRecipe(ItemID.JunglePants,
                [(ItemID.JungleSpores, 16), (ItemID.Stinger, 2), (ItemID.Vine, 2), (ItemID.RichMahoganyGreaves, 1)],
                [TileID.LivingLoom]);

        RecipeHelper.AddRecipe(ItemID.VortexHelmet, [(ItemID.FragmentVortex, 12), (ItemID.LunarBar, 10)],
                recipeGroups: [("ShroomiteHelmet", 1)], tiles: [TileID.LunarCraftingStation]);
        RecipeHelper.AddRecipe(ItemID.VortexBreastplate,
                [(ItemID.FragmentVortex, 24), (ItemID.LunarBar, 20), (ItemID.ShroomiteBreastplate, 1)],
                [TileID.LunarCraftingStation]);
        RecipeHelper.AddRecipe(ItemID.VortexLeggings,
                [(ItemID.FragmentVortex, 18), (ItemID.LunarBar, 14), (ItemID.ShroomiteLeggings, 1)],
                [TileID.LunarCraftingStation]);

        RecipeHelper.AddRecipe(ItemID.SolarFlareHelmet,
                [(ItemID.FragmentSolar, 12), (ItemID.LunarBar, 10), (ItemID.BeetleHelmet, 1)],
                [TileID.LunarCraftingStation]);
        RecipeHelper.AddRecipe(ItemID.SolarFlareBreastplate, [(ItemID.FragmentSolar, 24), (ItemID.LunarBar, 20)],
                recipeGroups: [("BeetleScaleMail", 1)], tiles: [TileID.LunarCraftingStation]);
        RecipeHelper.AddRecipe(ItemID.SolarFlareLeggings,
                [(ItemID.FragmentSolar, 18), (ItemID.LunarBar, 14), (ItemID.BeetleLeggings, 1)],
                [TileID.LunarCraftingStation]);

        RecipeHelper.AddRecipe(ItemID.NebulaHelmet, [(ItemID.FragmentNebula, 12), (ItemID.LunarBar, 10)],
                recipeGroups: [("SpectreMask", 1)], tiles: [TileID.LunarCraftingStation]);
        RecipeHelper.AddRecipe(ItemID.NebulaBreastplate,
                [(ItemID.FragmentNebula, 24), (ItemID.LunarBar, 20), (ItemID.SpectreRobe, 1)],
                [TileID.LunarCraftingStation]);
        RecipeHelper.AddRecipe(ItemID.NebulaLeggings,
                [(ItemID.FragmentNebula, 18), (ItemID.LunarBar, 14), (ItemID.SpectrePants, 1)],
                [TileID.LunarCraftingStation]);

        RecipeHelper.AddRecipe(ItemID.StardustHelmet,
                [(ItemID.FragmentStardust, 12), (ItemID.LunarBar, 10), (ItemID.TikiMask, 1), (ItemID.SpookyHelmet, 1)],
                [TileID.LunarCraftingStation]);
        RecipeHelper.AddRecipe(ItemID.StardustBreastplate, [
                (ItemID.FragmentStardust, 24), (ItemID.LunarBar, 20), (ItemID.TikiShirt, 1),
                (ItemID.SpookyBreastplate, 1)
        ], [TileID.LunarCraftingStation]);
        RecipeHelper.AddRecipe(ItemID.StardustLeggings, [
                (ItemID.FragmentStardust, 18), (ItemID.LunarBar, 14), (ItemID.TikiPants, 1), (ItemID.SpookyLeggings, 1)
        ], [TileID.LunarCraftingStation]);
    }
}
