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

        RecipeHelper.AddRecipe(ItemID.BorealWoodHelmet, [(ItemID.BorealWood, 22), (ItemID.SnowBlock, 20)], [TileID.WorkBenches]);
        RecipeHelper.AddRecipe(ItemID.BorealWoodBreastplate, [(ItemID.BorealWood, 35), (ItemID.SnowBlock, 48)],
                [TileID.WorkBenches]);
        RecipeHelper.AddRecipe(ItemID.BorealWoodGreaves, [(ItemID.BorealWood, 28), (ItemID.SnowBlock, 32)], [TileID.WorkBenches]);

        RecipeHelper.AddRecipe(ItemID.RichMahoganyHelmet, [(ItemID.RichMahogany, 22), (ItemID.BambooBlock, 20)], [TileID.WorkBenches]);
        RecipeHelper.AddRecipe(ItemID.RichMahoganyBreastplate, [(ItemID.RichMahogany, 35), (ItemID.BambooBlock, 48)],
                [TileID.WorkBenches]);
        RecipeHelper.AddRecipe(ItemID.RichMahoganyGreaves, [(ItemID.RichMahogany, 28), (ItemID.BambooBlock, 32)], [TileID.WorkBenches]);

        RecipeHelper.AddRecipe(ItemID.AshWoodHelmet, [(ItemID.AshWood, 22), (ItemID.AshBlock, 100)], [TileID.Hellforge]);
        RecipeHelper.AddRecipe(ItemID.AshWoodBreastplate, [(ItemID.AshWood, 35), (ItemID.AshBlock, 100)], [TileID.Hellforge]);
        RecipeHelper.AddRecipe(ItemID.AshWoodGreaves, [(ItemID.AshWood, 28), (ItemID.AshBlock, 100)], [TileID.Hellforge]);

        RecipeHelper.AddRecipe(ItemID.PalmWoodHelmet, [(ItemID.PalmWood, 22), (ItemID.SandBlock, 20)], [TileID.WorkBenches]);
        RecipeHelper.AddRecipe(ItemID.PalmWoodBreastplate, [(ItemID.PalmWood, 35), (ItemID.SandBlock, 48)],
                [TileID.WorkBenches]);
        RecipeHelper.AddRecipe(ItemID.PalmWoodGreaves, [(ItemID.PalmWood, 28), (ItemID.SandBlock, 32)], [TileID.WorkBenches]);

        RecipeHelper.AddRecipe(ItemID.CactusHelmet, [(ItemID.Cactus, 22), (ItemID.Waterleaf, 4)], [TileID.WorkBenches]);
        RecipeHelper.AddRecipe(ItemID.CactusBreastplate, [(ItemID.Cactus, 35), (ItemID.Waterleaf, 8), (ItemID.ThornsPotion, 1)],
                [TileID.WorkBenches]);
        RecipeHelper.AddRecipe(ItemID.CactusLeggings, [(ItemID.Cactus, 28), (ItemID.Waterleaf, 6)], [TileID.WorkBenches]);

        RecipeHelper.AddRecipe(ItemID.ShadewoodHelmet, [(ItemID.Shadewood, 22), (ItemID.ViciousPowder, 5)], [TileID.WorkBenches]);
        RecipeHelper.AddRecipe(ItemID.ShadewoodBreastplate, [(ItemID.Shadewood, 35), (ItemID.ViciousPowder, 8)],
                [TileID.WorkBenches]);
        RecipeHelper.AddRecipe(ItemID.ShadewoodGreaves, [(ItemID.Shadewood, 28), (ItemID.ViciousPowder, 6)], [TileID.WorkBenches]);

        RecipeHelper.AddRecipe(ItemID.EbonwoodHelmet, [(ItemID.Ebonwood, 22), (ItemID.VilePowder, 5)], [TileID.WorkBenches]);
        RecipeHelper.AddRecipe(ItemID.EbonwoodBreastplate, [(ItemID.Ebonwood, 35), (ItemID.VilePowder, 8)],
                [TileID.WorkBenches]);
        RecipeHelper.AddRecipe(ItemID.EbonwoodGreaves, [(ItemID.Ebonwood, 28), (ItemID.VilePowder, 6)], [TileID.WorkBenches]);

        RecipeHelper.AddRecipe(ItemID.PearlwoodHelmet, [(ItemID.Pearlwood, 22), (ItemID.WhitePearl, 1), (ItemID.UnicornHorn, 1)], [TileID.WorkBenches]);
        RecipeHelper.AddRecipe(ItemID.PearlwoodBreastplate, [(ItemID.Pearlwood, 35), (ItemID.WhitePearl, 1)],
                [TileID.WorkBenches]);
        RecipeHelper.AddRecipe(ItemID.PearlwoodGreaves, [(ItemID.Pearlwood, 28), (ItemID.WhitePearl, 1)], [TileID.WorkBenches]);

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

        RecipeHelper.AddRecipe(ItemID.ShadowHelmet, [(ItemID.EbonwoodHelmet, 1), (ItemID.DemoniteBar, 18), (ItemID.ShadowScale, 12), (ItemID.VilePowder, 3)], [TileID.Anvils], [Condition.InCorrupt]);
        RecipeHelper.AddRecipe(ItemID.ShadowScalemail, [(ItemID.EbonwoodBreastplate, 1), (ItemID.DemoniteBar, 30), (ItemID.ShadowScale, 22), (ItemID.VilePowder, 3)], [TileID.Anvils], [Condition.InCorrupt]);
        RecipeHelper.AddRecipe(ItemID.ShadowGreaves, [(ItemID.EbonwoodGreaves, 1), (ItemID.DemoniteBar, 24), (ItemID.ShadowScale, 18), (ItemID.VilePowder, 3)], [TileID.Anvils], [Condition.InCorrupt]);

        RecipeHelper.AddRecipe(ItemID.CrimsonHelmet, [(ItemID.ShadewoodHelmet, 1), (ItemID.CrimtaneBar, 18), (ItemID.TissueSample, 12), (ItemID.ViciousPowder, 3)], [TileID.Anvils], [Condition.InCrimson]);
        RecipeHelper.AddRecipe(ItemID.CrimsonScalemail, [(ItemID.ShadewoodBreastplate, 1), (ItemID.CrimtaneBar, 30), (ItemID.TissueSample, 22), (ItemID.ViciousPowder, 3)], [TileID.Anvils], [Condition.InCrimson]);
        RecipeHelper.AddRecipe(ItemID.CrimsonGreaves, [(ItemID.ShadewoodGreaves, 1), (ItemID.CrimtaneBar, 24), (ItemID.TissueSample, 18), (ItemID.ViciousPowder, 3)], [TileID.Anvils], [Condition.InCrimson]);

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

        RecipeHelper.AddRecipe(ItemID.AncientHallowedHelmet, [(ItemID.HallowedBar, 18)], [TileID.MythrilAnvil], recipeGroups:[("GoldHelmet", 1)]);
        RecipeHelper.AddRecipe(ItemID.AncientHallowedHeadgear, [(ItemID.HallowedBar, 18)], [TileID.MythrilAnvil], recipeGroups:[("GoldHelmet", 1)]);
        RecipeHelper.AddRecipe(ItemID.AncientHallowedHood, [(ItemID.HallowedBar, 18)], [TileID.MythrilAnvil], recipeGroups:[("GoldHelmet", 1)]);
        RecipeHelper.AddRecipe(ItemID.AncientHallowedMask, [(ItemID.HallowedBar, 18)], [TileID.MythrilAnvil], recipeGroups:[("GoldHelmet", 1)]);
        RecipeHelper.AddRecipe(ItemID.AncientHallowedPlateMail, [(ItemID.HallowedBar, 30)], [TileID.MythrilAnvil], recipeGroups:[("GoldChainmail", 1)]);
        RecipeHelper.AddRecipe(ItemID.AncientHallowedGreaves, [(ItemID.HallowedBar, 24), (ItemID.AsphaltBlock, 35)], [TileID.MythrilAnvil], recipeGroups:[("GoldGreaves", 1)]);

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

        RecipeHelper.AddRecipe(ItemID.SpookyHelmet, [(ItemID.SpookyWood, 222), (ItemID.SpectreBar, 15), (ItemID.PumpkinHelmet, 1)],
                [TileID.MythrilAnvil]);
        RecipeHelper.AddRecipe(ItemID.SpookyBreastplate,
                [(ItemID.SpookyWood, 444), (ItemID.SpectreBar, 25), (ItemID.SpookyTwig, 1), (ItemID.PumpkinHelmet, 1)], [TileID.MythrilAnvil]);
        RecipeHelper.AddRecipe(ItemID.SpookyLeggings, [(ItemID.SpookyWood, 333), (ItemID.SpectreBar, 20), (ItemID.PumpkinLeggings, 1)], [TileID.MythrilAnvil]);

        RecipeHelper.AddRecipe(ItemID.PumpkinHelmet, [(ItemID.Pumpkin, 40), (ItemID.GrassSeeds, 100), (ItemID.YellowMarigold, 1)], [TileID.LivingLoom]);
        RecipeHelper.AddRecipe(ItemID.PumpkinBreastplate,  [(ItemID.Pumpkin, 85), (ItemID.GrassSeeds, 150), (ItemID.YellowMarigold, 2)], [TileID.LivingLoom]);
        RecipeHelper.AddRecipe(ItemID.PumpkinLeggings, [(ItemID.Pumpkin, 50), (ItemID.GrassSeeds, 120), (ItemID.YellowMarigold, 2)], [TileID.LivingLoom]);

        RecipeHelper.AddRecipe(ItemID.FossilHelm, [(ItemID.FossilOre, 25), (ItemID.AntlionMandible, 6), (ItemID.Amber, 1)], [TileID.Anvils]);
        RecipeHelper.AddRecipe(ItemID.FossilShirt,  [(ItemID.FossilOre, 30), (ItemID.AntlionMandible, 14), (ItemID.Amber, 2)], [TileID.Anvils]);
        RecipeHelper.AddRecipe(ItemID.FossilPants, [(ItemID.FossilOre, 20), (ItemID.AntlionMandible, 11), (ItemID.Amber, 1)], [TileID.Anvils]);

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

        RecipeHelper.AddRecipe(ItemID.TurtleHelmet,
                [(ItemID.ChlorophyteBar, 16), (ItemID.MoltenHelmet, 1)],
                [TileID.MythrilAnvil]);
        RecipeHelper.AddRecipe(ItemID.TurtleScaleMail, [(ItemID.ChlorophyteBar, 26), (ItemID.MoltenBreastplate, 1), (ItemID.TortoiseBanner, 1)],
                [TileID.MythrilAnvil]);
        RecipeHelper.AddRecipe(ItemID.TurtleLeggings,
                [(ItemID.ChlorophyteBar, 20), (ItemID.MoltenGreaves, 1)],
                [TileID.MythrilAnvil]);

        RecipeHelper.AddRecipe(ItemID.SpiderMask, [(ItemID.SpiderFang, 20), (ItemID.BeeHeadgear, 1), (ItemID.Cobweb, 250)], [TileID.MythrilAnvil]);
        RecipeHelper.AddRecipe(ItemID.SpiderBreastplate, [(ItemID.SpiderFang, 14), (ItemID.BeeBreastplate, 1), (ItemID.BlackRecluseBanner, 1), (ItemID.Cobweb, 500)], [TileID.MythrilAnvil]);
        RecipeHelper.AddRecipe(ItemID.SpiderGreaves, [(ItemID.SpiderFang, 16), (ItemID.BeeGreaves, 1), (ItemID.Cobweb, 375)], [TileID.MythrilAnvil]);

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

        RecipeHelper.AddRecipe(ItemID.Robe,
                [(ItemID.Silk, 25), (ItemID.BlueDye, 2), (ItemID.RedDye, 1)], [TileID.Loom]);

        RecipeHelper.AddRecipe(ItemID.AmethystRobe, [(ItemID.Robe, 1), (ItemID.Amethyst, 15)], [TileID.Loom]);
        RecipeHelper.AddRecipe(ItemID.TopazRobe, [(ItemID.AmethystRobe, 1), (ItemID.Topaz, 15)], [TileID.Loom]);
        RecipeHelper.AddRecipe(ItemID.SapphireRobe, [(ItemID.TopazRobe, 1), (ItemID.Sapphire, 15)], [TileID.Loom]);
        RecipeHelper.AddRecipe(ItemID.EmeraldRobe, [(ItemID.SapphireRobe, 1), (ItemID.Emerald, 15)], [TileID.Loom]);
        RecipeHelper.AddRecipe(ItemID.RubyRobe, [(ItemID.EmeraldRobe, 1), (ItemID.Ruby, 15)], [TileID.Loom]);
        RecipeHelper.AddRecipe(ItemID.AmberRobe, [(ItemID.RubyRobe, 1), (ItemID.Amber, 15)], [TileID.Loom]);
        RecipeHelper.AddRecipe(ItemID.DiamondRobe, [(ItemID.AmberRobe, 1), (ItemID.Diamond, 15)], [TileID.Loom]);
    }
}
