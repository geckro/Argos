﻿using Argos.Common.Config;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Argos.Common.RecipeHelper;

namespace Argos.Common.RecipeEdits;

public class TerrariaEdits : GlobalItem
{
    public override void AddRecipes()
    {
        AddRecipe(ItemID.Magiluminescence, [
                Ingredient(ItemID.Topaz, 10), Ingredient(ItemID.Amber, 8), Ingredient(ItemID.Feather, 4),
                Ingredient(ItemID.YellowDye, 6)
        ], recipeGroups: [RecipeGroup("DemoniteBar", 15)], tiles: [TileID.HeavyWorkBench]);

        AddRecipe(ItemID.WhiteString,
                [Ingredient(ItemID.Cobweb, 40), Ingredient(ItemID.Silk, 5), Ingredient(ItemID.Diamond)], [TileID.Loom]);

        AddRecipe(ItemID.AnkhShield, [
                Ingredient(ItemID.ObsidianShield), Ingredient(ItemID.AnkhCharm), Ingredient(ItemID.FrozenShield),
                Ingredient(ItemID.HeroShield)
        ], [TileID.MythrilAnvil], [Condition.InAether]);

        AddRecipe(ItemID.AnkhCharm, [
                Ingredient(ItemID.ArmorBracing), Ingredient(ItemID.MedicatedBandage), Ingredient(ItemID.ThePlan),
                Ingredient(ItemID.CountercurseMantra), Ingredient(ItemID.ReflectiveShades),
                Ingredient(ItemID.PharaohsMask),
                Ingredient(ItemID.PharaohsRobe)
        ], [TileID.MythrilAnvil], [Condition.InDesert]);

        AddRecipe(ItemID.ObsidianSkull, [Ingredient(ItemID.Obsidian, 35), Ingredient(ItemID.Skull)],
                [TileID.Hellforge]);

        AddRecipe(ItemID.SpectreBoots, [Ingredient(ItemID.RocketBoots), Ingredient(ItemID.SkyBlueDye)],
                [TileID.TinkerersWorkbench], recipeGroups:
                [
                        RecipeGroup("HermesBoots")
                ]);

        AddRecipe(ItemID.LightningBoots, [
                Ingredient(ItemID.SpectreBoots), Ingredient(ItemID.AnkletoftheWind), Ingredient(ItemID.Aglet),
                Ingredient(ItemID.FallenStar, 5),
                Ingredient(ItemID.YellowDye)
        ], [TileID.TinkerersWorkbench]);

        AddRecipe(ItemID.FrostsparkBoots,
                [Ingredient(ItemID.LightningBoots), Ingredient(ItemID.IceSkates), Ingredient(ItemID.CyanDye)],
                [TileID.TinkerersWorkbench, TileID.IceMachine]);

        AddRecipe(ItemID.TerrasparkBoots, [
                Ingredient(ItemID.FrostsparkBoots), Ingredient(ItemID.LavaWaders), Ingredient(ItemID.GreenDye),
                Ingredient(ItemID.SwiftnessPotion, 10)
        ], [TileID.TinkerersWorkbench]);

        AddRecipe(ItemID.ObsidianWaterWalkingBoots, [
                Ingredient(ItemID.ObsidianSkull), Ingredient(ItemID.WaterWalkingBoots),
                Ingredient(ItemID.FlameWakerBoots), Ingredient(ItemID.ObsidianSkinPotion, 3)
        ], [TileID.TinkerersWorkbench]);

        AddRecipe(ItemID.RedString,
                [Ingredient(ItemID.WhiteString), Ingredient(ItemID.RedDye, 2), Ingredient(ItemID.Ruby)],
                [TileID.Loom, TileID.DyeVat]);

        AddRecipe(ItemID.SkyBlueString,
                [Ingredient(ItemID.WhiteString), Ingredient(ItemID.SkyBlueDye, 2), Ingredient(ItemID.Sapphire)],
                [TileID.Loom, TileID.DyeVat]);

        AddRecipe(ItemID.OrangeString,
                [Ingredient(ItemID.WhiteString), Ingredient(ItemID.OrangeDye, 2), Ingredient(ItemID.Amber)],
                [TileID.Loom, TileID.DyeVat]);

        AddRecipe(ItemID.GreenString,
                [Ingredient(ItemID.WhiteString), Ingredient(ItemID.GreenDye, 2), Ingredient(ItemID.Emerald)],
                [TileID.Loom, TileID.DyeVat]);

        AddRecipe(ItemID.YellowString,
                [Ingredient(ItemID.WhiteString), Ingredient(ItemID.YellowDye, 2), Ingredient(ItemID.Topaz)],
                [TileID.Loom, TileID.DyeVat]);

        AddRecipe(ItemID.PurpleString,
                [Ingredient(ItemID.WhiteString), Ingredient(ItemID.PurpleDye, 2), Ingredient(ItemID.Amethyst)],
                [TileID.Loom, TileID.DyeVat]);

        AddRecipe(ItemID.RainbowString, [Ingredient(ItemID.WhiteString), Ingredient(ItemID.RainbowDye, 2)],
                [TileID.Loom, TileID.DyeVat]);

        AddRecipe(ItemID.CopperAxe, [Ingredient(ItemID.CopperBar, 8)], recipeGroups: [RecipeGroup("Wood", 6)],
                tiles: [TileID.Anvils]);

        AddRecipe(ItemID.TinAxe, [Ingredient(ItemID.TinBar, 8)], recipeGroups: [RecipeGroup("Wood", 6)],
                tiles: [TileID.Anvils]);

        AddRecipe(ItemID.IronAxe, [Ingredient(ItemID.IronBar, 8)], recipeGroups: [RecipeGroup("CopperAxe")],
                tiles: [TileID.Anvils]);

        AddRecipe(ItemID.LeadAxe, [Ingredient(ItemID.LeadBar, 8)], recipeGroups: [RecipeGroup("CopperAxe")],
                tiles: [TileID.Anvils]);

        AddRecipe(ItemID.SilverAxe, [Ingredient(ItemID.SilverBar, 8), Ingredient(ItemID.Sapphire)],
                recipeGroups: [RecipeGroup("IronAxe")], tiles: [TileID.Anvils]);

        AddRecipe(ItemID.TungstenAxe, [Ingredient(ItemID.TungstenBar, 8), Ingredient(ItemID.Sapphire)],
                recipeGroups: [RecipeGroup("IronAxe")], tiles: [TileID.Anvils]);

        AddRecipe(ItemID.GoldAxe, [Ingredient(ItemID.GoldBar, 8), Ingredient(ItemID.Ruby)],
                recipeGroups: [RecipeGroup("SilverAxe")], tiles: [TileID.HeavyWorkBench]);

        AddRecipe(ItemID.PlatinumAxe, [Ingredient(ItemID.PlatinumBar, 8), Ingredient(ItemID.Ruby)],
                recipeGroups: [RecipeGroup("SilverAxe")], tiles: [TileID.HeavyWorkBench]);

        AddRecipe(ItemID.WarAxeoftheNight, [Ingredient(ItemID.DemoniteBar, 8), Ingredient(ItemID.Ebonwood, 24)],
                recipeGroups: [RecipeGroup("GoldAxe")], tiles: [TileID.DemonAltar], conditions: [Condition.InCorrupt]);

        AddRecipe(ItemID.BloodLustCluster, [Ingredient(ItemID.CrimtaneBar, 8), Ingredient(ItemID.Shadewood, 24)],
                recipeGroups: [RecipeGroup("GoldAxe")], tiles: [TileID.DemonAltar], conditions: [Condition.InCrimson]);

        AddRecipe(ItemID.MoltenHamaxe,
                [Ingredient(ItemID.HellstoneBar, 8), Ingredient(ItemID.AshWood, 24), Ingredient(ItemID.BeeWax, 8)],
                [TileID.Hellforge], [Condition.InUnderworld, Condition.NearLava], [RecipeGroup("WarAxeoftheNight")]);

        AddRecipe(ItemID.CobaltWaraxe, [Ingredient(ItemID.CobaltBar, 16), Ingredient(ItemID.MoltenHamaxe)],
                [TileID.Anvils]);

        AddRecipe(ItemID.PalladiumWaraxe, [Ingredient(ItemID.PalladiumBar, 16), Ingredient(ItemID.MoltenHamaxe)],
                [TileID.Anvils]);

        AddRecipe(ItemID.MythrilWaraxe, [Ingredient(ItemID.MythrilBar, 16)], [TileID.MythrilAnvil],
                recipeGroups: [RecipeGroup("CobaltWaraxe")]);

        AddRecipe(ItemID.OrichalcumWaraxe, [Ingredient(ItemID.OrichalcumBar, 16)], [TileID.MythrilAnvil],
                recipeGroups: [RecipeGroup("CobaltWaraxe")]);

        AddRecipe(ItemID.AdamantiteWaraxe, [Ingredient(ItemID.AdamantiteBar, 16)], [TileID.MythrilAnvil],
                recipeGroups: [RecipeGroup("MythrilWaraxe")]);

        AddRecipe(ItemID.TitaniumWaraxe, [Ingredient(ItemID.TitaniumBar, 16)], [TileID.MythrilAnvil],
                recipeGroups: [RecipeGroup("MythrilWaraxe")]);

        AddRecipe(ItemID.CobaltChainsaw, [Ingredient(ItemID.CobaltBar, 14), Ingredient(ItemID.MoltenHamaxe)],
                [TileID.Anvils]);

        AddRecipe(ItemID.PalladiumChainsaw, [Ingredient(ItemID.PalladiumBar, 14), Ingredient(ItemID.MoltenHamaxe)],
                [TileID.Anvils]);

        AddRecipe(ItemID.MythrilChainsaw, [Ingredient(ItemID.MythrilBar, 14)], [TileID.MythrilAnvil],
                recipeGroups: [RecipeGroup("CobaltChainsaw")]);

        AddRecipe(ItemID.OrichalcumChainsaw, [Ingredient(ItemID.OrichalcumBar, 14)], [TileID.MythrilAnvil],
                recipeGroups: [RecipeGroup("CobaltChainsaw")]);

        AddRecipe(ItemID.AdamantiteChainsaw, [Ingredient(ItemID.AdamantiteBar, 14)], [TileID.MythrilAnvil],
                recipeGroups: [RecipeGroup("MythrilChainsaw")]);

        AddRecipe(ItemID.TitaniumChainsaw, [Ingredient(ItemID.TitaniumBar, 14)], [TileID.MythrilAnvil],
                recipeGroups: [RecipeGroup("MythrilChainsaw")]);

        AddRecipe(ItemID.GrapplingHook, [Ingredient(ItemID.Chain, 6), Ingredient(ItemID.Hook)], [TileID.Anvils],
                recipeGroups: [RecipeGroup("IronBar", 6)]);

        AddRecipe(ItemID.AmethystHook, [Ingredient(ItemID.Amethyst, 15), Ingredient(ItemID.Hook)], [TileID.Anvils],
                recipeGroups: [RecipeGroup("SilverBar", 6)]);

        AddRecipe(ItemID.TopazHook, [Ingredient(ItemID.Topaz, 15), Ingredient(ItemID.Hook)], [TileID.Anvils],
                recipeGroups: [RecipeGroup("SilverBar", 6)]);

        AddRecipe(ItemID.EmeraldHook, [Ingredient(ItemID.Emerald, 15), Ingredient(ItemID.Hook)], [TileID.Anvils],
                recipeGroups: [RecipeGroup("SilverBar", 6)]);

        AddRecipe(ItemID.SapphireHook, [Ingredient(ItemID.Sapphire, 15), Ingredient(ItemID.Hook)], [TileID.Anvils],
                recipeGroups: [RecipeGroup("SilverBar", 6)]);

        AddRecipe(ItemID.RubyHook, [Ingredient(ItemID.Ruby, 15), Ingredient(ItemID.Hook)], [TileID.Anvils],
                recipeGroups: [RecipeGroup("SilverBar", 6)]);

        AddRecipe(ItemID.DiamondHook, [Ingredient(ItemID.Diamond, 15), Ingredient(ItemID.Hook)], [TileID.Anvils],
                recipeGroups: [RecipeGroup("SilverBar", 6)]);

        AddRecipe(ItemID.AmberHook, [Ingredient(ItemID.Amber, 15), Ingredient(ItemID.Hook)], [TileID.Anvils],
                recipeGroups: [RecipeGroup("SilverBar", 6)]);

        AddRecipe(ItemID.CactusPickaxe, [Ingredient(ItemID.Cactus, 20), Ingredient(ItemID.Waterleaf, 3)],
                [TileID.WorkBenches]);

        AddRecipe(ItemID.CopperPickaxe, [Ingredient(ItemID.CopperBar, 12), Ingredient(ItemID.CactusPickaxe)],
                recipeGroups: [RecipeGroup("Wood", 6)], tiles: [TileID.Anvils]);

        AddRecipe(ItemID.TinPickaxe, [Ingredient(ItemID.TinBar, 12), Ingredient(ItemID.CactusPickaxe)],
                recipeGroups: [RecipeGroup("Wood", 6)], tiles: [TileID.Anvils]);

        AddRecipe(ItemID.IronPickaxe, [Ingredient(ItemID.IronBar, 12)], recipeGroups: [RecipeGroup("CopperPickaxe")],
                tiles: [TileID.Anvils]);

        AddRecipe(ItemID.LeadPickaxe, [Ingredient(ItemID.LeadBar, 12)], recipeGroups: [RecipeGroup("CopperPickaxe")],
                tiles: [TileID.Anvils]);

        AddRecipe(ItemID.SilverPickaxe, [Ingredient(ItemID.SilverBar, 12), Ingredient(ItemID.Sapphire)],
                recipeGroups: [RecipeGroup("IronPickaxe")], tiles: [TileID.Anvils]);

        AddRecipe(ItemID.TungstenPickaxe, [Ingredient(ItemID.TungstenBar, 12), Ingredient(ItemID.Sapphire)],
                recipeGroups: [RecipeGroup("IronPickaxe")], tiles: [TileID.Anvils]);

        AddRecipe(ItemID.GoldPickaxe, [Ingredient(ItemID.GoldBar, 12), Ingredient(ItemID.Ruby)],
                recipeGroups: [RecipeGroup("SilverPickaxe")], tiles: [TileID.HeavyWorkBench]);

        AddRecipe(ItemID.PlatinumPickaxe, [Ingredient(ItemID.PlatinumBar, 12), Ingredient(ItemID.Ruby)],
                recipeGroups: [RecipeGroup("SilverPickaxe")], tiles: [TileID.HeavyWorkBench]);

        AddRecipe(ItemID.FossilPickaxe, [Ingredient(ItemID.FossilOre, 12), Ingredient(ItemID.Amber, 2)],
                recipeGroups: [RecipeGroup("GoldPickaxe")], tiles: [TileID.CatBast]);

        AddRecipe(ItemID.NightmarePickaxe, [
                Ingredient(ItemID.DemoniteBar, 12), Ingredient(ItemID.Ebonwood, 24), Ingredient(ItemID.ShadowScale, 8)
        ], recipeGroups: [RecipeGroup("GoldPickaxe")], tiles: [TileID.DemonAltar], conditions: [Condition.InCorrupt]);

        AddRecipe(ItemID.DeathbringerPickaxe, [
                Ingredient(ItemID.CrimtaneBar, 12), Ingredient(ItemID.Shadewood, 24), Ingredient(ItemID.TissueSample, 8)
        ], recipeGroups: [RecipeGroup("GoldPickaxe")], tiles: [TileID.DemonAltar], conditions: [Condition.InCrimson]);

        AddRecipe(ItemID.MoltenPickaxe,
                [Ingredient(ItemID.HellstoneBar, 12), Ingredient(ItemID.AshWood, 24), Ingredient(ItemID.BeeWax, 8)],
                recipeGroups: [RecipeGroup("NightmarePickaxe")], tiles: [TileID.Hellforge],
                conditions: [Condition.InUnderworld, Condition.NearLava]);

        AddRecipe(ItemID.CobaltPickaxe, [Ingredient(ItemID.CobaltBar, 20), Ingredient(ItemID.MoltenPickaxe)],
                [TileID.HeavyWorkBench]);

        AddRecipe(ItemID.PalladiumPickaxe, [Ingredient(ItemID.PalladiumBar, 20), Ingredient(ItemID.MoltenPickaxe)],
                [TileID.HeavyWorkBench]);

        AddRecipe(ItemID.MythrilPickaxe, [Ingredient(ItemID.MythrilBar, 20)], [TileID.MythrilAnvil],
                recipeGroups: [RecipeGroup("CobaltPickaxe")]);

        AddRecipe(ItemID.OrichalcumPickaxe, [Ingredient(ItemID.OrichalcumBar, 20)], [TileID.MythrilAnvil],
                recipeGroups: [RecipeGroup("CobaltPickaxe")]);

        AddRecipe(ItemID.AdamantitePickaxe, [Ingredient(ItemID.AdamantiteBar, 20)], [TileID.MythrilAnvil],
                recipeGroups: [RecipeGroup("MythrilPickaxe")]);

        AddRecipe(ItemID.TitaniumPickaxe, [Ingredient(ItemID.TitaniumBar, 20)], [TileID.MythrilAnvil],
                recipeGroups: [RecipeGroup("MythrilPickaxe")]);

        AddRecipe(ItemID.PickaxeAxe, [
                Ingredient(ItemID.HallowedBar, 20), Ingredient(ItemID.SoulofFright, 3),
                Ingredient(ItemID.SoulofMight, 3), Ingredient(ItemID.SoulofSight, 3),
                Ingredient(ItemID.SoulofFlight, 3), Ingredient(ItemID.SoulofLight, 3), Ingredient(ItemID.SoulofNight, 3)
        ], [TileID.MythrilAnvil], recipeGroups: [RecipeGroup("AdamantitePickaxe"), RecipeGroup("AdamantiteWaraxe")]);

        AddRecipe(ItemID.CobaltDrill, [Ingredient(ItemID.CobaltBar, 18), Ingredient(ItemID.MoltenPickaxe)],
                [TileID.HeavyWorkBench]);

        AddRecipe(ItemID.PalladiumDrill, [Ingredient(ItemID.PalladiumBar, 18), Ingredient(ItemID.MoltenPickaxe)],
                [TileID.HeavyWorkBench]);

        AddRecipe(ItemID.MythrilDrill, [Ingredient(ItemID.MythrilBar, 18)], [TileID.MythrilAnvil],
                recipeGroups: [RecipeGroup("CobaltDrill")]);

        AddRecipe(ItemID.OrichalcumDrill, [Ingredient(ItemID.OrichalcumBar, 18)], [TileID.MythrilAnvil],
                recipeGroups: [RecipeGroup("CobaltDrill")]);

        AddRecipe(ItemID.AdamantiteDrill, [Ingredient(ItemID.AdamantiteBar, 18)], [TileID.MythrilAnvil],
                recipeGroups: [RecipeGroup("MythrilDrill")]);

        AddRecipe(ItemID.TitaniumDrill, [Ingredient(ItemID.TitaniumBar, 18)], [TileID.MythrilAnvil],
                recipeGroups: [RecipeGroup("MythrilDrill")]);

        AddRecipe(ItemID.Drax, [
                Ingredient(ItemID.HallowedBar, 20), Ingredient(ItemID.SoulofFright, 3),
                Ingredient(ItemID.SoulofMight, 3), Ingredient(ItemID.SoulofSight, 3),
                Ingredient(ItemID.SoulofFlight, 3), Ingredient(ItemID.SoulofLight, 3), Ingredient(ItemID.SoulofNight, 3)
        ], [TileID.MythrilAnvil], recipeGroups: [RecipeGroup("AdamantiteDrill"), RecipeGroup("AdamantiteChainsaw")]);

        AddRecipe(ItemID.WoodFishingPole,
                [Ingredient(ItemID.Wood, 24), Ingredient(ItemID.Cobweb, 20), Ingredient(ItemID.Acorn, 3)],
                [TileID.WorkBenches]);

        AddRecipe(ItemID.WoodenHammer, [Ingredient(ItemID.Wood, 14), Ingredient(ItemID.StoneBlock, 25)],
                [TileID.WorkBenches]);

        AddRecipe(ItemID.BorealWoodHammer, [Ingredient(ItemID.BorealWood, 14), Ingredient(ItemID.SnowBlock, 25)],
                [TileID.WorkBenches]);

        AddRecipe(ItemID.RichMahoganyHammer, [Ingredient(ItemID.RichMahogany, 14), Ingredient(ItemID.MudBlock, 25)],
                [TileID.WorkBenches]);

        AddRecipe(ItemID.PalmWoodHammer, [Ingredient(ItemID.PalmWood, 14), Ingredient(ItemID.SandBlock, 25)],
                [TileID.WorkBenches]);

        AddRecipe(ItemID.AshWoodHammer, [Ingredient(ItemID.AshWood, 14), Ingredient(ItemID.AshBlock, 25)],
                [TileID.Hellforge]);

        AddRecipe(ItemID.EbonwoodHammer, [Ingredient(ItemID.Ebonwood, 14), Ingredient(ItemID.VilePowder, 2)],
                [TileID.WorkBenches]);

        AddRecipe(ItemID.ShadewoodHammer, [Ingredient(ItemID.Shadewood, 14), Ingredient(ItemID.ViciousPowder, 2)],
                [TileID.WorkBenches]);

        AddRecipe(ItemID.PearlwoodHammer, [Ingredient(ItemID.Pearlwood, 14), Ingredient(ItemID.PearlstoneBlock, 25)],
                [TileID.WorkBenches]);

        AddRecipe(ItemID.CopperHammer, [Ingredient(ItemID.CopperBar, 10)], recipeGroups: [RecipeGroup("Wood", 6)],
                tiles: [TileID.Anvils]);

        AddRecipe(ItemID.TinHammer, [Ingredient(ItemID.TinBar, 10)], recipeGroups: [RecipeGroup("Wood", 6)],
                tiles: [TileID.Anvils]);

        AddRecipe(ItemID.IronHammer, [Ingredient(ItemID.IronBar, 10)], recipeGroups: [RecipeGroup("CopperHammer")],
                tiles: [TileID.Anvils]);

        AddRecipe(ItemID.LeadHammer, [Ingredient(ItemID.LeadBar, 10)], recipeGroups: [RecipeGroup("CopperHammer")],
                tiles: [TileID.Anvils]);

        AddRecipe(ItemID.SilverHammer, [Ingredient(ItemID.SilverBar, 10), Ingredient(ItemID.Sapphire)],
                recipeGroups: [RecipeGroup("IronHammer")], tiles: [TileID.Anvils]);

        AddRecipe(ItemID.TungstenHammer, [Ingredient(ItemID.TungstenBar, 10), Ingredient(ItemID.Sapphire)],
                recipeGroups: [RecipeGroup("IronHammer")], tiles: [TileID.Anvils]);

        AddRecipe(ItemID.GoldHammer, [Ingredient(ItemID.GoldBar, 10), Ingredient(ItemID.Ruby)],
                recipeGroups: [RecipeGroup("SilverHammer")], tiles: [TileID.HeavyWorkBench]);

        AddRecipe(ItemID.PlatinumHammer, [Ingredient(ItemID.PlatinumBar, 10), Ingredient(ItemID.Ruby)],
                recipeGroups: [RecipeGroup("SilverHammer")], tiles: [TileID.HeavyWorkBench]);

        AddRecipe(ItemID.TheBreaker, [Ingredient(ItemID.DemoniteBar, 10), Ingredient(ItemID.Ebonwood, 24)],
                recipeGroups: [RecipeGroup("GoldHammer")], tiles: [TileID.DemonAltar],
                conditions: [Condition.InCorrupt]);

        AddRecipe(ItemID.FleshGrinder, [Ingredient(ItemID.CrimtaneBar, 10), Ingredient(ItemID.Shadewood, 24)],
                recipeGroups: [RecipeGroup("GoldHammer")], tiles: [TileID.DemonAltar],
                conditions: [Condition.InCrimson]);

        AddRecipe(ItemID.FieryGreatsword,
                [Ingredient(ItemID.HellstoneBar, 20), Ingredient(ItemID.AshBlock, 250), Ingredient(ItemID.AshWood, 20)],
                [TileID.Hellforge], [Condition.InUnderworld, Condition.NearLava]);

        AddRecipe(ItemID.WoodenSword,
                [Ingredient(ItemID.Wood, 12), Ingredient(ItemID.StoneBlock, 6), Ingredient(ItemID.WebRope, 4)],
                [TileID.WorkBenches]);

        AddRecipe(ItemID.BorealWoodSword,
                [Ingredient(ItemID.BorealWood, 12), Ingredient(ItemID.SnowBlock, 6), Ingredient(ItemID.WebRope, 4)],
                [TileID.WorkBenches]);

        AddRecipe(ItemID.AshWoodSword,
                [Ingredient(ItemID.AshWood, 12), Ingredient(ItemID.AshBlock, 24), Ingredient(ItemID.WebRope, 4)],
                [TileID.Hellforge]);

        AddRecipe(ItemID.RichMahoganySword,
                [Ingredient(ItemID.RichMahogany, 12), Ingredient(ItemID.MudBlock, 6), Ingredient(ItemID.WebRope, 4)],
                [TileID.WorkBenches]);

        AddRecipe(ItemID.PalmWoodSword,
                [Ingredient(ItemID.PalmWood, 12), Ingredient(ItemID.SandBlock, 6), Ingredient(ItemID.WebRope, 4)],
                [TileID.WorkBenches]);

        AddRecipe(ItemID.EbonwoodSword,
                [Ingredient(ItemID.Ebonwood, 12), Ingredient(ItemID.VilePowder, 2), Ingredient(ItemID.WebRope, 4)],
                [TileID.WorkBenches]);

        AddRecipe(ItemID.ShadewoodSword,
                [Ingredient(ItemID.Shadewood, 12), Ingredient(ItemID.VilePowder, 6), Ingredient(ItemID.WebRope, 4)],
                [TileID.WorkBenches]);

        AddRecipe(ItemID.PearlwoodSword, [
                Ingredient(ItemID.Pearlwood, 12), Ingredient(ItemID.PearlstoneBlock, 6), Ingredient(ItemID.WebRope, 4)
        ], [TileID.WorkBenches]);

        AddRecipe(ItemID.CactusSword,
                [Ingredient(ItemID.Cactus, 16), Ingredient(ItemID.Waterleaf, 2), Ingredient(ItemID.WoodenSword)],
                [TileID.WorkBenches]);

        AddRecipe(ItemID.CopperBroadsword, [Ingredient(ItemID.CopperBar, 10), Ingredient(ItemID.WoodenSword)],
                [TileID.Anvils]);

        AddRecipe(ItemID.TinBroadsword, [Ingredient(ItemID.TinBar, 10), Ingredient(ItemID.WoodenSword)],
                [TileID.Anvils]);

        AddRecipe(ItemID.IronBroadsword, [Ingredient(ItemID.IronBar, 10)], [TileID.Anvils],
                recipeGroups: [RecipeGroup("CopperBroadsword")]);

        AddRecipe(ItemID.LeadBroadsword, [Ingredient(ItemID.LeadBar, 10)], [TileID.Anvils],
                recipeGroups: [RecipeGroup("CopperBroadsword")]);

        AddRecipe(ItemID.SilverBroadsword, [Ingredient(ItemID.GoldBar, 10), Ingredient(ItemID.Sapphire)],
                [TileID.Anvils], recipeGroups: [RecipeGroup("IronBroadsword")]);

        AddRecipe(ItemID.TungstenBroadsword, [Ingredient(ItemID.PlatinumBar, 10), Ingredient(ItemID.Sapphire)],
                [TileID.Anvils], recipeGroups: [RecipeGroup("IronBroadsword")]);

        AddRecipe(ItemID.GoldBroadsword, [Ingredient(ItemID.GoldBar, 10), Ingredient(ItemID.Ruby)], [TileID.Anvils],
                recipeGroups: [RecipeGroup("SilverBroadsword")]);

        AddRecipe(ItemID.PlatinumBroadsword, [Ingredient(ItemID.PlatinumBar, 10), Ingredient(ItemID.Ruby)],
                [TileID.Anvils], recipeGroups: [RecipeGroup("SilverBroadsword")]);

        AddRecipe(ItemID.CopperShortsword, [Ingredient(ItemID.CopperBar, 8), Ingredient(ItemID.WoodenSword)],
                [TileID.Anvils]);

        AddRecipe(ItemID.TinShortsword, [Ingredient(ItemID.TinBar, 8), Ingredient(ItemID.WoodenSword)],
                [TileID.Anvils]);

        AddRecipe(ItemID.IronShortsword, [Ingredient(ItemID.IronBar, 8)], [TileID.Anvils],
                recipeGroups: [RecipeGroup("CopperShortsword")]);

        AddRecipe(ItemID.LeadShortsword, [Ingredient(ItemID.LeadBar, 8)], [TileID.Anvils],
                recipeGroups: [RecipeGroup("CopperShortsword")]);

        AddRecipe(ItemID.SilverShortsword, [Ingredient(ItemID.GoldBar, 8), Ingredient(ItemID.Sapphire)],
                [TileID.Anvils], recipeGroups: [RecipeGroup("IronShortsword")]);

        AddRecipe(ItemID.TungstenShortsword, [Ingredient(ItemID.PlatinumBar, 8), Ingredient(ItemID.Sapphire)],
                [TileID.Anvils], recipeGroups: [RecipeGroup("IronShortsword")]);

        AddRecipe(ItemID.GoldShortsword, [Ingredient(ItemID.GoldBar, 8), Ingredient(ItemID.Ruby)], [TileID.Anvils],
                recipeGroups: [RecipeGroup("SilverShortsword")]);

        AddRecipe(ItemID.PlatinumShortsword, [Ingredient(ItemID.PlatinumBar, 8), Ingredient(ItemID.Ruby)],
                [TileID.Anvils], recipeGroups: [RecipeGroup("SilverShortsword")]);

        AddRecipe(ItemID.LightsBane, [
                Ingredient(ItemID.DemoniteBar, 14), Ingredient(ItemID.RottenChunk, 4), Ingredient(ItemID.VilePowder, 6)
        ], [TileID.Anvils], recipeGroups: [RecipeGroup("GoldBroadsword")]);

        AddRecipe(ItemID.BloodButcherer, [
                Ingredient(ItemID.CrimtaneBar, 14), Ingredient(ItemID.Vertebrae, 4), Ingredient(ItemID.ViciousPowder, 6)
        ], [TileID.Anvils], recipeGroups: [RecipeGroup("GoldBroadsword")]);

        AddRecipe(ItemID.BladeofGrass, [
                Ingredient(ItemID.Stinger, 16), Ingredient(ItemID.JungleSpores, 15), Ingredient(ItemID.Vine, 4),
                Ingredient(ItemID.RichMahoganySword)
        ], [TileID.Anvils]);

        AddRecipe(ItemID.NightsEdge, [
                Ingredient(ItemID.Muramasa), Ingredient(ItemID.BladeofGrass),
                Ingredient(ItemID.FieryGreatsword), Ingredient(ItemID.AntlionClaw)
        ], [TileID.DemonAltar], recipeGroups: [RecipeGroup("LightsBane")]);

        AddRecipe(ItemID.CobaltSword, [Ingredient(ItemID.CobaltBar, 14), Ingredient(ItemID.BoneSword)],
                [TileID.HeavyWorkBench]);

        AddRecipe(ItemID.PalladiumSword, [Ingredient(ItemID.PalladiumBar, 14), Ingredient(ItemID.BoneSword)],
                [TileID.HeavyWorkBench]);

        AddRecipe(ItemID.MythrilSword, [Ingredient(ItemID.MythrilBar, 14)], [TileID.MythrilAnvil],
                recipeGroups: [RecipeGroup("CobaltSword")]);

        AddRecipe(ItemID.OrichalcumSword, [Ingredient(ItemID.OrichalcumBar, 14)], [TileID.MythrilAnvil],
                recipeGroups: [RecipeGroup("CobaltSword")]);

        AddRecipe(ItemID.AdamantiteSword, [Ingredient(ItemID.AdamantiteBar, 14)], [TileID.MythrilAnvil],
                recipeGroups: [RecipeGroup("MythrilSword")]);

        AddRecipe(ItemID.TitaniumSword, [Ingredient(ItemID.TitaniumBar, 14)], [TileID.MythrilAnvil],
                recipeGroups: [RecipeGroup("MythrilSword")]);

        AddRecipe(ItemID.Excalibur, [
                Ingredient(ItemID.EnchantedSword), Ingredient(ItemID.HallowedBar, 12), Ingredient(ItemID.SoulofLight, 6)
        ], [TileID.MythrilAnvil]);

        AddRecipe(ItemID.TrueExcalibur, [
                Ingredient(ItemID.Excalibur), Ingredient(ItemID.ChlorophyteBar, 30), Ingredient(ItemID.PixieBanner),
                Ingredient(ItemID.AngryTrapperBanner), Ingredient(ItemID.FungiBulbBanner)
        ], [TileID.MythrilAnvil]);

        AddRecipe(ItemID.TrueNightsEdge, [
                Ingredient(ItemID.NightsEdge), Ingredient(ItemID.SoulofFright, 25), Ingredient(ItemID.CorruptorBanner),
                Ingredient(ItemID.CursedSkullBanner), Ingredient(ItemID.LavaBatBanner)
        ], [TileID.MythrilAnvil]);

        AddRecipe(ItemID.TrueNightsEdge, [
                Ingredient(ItemID.NightsEdge), Ingredient(ItemID.SoulofFright, 25),
                Ingredient(ItemID.IchorStickerBanner), Ingredient(ItemID.CursedSkullBanner),
                Ingredient(ItemID.LavaBatBanner)
        ], [TileID.MythrilAnvil]);

        AddRecipe(ItemID.TerraBlade, [
                Ingredient(ItemID.TrueNightsEdge), Ingredient(ItemID.TrueExcalibur),
                Ingredient(ItemID.BrokenHeroSword, 2), Ingredient(ItemID.Ectoplasm, 10),
                Ingredient(ItemID.GrassSeeds, 25), Ingredient(ItemID.CorruptSeeds, 25),
                Ingredient(ItemID.CrimsonSeeds, 25), Ingredient(ItemID.JungleGrassSeeds, 25),
                Ingredient(ItemID.MushroomGrassSeeds, 25), Ingredient(ItemID.AshGrassSeeds, 25),
                Ingredient(ItemID.HallowedSeeds, 25)
        ], [TileID.Autohammer]);

        if (ModContent.GetInstance<ArgosConfig>().HellMode)
        {
            AddRecipe(ItemID.Zenith, [
                    Ingredient(ItemID.TerraBlade),
                    Ingredient(ItemID.Meowmere),
                    Ingredient(ItemID.StarWrath),
                    Ingredient(ItemID.InfluxWaver),
                    Ingredient(ItemID.TheHorsemansBlade),
                    Ingredient(ItemID.Seedler),
                    Ingredient(ItemID.BeeKeeper),
                    Ingredient(ItemID.Terragrim),
                    Ingredient(ItemID.CopperShortsword),
                    Ingredient(ItemID.DD2SquireBetsySword),
                    Ingredient(ItemID.DD2SquireDemonSword),
                    Ingredient(ItemID.Keybrand),
                    Ingredient(ItemID.PiercingStarlight),
                    Ingredient(ItemID.BreakerBlade),
                    Ingredient(ItemID.ChristmasTreeSword),
                    Ingredient(ItemID.Frostbrand)
            ], [
                    TileID.LunarCraftingStation,
                    TileID.Toilets,
                    TileID.WorkBenches,
                    TileID.MythrilAnvil,
                    TileID.SkyMill,
                    TileID.Autohammer,
                    TileID.CrystalBall,
                    TileID.Bookcases,
                    TileID.AlchemyTable,
                    TileID.Blendomatic,
                    TileID.AdamantiteForge,
                    TileID.LesionStation,
                    TileID.MeatGrinder,
                    TileID.LihzahrdFurnace,
                    TileID.SteampunkBoiler,
                    TileID.LivingLoom
            ], [
                    Condition.InAether,
                    Condition.NearHoney,
                    Condition.NearWater,
                    Condition.NearLava,
                    Condition.NearShimmer,
                    Condition.Hardmode,
                    Condition.PlayerCarriesItem(ItemID.FartinaJar),
                    Condition.BirthdayParty
            ]);
        }
        else
        {
            AddRecipe(ItemID.Zenith, [
                            Ingredient(ItemID.TerraBlade),
                            Ingredient(ItemID.Meowmere),
                            Ingredient(ItemID.StarWrath),
                            Ingredient(ItemID.InfluxWaver),
                            Ingredient(ItemID.TheHorsemansBlade),
                            Ingredient(ItemID.Seedler),
                            Ingredient(ItemID.BeeKeeper),
                            Ingredient(ItemID.Terragrim),
                            Ingredient(ItemID.CopperShortsword),
                            Ingredient(ItemID.DD2SquireBetsySword),
                            Ingredient(ItemID.DD2SquireDemonSword),
                            Ingredient(ItemID.Keybrand),
                            Ingredient(ItemID.PiercingStarlight),
                            Ingredient(ItemID.BreakerBlade),
                            Ingredient(ItemID.ChristmasTreeSword),
                            Ingredient(ItemID.Frostbrand)
                    ], [TileID.LunarCraftingStation, TileID.Toilets],
                    [Condition.InAether, Condition.NearHoney, Condition.BirthdayParty]);

            AddRecipe(ItemID.StardustDragonStaff,
                    [Ingredient(ItemID.FragmentStardust, 20), Ingredient(ItemID.MartianConduitPlating, 80)],
                    [TileID.LunarCraftingStation]);

            AddRecipe(ItemID.StardustCellStaff, [
                    Ingredient(ItemID.FragmentStardust, 20), Ingredient(ItemID.MartianConduitPlating, 80),
                    Ingredient(ItemID.DeadlySphereStaff)
            ], [TileID.LunarCraftingStation]);

            AddRecipe(ItemID.HornetStaff, [
                    Ingredient(ItemID.BeeWax, 16), Ingredient(ItemID.LivingMahoganyWand), Ingredient(ItemID.Hive, 250)
            ], [TileID.HoneyDispenser]);

            AddRecipe(ItemID.ImpStaff, [
                    Ingredient(ItemID.HellstoneBar, 20), Ingredient(ItemID.FireImpBanner), Ingredient(ItemID.Bone, 45)
            ], [TileID.Hellforge], [Condition.NearLava]);

            AddRecipe(ItemID.WoodenBow, [Ingredient(ItemID.Wood, 12), Ingredient(ItemID.Cobweb, 20)],
                    [TileID.WorkBenches]);

            AddRecipe(ItemID.BorealWoodBow, [Ingredient(ItemID.BorealWood, 12), Ingredient(ItemID.Cobweb, 20)],
                    [TileID.WorkBenches]);

            AddRecipe(ItemID.AshWoodBow, [Ingredient(ItemID.AshWood, 12), Ingredient(ItemID.Cobweb, 20)],
                    [TileID.Hellforge]);

            AddRecipe(ItemID.RichMahoganyBow, [Ingredient(ItemID.RichMahogany, 12), Ingredient(ItemID.Cobweb, 20)],
                    [TileID.WorkBenches]);

            AddRecipe(ItemID.PalmWoodBow, [Ingredient(ItemID.PalmWood, 12), Ingredient(ItemID.Cobweb, 20)],
                    [TileID.WorkBenches]);

            AddRecipe(ItemID.EbonwoodBow, [
                    Ingredient(ItemID.Ebonwood, 12), Ingredient(ItemID.Cobweb, 20),
                    Ingredient(ItemID.EbonstoneBlock, 25)
            ], [TileID.WorkBenches]);

            AddRecipe(ItemID.ShadewoodBow, [
                    Ingredient(ItemID.Shadewood, 12), Ingredient(ItemID.Cobweb, 20),
                    Ingredient(ItemID.CrimstoneBlock, 25)
            ], [TileID.WorkBenches]);

            AddRecipe(ItemID.PearlwoodBow, [
                    Ingredient(ItemID.Pearlwood, 12), Ingredient(ItemID.Cobweb, 20),
                    Ingredient(ItemID.PearlstoneBlock, 25)
            ], [TileID.WorkBenches]);

            AddRecipe(ItemID.CopperBow, [Ingredient(ItemID.CopperBar, 12), Ingredient(ItemID.WoodenBow)],
                    recipeGroups: [RecipeGroup("Wood", 6)], tiles: [TileID.Anvils]);

            AddRecipe(ItemID.TinBow, [Ingredient(ItemID.TinBar, 12), Ingredient(ItemID.WoodenBow)],
                    recipeGroups: [RecipeGroup("Wood", 6)], tiles: [TileID.Anvils]);

            AddRecipe(ItemID.IronBow, [Ingredient(ItemID.IronBar, 12)], recipeGroups: [RecipeGroup("CopperBow")],
                    tiles: [TileID.Anvils]);

            AddRecipe(ItemID.LeadBow, [Ingredient(ItemID.LeadBar, 12)], recipeGroups: [RecipeGroup("CopperBow")],
                    tiles: [TileID.Anvils]);

            AddRecipe(ItemID.SilverBow, [Ingredient(ItemID.SilverBar, 12), Ingredient(ItemID.Sapphire)],
                    recipeGroups: [RecipeGroup("IronBow")], tiles: [TileID.Anvils]);

            AddRecipe(ItemID.TungstenBow, [Ingredient(ItemID.TungstenBar, 12), Ingredient(ItemID.Sapphire)],
                    recipeGroups: [RecipeGroup("IronBow")], tiles: [TileID.Anvils]);

            AddRecipe(ItemID.GoldBow, [Ingredient(ItemID.GoldBar, 12), Ingredient(ItemID.Ruby)],
                    recipeGroups: [RecipeGroup("SilverBow")], tiles: [TileID.HeavyWorkBench]);

            AddRecipe(ItemID.PlatinumBow, [Ingredient(ItemID.PlatinumBar, 12), Ingredient(ItemID.Ruby)],
                    recipeGroups: [RecipeGroup("SilverBow")], tiles: [TileID.HeavyWorkBench]);

            AddRecipe(ItemID.DemonBow,
                    [Ingredient(ItemID.DemoniteBar, 12), Ingredient(ItemID.Ebonwood, 12), Ingredient(ItemID.VioletDye)],
                    recipeGroups: [RecipeGroup("GoldBow")], tiles: [TileID.DemonAltar],
                    conditions: [Condition.InCorrupt]);

            AddRecipe(ItemID.TendonBow,
                    [Ingredient(ItemID.CrimtaneBar, 12), Ingredient(ItemID.Shadewood, 12), Ingredient(ItemID.RedDye)],
                    recipeGroups: [RecipeGroup("GoldBow")], tiles: [TileID.DemonAltar],
                    conditions: [Condition.InCrimson]);

            AddRecipe(ItemID.MoltenFury, [Ingredient(ItemID.HellstoneBar, 16), Ingredient(ItemID.FlamingArrow, 500)],
                    recipeGroups: [RecipeGroup("DemonBow")], tiles: [TileID.Hellforge],
                    conditions: [Condition.InUnderworld, Condition.NearLava]);

            AddRecipe(ItemID.CobaltRepeater, [Ingredient(ItemID.CobaltBar, 14), Ingredient(ItemID.HellwingBow)],
                    [TileID.HeavyWorkBench]);

            AddRecipe(ItemID.PalladiumRepeater, [Ingredient(ItemID.PalladiumBar, 14), Ingredient(ItemID.HellwingBow)],
                    [TileID.HeavyWorkBench]);

            AddRecipe(ItemID.MythrilRepeater, [Ingredient(ItemID.MythrilBar, 14)], [TileID.MythrilAnvil],
                    recipeGroups: [RecipeGroup("CobaltRepeater")]);

            AddRecipe(ItemID.OrichalcumRepeater, [Ingredient(ItemID.OrichalcumBar, 14)], [TileID.MythrilAnvil],
                    recipeGroups: [RecipeGroup("CobaltRepeater")]);

            AddRecipe(ItemID.AdamantiteRepeater, [Ingredient(ItemID.AdamantiteBar, 14)], [TileID.MythrilAnvil],
                    recipeGroups: [RecipeGroup("MythrilRepeater")]);

            AddRecipe(ItemID.TitaniumRepeater, [Ingredient(ItemID.TitaniumBar, 14)], [TileID.MythrilAnvil],
                    recipeGroups: [RecipeGroup("MythrilRepeater")]);

            AddRecipe(ItemID.HallowedRepeater, [Ingredient(ItemID.HallowedBar, 16), Ingredient(ItemID.SoulofSight, 3)],
                    [TileID.DemonAltar], recipeGroups: [RecipeGroup("AdamantiteRepeater")]);

            AddRecipe(ItemID.ChlorophyteShotbow,
                    [Ingredient(ItemID.ChlorophyteBar, 16), Ingredient(ItemID.HallowedRepeater)],
                    [TileID.MythrilAnvil]);

            AddRecipe(ItemID.PhoenixBlaster, [
                    Ingredient(ItemID.HellstoneBar, 16), Ingredient(ItemID.Handgun),
                    Ingredient(ItemID.HellfireArrow, 200)
            ], [TileID.Hellforge], [Condition.NearLava]);

            AddRecipe(ItemID.StarCannon, [
                    Ingredient(ItemID.Minishark), Ingredient(ItemID.SpaceGun), Ingredient(ItemID.PhoenixBlaster),
                    Ingredient(ItemID.FallenStar, 15), Ingredient(ItemID.HellstoneBar, 20)
            ], [TileID.Hellforge, TileID.SkyMill], [Condition.InSpace]);

            AddRecipe(ItemID.Beenade,
                    [Ingredient(ItemID.BeeWax), Ingredient(ItemID.Grenade), Ingredient(ItemID.Hive, 3)],
                    [TileID.HoneyDispenser]);

            AddRecipe(ItemID.EnchantedBoomerang,
                    [Ingredient(ItemID.WoodenBoomerang), Ingredient(ItemID.FallenStar, 5), Ingredient(ItemID.Ruby, 3)],
                    [TileID.Anvils], [Condition.InSpace]);

            AddRecipe(ItemID.Flamarang, [
                    Ingredient(ItemID.HellstoneBar, 15), Ingredient(ItemID.IceBoomerang), Ingredient(ItemID.FlaskofFire)
            ], [TileID.Hellforge], [Condition.InUnderworld, Condition.NearLava]);

            AddRecipe(ItemID.Gungnir, [
                    Ingredient(ItemID.HallowedBar, 12), Ingredient(ItemID.SoulofLight, 8),
                    Ingredient(ItemID.PixieDust, 12)
            ], [TileID.MythrilAnvil], recipeGroups: [RecipeGroup("AdamantiteGlaive")]);

            AddRecipe(ItemID.ChlorophytePartisan, [
                    Ingredient(ItemID.ChlorophyteBar, 15), Ingredient(ItemID.Gungnir),
                    Ingredient(ItemID.FlaskofPoison, 5)
            ], [TileID.MythrilAnvil]);

            AddRecipe(ItemID.CobaltNaginata, [Ingredient(ItemID.CobaltBar, 12), Ingredient(ItemID.DarkLance)],
                    [TileID.HeavyWorkBench]);

            AddRecipe(ItemID.PalladiumPike, [Ingredient(ItemID.PalladiumBar, 12), Ingredient(ItemID.DarkLance)],
                    [TileID.HeavyWorkBench]);

            AddRecipe(ItemID.MythrilHalberd, [Ingredient(ItemID.MythrilBar, 12)], [TileID.MythrilAnvil],
                    recipeGroups: [RecipeGroup("CobaltNaginata")]);

            AddRecipe(ItemID.OrichalcumHalberd, [Ingredient(ItemID.OrichalcumBar, 12)], [TileID.MythrilAnvil],
                    recipeGroups: [RecipeGroup("CobaltNaginata")]);

            AddRecipe(ItemID.AdamantiteGlaive, [Ingredient(ItemID.AdamantiteBar, 12)], [TileID.MythrilAnvil],
                    recipeGroups: [RecipeGroup("MythrilHalberd")]);

            AddRecipe(ItemID.TitaniumTrident, [Ingredient(ItemID.TitaniumBar, 14)], [TileID.MythrilAnvil],
                    recipeGroups: [RecipeGroup("MythrilHalberd")]);

            AddRecipe(ItemID.DayBreak, [Ingredient(ItemID.FragmentSolar, 18), Ingredient(ItemID.NorthPole)],
                    [TileID.LunarCraftingStation]);

            AddRecipe(ItemID.WoodYoyo, [Ingredient(ItemID.Wood, 20), Ingredient(ItemID.Cobweb, 25)], [TileID.Anvils],
                    recipeGroups: [RecipeGroup("IronBar", 6)]);

            AddRecipe(ItemID.CorruptYoyo, [
                    Ingredient(ItemID.DemoniteBar, 14), Ingredient(ItemID.RottenChunk, 6), Ingredient(ItemID.WoodYoyo)
            ], [TileID.Anvils]);

            AddRecipe(ItemID.CrimsonYoyo,
                    [Ingredient(ItemID.CrimtaneBar, 14), Ingredient(ItemID.Vertebrae, 6), Ingredient(ItemID.WoodYoyo)],
                    [TileID.Anvils]);

            AddRecipe(ItemID.JungleYoyo, [
                    Ingredient(ItemID.JungleSpores, 12), Ingredient(ItemID.Stinger, 12), Ingredient(ItemID.Vine, 5),
                    Ingredient(ItemID.RichMahogany, 24), Ingredient(ItemID.GreenString)
            ], [TileID.LivingLoom]);

            AddRecipe(ItemID.HiveFive, [
                    Ingredient(ItemID.BeeWax, 16), Ingredient(ItemID.JungleYoyo), Ingredient(ItemID.BottledHoney, 12),
                    Ingredient(ItemID.YellowString)
            ], [TileID.HoneyDispenser]);

            AddRecipe(ItemID.Chik, [
                    Ingredient(ItemID.CrystalShard, 20), Ingredient(ItemID.SoulofLight, 8),
                    Ingredient(ItemID.PixieDust, 10), Ingredient(ItemID.CursedFlame, 12), Ingredient(ItemID.CorruptYoyo)
            ], [TileID.CrystalBall]);
            AddRecipe(ItemID.Chik, [
                    Ingredient(ItemID.CrystalShard, 20), Ingredient(ItemID.SoulofLight, 8),
                    Ingredient(ItemID.PixieDust, 10), Ingredient(ItemID.Ichor, 12), Ingredient(ItemID.CrimsonYoyo)
            ], [TileID.CrystalBall]);

            AddRecipe(ItemID.FlamingMace,
                    [Ingredient(ItemID.Mace), Ingredient(ItemID.Torch, 200), Ingredient(ItemID.LavaBucket, 2)],
                    [TileID.Anvils]);

            AddRecipe(ItemID.SolarEruption, [
                    Ingredient(ItemID.FragmentSolar, 18), Ingredient(ItemID.GolemFist),
                    Ingredient(ItemID.PossessedHatchet)
            ], [TileID.LunarCraftingStation]);

            AddRecipe(ItemID.AmethystStaff, [Ingredient(ItemID.CopperBar, 12), Ingredient(ItemID.Amethyst, 10)],
                    [TileID.Anvils]);

            AddRecipe(ItemID.TopazStaff, [Ingredient(ItemID.TinBar, 12), Ingredient(ItemID.Topaz, 10)],
                    [TileID.Anvils]);

            AddRecipe(ItemID.SapphireStaff, [
                    Ingredient(ItemID.SilverBar, 12), Ingredient(ItemID.Sapphire, 10),
                    Ingredient(ItemID.GlowingMushroom, 25)
            ], [TileID.Anvils]);

            AddRecipe(ItemID.EmeraldStaff, [
                    Ingredient(ItemID.TungstenBar, 12), Ingredient(ItemID.Emerald, 10),
                    Ingredient(ItemID.GlowingMushroom, 25)
            ], [TileID.Anvils]);

            AddRecipe(ItemID.RubyStaff,
                    [Ingredient(ItemID.GoldBar, 12), Ingredient(ItemID.Ruby, 10), Ingredient(ItemID.FlinxFur, 5)],
                    [TileID.Anvils]);

            AddRecipe(ItemID.DiamondStaff, [
                    Ingredient(ItemID.PlatinumBar, 12), Ingredient(ItemID.Diamond, 10), Ingredient(ItemID.FlinxFur, 5)
            ], [TileID.Anvils]);

            AddRecipe(ItemID.AmberStaff, [
                    Ingredient(ItemID.FossilOre, 20), Ingredient(ItemID.Amber, 10),
                    Ingredient(ItemID.AntlionMandible, 6)
            ], [TileID.Anvils]);

            AddRecipe(ItemID.SpaceGun, [
                    Ingredient(ItemID.FlintlockPistol), Ingredient(ItemID.MeteoriteBar, 20),
                    Ingredient(ItemID.Obsidian, 25)
            ], [TileID.Anvils]);

            AddRecipe(ItemID.LunarBar, [
                    Ingredient(ItemID.LunarOre, 5), Ingredient(ItemID.ChlorophyteBar), Ingredient(ItemID.SpectreBar),
                    Ingredient(ItemID.ShroomiteBar)
            ], [TileID.LunarCraftingStation]);

            AddRecipe(ItemID.Bottle, [Ingredient(ItemID.Glass)], [TileID.Furnaces, TileID.Anvils]);
            AddRecipe(ItemID.Chain, [], [TileID.Anvils], recipeGroups: [RecipeGroup("IronBar")], amount: 3);
            AddRecipe(ItemID.Leather, [Ingredient(ItemID.RottenChunk, 6)], [TileID.Furnaces], [Condition.NearWater]);
            AddRecipe(ItemID.Leather, [Ingredient(ItemID.Vertebrae, 6)], [TileID.Furnaces], [Condition.NearWater]);
            AddRecipe(ItemID.Silk, [Ingredient(ItemID.Cobweb, 8)], [TileID.Loom], [Condition.NearWater]);
            if (ModContent.GetInstance<ArgosConfig>().HellMode)
            {
                AddRecipe(ItemID.EnchantedNightcrawler,
                        [Ingredient(ItemID.Worm), Ingredient(ItemID.PinkDye), Ingredient(ItemID.FallenStar)],
                        conditions: [Condition.LanternNight]);
            }
            else
            {
                AddRecipe(ItemID.EnchantedNightcrawler, [Ingredient(ItemID.Worm), Ingredient(ItemID.FallenStar)],
                        conditions: [Condition.LanternNight]);
            }

            AddRecipe(ItemID.DemoniteBar, [Ingredient(ItemID.DemoniteOre, 4), Ingredient(ItemID.Ebonwood, 2)],
                    [TileID.Furnaces]);
            AddRecipe(ItemID.CrimtaneBar, [Ingredient(ItemID.CrimtaneOre, 4), Ingredient(ItemID.Shadewood, 2)],
                    [TileID.Furnaces]);
            AddRecipe(ItemID.CobaltBar, [Ingredient(ItemID.CobaltOre, 4)], [TileID.Hellforge]);
            AddRecipe(ItemID.PalladiumBar, [Ingredient(ItemID.PalladiumOre, 4)], [TileID.Hellforge]);
            AddRecipe(ItemID.SpectreBar,
                    [Ingredient(ItemID.ChlorophyteBar), Ingredient(ItemID.Ectoplasm), Ingredient(ItemID.Bone, 5)],
                    [TileID.CrystalBall]);
            AddRecipe(ItemID.ChlorophyteBar, [Ingredient(ItemID.ChlorophyteOre, 5), Ingredient(ItemID.JungleSpores)],
                    [TileID.AdamantiteForge]);
            AddRecipe(ItemID.HellstoneBar,
                    [Ingredient(ItemID.Hellstone, 4), Ingredient(ItemID.Obsidian), Ingredient(ItemID.AshBlock, 10)],
                    [TileID.Hellforge]);

            AddRecipe(ItemID.CookedFish,
                    [Ingredient(ItemID.Bass), Ingredient(ItemID.Acorn), Ingredient(ItemID.Mushroom)],
                    [TileID.CookingPots], [Condition.NearWater]);

            AddRecipe(ItemID.CookedFish,
                    [Ingredient(ItemID.Trout), Ingredient(ItemID.ShellPileBlock), Ingredient(ItemID.Mushroom)],
                    [TileID.CookingPots], [Condition.NearWater]);

            AddRecipe(ItemID.CookedFish,
                    [Ingredient(ItemID.AtlanticCod), Ingredient(ItemID.Acorn), Ingredient(ItemID.Shiverthorn)],
                    [TileID.CookingPots], [Condition.NearWater]);

            AddRecipe(ItemID.SeafoodDinner,
                    [Ingredient(ItemID.Mushroom, 2), Ingredient(ItemID.Acorn, 3), Ingredient(ItemID.Waterleaf)],
                    [TileID.CookingPots], [Condition.NearWater], [RecipeGroup("DoubleCod", 3)]);

            AddRecipe(ItemID.RoastedBird, [Ingredient(ItemID.GlowingMushroom, 2), Ingredient(ItemID.Daybloom)],
                    [TileID.CookingPots, TileID.Furnaces], recipeGroups: [RecipeGroup("Bird")]);

            AddRecipe(ItemID.GoldenDelight, [
                    Ingredient(ItemID.DynastyBowl), Ingredient(ItemID.FallenStar, 3), Ingredient(ItemID.BottledHoney, 2)
            ], [TileID.CookingPots, TileID.GlassKiln], recipeGroups: [RecipeGroup("GoldBunny")]);

            AddRecipe(ItemID.BowlofSoup, [
                    Ingredient(ItemID.Mushroom, 2), Ingredient(ItemID.Goldfish), Ingredient(ItemID.Daybloom, 2),
                    Ingredient(ItemID.Bowl)
            ], [TileID.CookingPots], [Condition.NearWater]);

            AddRecipe(ItemID.PumpkinPie, [
                    Ingredient(ItemID.Pumpkin, 12), Ingredient(ItemID.Acorn, 4), Ingredient(ItemID.GlowingMushroom, 6)
            ], [TileID.Furnaces, TileID.CookingPots], [Condition.NearWater]);

            AddRecipe(ItemID.GrubSoup, [
                    Ingredient(ItemID.Grubby, 3), Ingredient(ItemID.Sluggy, 2), Ingredient(ItemID.Buggy),
                    Ingredient(ItemID.GlassBowl), Ingredient(ItemID.JungleSpores, 3)
            ], [TileID.CookingPots], [Condition.NearWater]);

            AddRecipe(ItemID.MonsterLasagna, [
                    Ingredient(ItemID.RottenChunk, 8), Ingredient(ItemID.Deathweed, 2),
                    Ingredient(ItemID.VileMushroom, 4), Ingredient(ItemID.PurificationPowder, 12)
            ], [TileID.Furnaces, TileID.CookingPots]);

            AddRecipe(ItemID.MonsterLasagna, [
                    Ingredient(ItemID.Vertebrae, 8), Ingredient(ItemID.Deathweed, 2),
                    Ingredient(ItemID.ViciousMushroom, 4), Ingredient(ItemID.PurificationPowder, 12)
            ], [TileID.Furnaces, TileID.CookingPots]);

            AddRecipe(ItemID.RegenerationPotion,
                    [Ingredient(ItemID.BottledWater), Ingredient(ItemID.Daybloom), Ingredient(ItemID.Mushroom, 2)],
                    [TileID.Bottles]);

            AddRecipe(ItemID.SwiftnessPotion, [
                    Ingredient(ItemID.BottledWater), Ingredient(ItemID.Cactus, 2), Ingredient(ItemID.Blinkroot),
                    Ingredient(ItemID.Daybloom)
            ], [TileID.Bottles, TileID.Sunflower]);

            AddRecipe(ItemID.GillsPotion, [
                    Ingredient(ItemID.BottledWater, 3), Ingredient(ItemID.Waterleaf, 2), Ingredient(ItemID.Coral),
                    Ingredient(ItemID.ShellPileBlock, 2)
            ], [TileID.Bottles], [Condition.NearWater]);

            AddRecipe(ItemID.LifeforcePotion, [
                    Ingredient(ItemID.BottledHoney), Ingredient(ItemID.Moonglow), Ingredient(ItemID.Fireblossom, 2),
                    Ingredient(ItemID.Prismite), Ingredient(ItemID.LifeCrystal)
            ], [TileID.Bottles]);

            AddRecipe(ItemID.IronskinPotion, [
                    Ingredient(ItemID.BottledWater), Ingredient(ItemID.Daybloom), Ingredient(ItemID.GlowingMushroom, 2)
            ], [TileID.Bottles], recipeGroups: [RecipeGroup("IronOre", 2)]);

            AddRecipe(ItemID.FlaskofFire, [
                    Ingredient(ItemID.BottledHoney), Ingredient(ItemID.Hellstone, 5), Ingredient(ItemID.Fireblossom, 2),
                    Ingredient(ItemID.Obsidian, 6), Ingredient(ItemID.SpicyPepper)
            ], [TileID.ImbuingStation], [Condition.NearLava]);

            AddRecipe(ItemID.FlaskofPoison, [
                    Ingredient(ItemID.BottledHoney), Ingredient(ItemID.Stinger, 5), Ingredient(ItemID.JungleSpores, 6),
                    Ingredient(ItemID.Moonglow, 3), Ingredient(ItemID.Mango)
            ], [TileID.ImbuingStation], [Condition.NearHoney]);

            AddRecipe(ItemID.FlaskofParty, [
                    Ingredient(ItemID.BottledWater), Ingredient(ItemID.Confetti, 15),
                    Ingredient(ItemID.SillyBalloonGreen, 20), Ingredient(ItemID.SillyBalloonPink, 20),
                    Ingredient(ItemID.SillyBalloonPurple, 20)
            ], [TileID.ImbuingStation], [Condition.BirthdayParty]);

            AddRecipe(ItemID.FlaskofGold, [
                    Ingredient(ItemID.BottledWater), Ingredient(ItemID.GoldDust, 8), Ingredient(ItemID.GoldCoin, 3),
                    Ingredient(ItemID.Marble, 80)
            ], [TileID.ImbuingStation], [Condition.InMarble]);

            AddRecipe(ItemID.FlaskofIchor, [
                    Ingredient(ItemID.BottledWater), Ingredient(ItemID.Ichor, 4), Ingredient(ItemID.SoulofNight, 2),
                    Ingredient(ItemID.Vertebrae, 5)
            ], [TileID.ImbuingStation], [Condition.NearShimmer]);

            AddRecipe(ItemID.FlaskofCursedFlames, [
                    Ingredient(ItemID.BottledWater), Ingredient(ItemID.CursedFlame, 4),
                    Ingredient(ItemID.SoulofNight, 2), Ingredient(ItemID.RottenChunk, 5)
            ], [TileID.ImbuingStation], [Condition.NearShimmer]);

            AddRecipe(ItemID.FlaskofVenom, [
                    Ingredient(ItemID.FlaskofPoison), Ingredient(ItemID.VialofVenom, 8), Ingredient(ItemID.Granite, 80)
            ], [TileID.ImbuingStation], [Condition.InGranite]);

            AddRecipe(ItemID.FlaskofNanites, [
                    Ingredient(ItemID.FlaskofFire), Ingredient(ItemID.Nanites, 10), Ingredient(ItemID.Ectoplasm, 3),
                    Ingredient(ItemID.EchoBlock, 8)
            ], [TileID.ImbuingStation], [Condition.InSpace]);

            AddRecipe(ItemID.Campfire, [Ingredient(ItemID.Torch, 45), Ingredient(ItemID.Wood, 12)],
                    [TileID.WorkBenches]);
            AddRecipe(ItemID.FrozenCampfire, [Ingredient(ItemID.IceTorch, 45), Ingredient(ItemID.BorealWood, 12)],
                    [TileID.IceMachine]);
            AddRecipe(ItemID.JungleCampfire,
                    [Ingredient(ItemID.JungleCampfire, 45), Ingredient(ItemID.RichMahogany, 12)], [TileID.WorkBenches]);
            AddRecipe(ItemID.DesertCampfire, [Ingredient(ItemID.DesertTorch, 45), Ingredient(ItemID.PalmWood, 12)],
                    [TileID.GlassKiln]);
            AddRecipe(ItemID.MushroomCampfire,
                    [Ingredient(ItemID.MushroomTorch, 45), Ingredient(ItemID.GlowingMushroom, 12)],
                    [TileID.WorkBenches]);
            AddRecipe(ItemID.CoralCampfire, [Ingredient(ItemID.CoralTorch, 45), Ingredient(ItemID.ReefBlock, 12)],
                    [TileID.WorkBenches]);
            AddRecipe(ItemID.CorruptCampfire, [Ingredient(ItemID.CorruptTorch, 45), Ingredient(ItemID.Ebonwood, 12)],
                    [TileID.DemonAltar]);
            AddRecipe(ItemID.CrimsonCampfire, [Ingredient(ItemID.CrimsonTorch, 45), Ingredient(ItemID.Shadewood, 12)],
                    [TileID.DemonAltar]);
            AddRecipe(ItemID.IchorCampfire, [Ingredient(ItemID.IchorTorch, 45), Ingredient(ItemID.SpookyWood, 12)],
                    [TileID.DemonAltar]);
            AddRecipe(ItemID.CursedCampfire, [Ingredient(ItemID.CursedTorch, 45), Ingredient(ItemID.SpookyWood, 12)],
                    [TileID.DemonAltar]);
            AddRecipe(ItemID.BoneCampfire, [Ingredient(ItemID.BoneTorch, 45), Ingredient(ItemID.Bone, 12)],
                    [TileID.BoneWelder]);
            AddRecipe(ItemID.UltraBrightCampfire,
                    [Ingredient(ItemID.UltrabrightTorch, 45), Ingredient(ItemID.DynastyWood, 12)],
                    [TileID.WorkBenches]);
            AddRecipe(ItemID.DemonCampfire, [Ingredient(ItemID.DemonTorch, 45), Ingredient(ItemID.AshWood, 12)],
                    [TileID.Hellforge]);
            AddRecipe(ItemID.ShimmerCampfire, [Ingredient(ItemID.ShimmerTorch, 45), Ingredient(ItemID.StoneBlock, 12)],
                    [TileID.CookingPots]);
            AddRecipe(ItemID.RainbowCampfire,
                    [Ingredient(ItemID.RainbowTorch, 45), Ingredient(ItemID.RainbowBrick, 12)], [TileID.MeatGrinder]);
            AddRecipe(ItemID.HallowedCampfire, [Ingredient(ItemID.HallowedTorch, 45), Ingredient(ItemID.Pearlwood, 12)],
                    [TileID.MythrilAnvil]);

            AddRecipe(ItemID.HeartLantern, [Ingredient(ItemID.LifeCrystal, 2), Ingredient(ItemID.CagedLantern)],
                    [TileID.Anvils]);

            AddRecipe(ItemID.StarinaBottle, [Ingredient(ItemID.ManaCrystal, 2), Ingredient(ItemID.BottledHoney)],
                    [TileID.Anvils]);

            AddRecipe(ItemID.PeaceCandle, [
                    Ingredient(ItemID.PinkTorch), Ingredient(ItemID.WaterCandle), Ingredient(ItemID.CalmingPotion, 2),
                    Ingredient(ItemID.InvisibilityPotion)
            ], [TileID.BoneWelder]);

            // can be gotten pre skele to make some grind easier
            AddRecipe(ItemID.WaterCandle,
                    [Ingredient(ItemID.BlueTorch), Ingredient(ItemID.Candle), Ingredient(ItemID.BattlePotion, 2)],
                    [TileID.Sinks, TileID.Anvils]);

            AddRecipe(ItemID.SuspiciousLookingEye,
                    [Ingredient(ItemID.Lens, 8), Ingredient(ItemID.RottenChunk, 3), Ingredient(ItemID.VilePowder, 6)],
                    [TileID.DemonAltar]);
            AddRecipe(ItemID.SuspiciousLookingEye,
                    [Ingredient(ItemID.Lens, 8), Ingredient(ItemID.Vertebrae, 3), Ingredient(ItemID.ViciousPowder, 6)],
                    [TileID.DemonAltar]);
            AddRecipe(ItemID.SlimeCrown,
                    [Ingredient(ItemID.GoldCrown), Ingredient(ItemID.Gel, 50), Ingredient(ItemID.PinkGel, 10)],
                    [TileID.DemonAltar]);
            AddRecipe(ItemID.SlimeCrown,
                    [Ingredient(ItemID.PlatinumCrown), Ingredient(ItemID.Gel, 50), Ingredient(ItemID.PinkGel, 10)],
                    [TileID.DemonAltar]);
            AddRecipe(ItemID.WormFood, [Ingredient(ItemID.RottenChunk, 30), Ingredient(ItemID.Stinger, 8)],
                    [TileID.DemonAltar]);
            AddRecipe(ItemID.BloodySpine, [Ingredient(ItemID.Vertebrae, 30), Ingredient(ItemID.Stinger, 8)],
                    [TileID.DemonAltar]);
            AddRecipe(ItemID.Abeemination, [
                    Ingredient(ItemID.Hive, 10), Ingredient(ItemID.Stinger, 6), Ingredient(ItemID.HoneyBlock, 6),
                    Ingredient(ItemID.CrispyHoneyBlock, 6)
            ], [TileID.DemonAltar]);
            AddRecipe(ItemID.DeerThing, [
                    Ingredient(ItemID.FlinxFur, 5), Ingredient(ItemID.Lens, 4), Ingredient(ItemID.BeeWax, 6),
                    Ingredient(ItemID.IceBlock, 80)
            ], [TileID.DemonAltar]);
            AddRecipe(ItemID.MechanicalEye, [
                    Ingredient(ItemID.BlackLens), Ingredient(ItemID.SuspiciousLookingEye),
                    Ingredient(ItemID.SoulofLight, 8), Ingredient(ItemID.Wire, 80)
            ], [TileID.MythrilAnvil]);
            AddRecipe(ItemID.MechanicalWorm, [
                    Ingredient(ItemID.Lens, 8), Ingredient(ItemID.WormFood), Ingredient(ItemID.SoulofNight, 8),
                    Ingredient(ItemID.Wire, 80)
            ], [TileID.MythrilAnvil]);
            AddRecipe(ItemID.MechanicalWorm, [
                    Ingredient(ItemID.Lens, 8), Ingredient(ItemID.BloodySpine), Ingredient(ItemID.SoulofNight, 8),
                    Ingredient(ItemID.Wire, 80)
            ], [TileID.MythrilAnvil]);
            AddRecipe(ItemID.MechanicalSkull, [
                    Ingredient(ItemID.Lens, 6), Ingredient(ItemID.ClothierVoodooDoll),
                    Ingredient(ItemID.SoulofFlight, 25), Ingredient(ItemID.Wire, 80)
            ], [TileID.MythrilAnvil]);
            AddRecipe(ItemID.GoblinBattleStandard,
                    [Ingredient(ItemID.TatteredCloth, 10), Ingredient(ItemID.RichMahogany, 18)],
                    recipeGroups: [RecipeGroup("DemoniteBar", 5)], tiles: [TileID.DemonAltar]);
            AddRecipe(ItemID.CelestialSigil, [
                    Ingredient(ItemID.FragmentSolar, 12), Ingredient(ItemID.FragmentVortex, 12),
                    Ingredient(ItemID.FragmentNebula, 12), Ingredient(ItemID.FragmentStardust, 12),
                    Ingredient(ItemID.MartianConduitPlating, 100)
            ], [TileID.LunarCraftingStation]);

            AddRecipe(ItemID.WoodenDoor, [Ingredient(ItemID.Wood, 8), Ingredient(ItemID.StoneBlock, 3)],
                    [TileID.WorkBenches]);
            AddRecipe(ItemID.BorealWoodDoor, [Ingredient(ItemID.BorealWood, 8), Ingredient(ItemID.SnowBlock, 3)],
                    [TileID.WorkBenches]);
            AddRecipe(ItemID.RichMahoganyDoor, [Ingredient(ItemID.RichMahogany, 8), Ingredient(ItemID.MudBlock, 3)],
                    [TileID.WorkBenches]);
            AddRecipe(ItemID.PalmWoodDoor, [Ingredient(ItemID.PalmWood, 8), Ingredient(ItemID.SandBlock, 3)],
                    [TileID.WorkBenches]);
            AddRecipe(ItemID.AshWoodDoor, [Ingredient(ItemID.AshWood, 8), Ingredient(ItemID.AshBlock, 3)],
                    [TileID.WorkBenches]);
            AddRecipe(ItemID.EbonwoodDoor, [Ingredient(ItemID.Ebonwood, 8), Ingredient(ItemID.EbonstoneBlock, 3)],
                    [TileID.WorkBenches]);
            AddRecipe(ItemID.ShadewoodDoor, [Ingredient(ItemID.Shadewood, 8), Ingredient(ItemID.CrimstoneBlock, 3)],
                    [TileID.WorkBenches]);

            AddRecipe(ItemID.WoodenChair, [Ingredient(ItemID.Wood, 6)], [TileID.WorkBenches]);
            AddRecipe(ItemID.BorealWoodChair, [Ingredient(ItemID.BorealWood, 6)], [TileID.WorkBenches]);
            AddRecipe(ItemID.RichMahoganyChair, [Ingredient(ItemID.RichMahogany, 6)], [TileID.WorkBenches]);
            AddRecipe(ItemID.PalmWoodChair, [Ingredient(ItemID.PalmWood, 6)], [TileID.WorkBenches]);
            AddRecipe(ItemID.AshWoodChair, [Ingredient(ItemID.AshWood, 6)], [TileID.WorkBenches]);
            AddRecipe(ItemID.EbonwoodChair, [Ingredient(ItemID.Ebonwood, 6)], [TileID.WorkBenches]);
            AddRecipe(ItemID.ShadewoodChair, [Ingredient(ItemID.Shadewood, 6)], [TileID.WorkBenches]);

            AddRecipe(ItemID.WoodenTable, [Ingredient(ItemID.WorkBench), Ingredient(ItemID.Wood, 8)],
                    [TileID.WorkBenches]);
            AddRecipe(ItemID.BorealWoodTable,
                    [Ingredient(ItemID.BorealWoodWorkBench), Ingredient(ItemID.BorealWood, 8)], [TileID.WorkBenches]);
            AddRecipe(ItemID.RichMahoganyTable,
                    [Ingredient(ItemID.RichMahoganyWorkBench), Ingredient(ItemID.RichMahogany, 8)],
                    [TileID.WorkBenches]);
            AddRecipe(ItemID.PalmWoodTable, [Ingredient(ItemID.PalmWoodWorkBench), Ingredient(ItemID.PalmWood, 8)],
                    [TileID.WorkBenches]);
            AddRecipe(ItemID.AshWoodTable, [Ingredient(ItemID.AshWoodWorkbench), Ingredient(ItemID.AshWood, 8)],
                    [TileID.WorkBenches]);
            AddRecipe(ItemID.EbonwoodTable, [Ingredient(ItemID.EbonwoodWorkBench), Ingredient(ItemID.Ebonwood, 8)],
                    [TileID.WorkBenches]);
            AddRecipe(ItemID.ShadewoodTable, [Ingredient(ItemID.ShadewoodWorkBench), Ingredient(ItemID.Shadewood, 8)],
                    [TileID.WorkBenches]);

            AddRecipe(ItemID.Dresser,
                    [Ingredient(ItemID.WoodenTable), Ingredient(ItemID.Wood, 16), Ingredient(ItemID.Chest)],
                    [TileID.Sawmill]);
            AddRecipe(ItemID.Barrel, [Ingredient(ItemID.Wood, 6), Ingredient(ItemID.Chest)], [TileID.Sawmill]);
            AddRecipe(ItemID.PicnicTable, [Ingredient(ItemID.WoodenTable), Ingredient(ItemID.Wood, 18)],
                    [TileID.Sawmill]);
            AddRecipe(ItemID.Bench, [Ingredient(ItemID.WoodenChair), Ingredient(ItemID.Wood, 12)], [TileID.Sawmill]);
            AddRecipe(ItemID.BanquetTable, [Ingredient(ItemID.WoodenTable), Ingredient(ItemID.Wood, 18)],
                    [TileID.Sawmill]);
            AddRecipe(ItemID.Bar, [Ingredient(ItemID.WoodenTable), Ingredient(ItemID.Wood, 18)], [TileID.Sawmill]);
            AddRecipe(ItemID.BarStool, [Ingredient(ItemID.WoodenChair), Ingredient(ItemID.Wood, 12)], [TileID.Sawmill]);
            AddRecipe(ItemID.Sofa,
                    [Ingredient(ItemID.WoodenChair), Ingredient(ItemID.Wood, 12), Ingredient(ItemID.Silk, 4)],
                    [TileID.Sawmill]);
            AddRecipe(ItemID.Chest, [Ingredient(ItemID.Wood, 12)], [TileID.Sawmill],
                    recipeGroups: [RecipeGroup("IronBar", 3)]);
            AddRecipe(ItemID.Bed, [Ingredient(ItemID.Wood, 25), Ingredient(ItemID.Silk, 8)],
                    [TileID.Sawmill, TileID.Loom]);
            AddRecipe(ItemID.Bookcase, [Ingredient(ItemID.Wood, 30), Ingredient(ItemID.Book, 12)], [TileID.Sawmill]);
            AddRecipe(ItemID.Trapdoor, [Ingredient(ItemID.Wood, 12)], [TileID.Sawmill, TileID.HeavyWorkBench],
                    recipeGroups: [RecipeGroup("IronBar", 4)]);
            AddRecipe(ItemID.TallGate, [Ingredient(ItemID.Wood, 24)], [TileID.Sawmill, TileID.HeavyWorkBench],
                    recipeGroups: [RecipeGroup("IronBar", 8)]);

            AddRecipe(ItemID.WebRope, [Ingredient(ItemID.Cobweb, 2)], [TileID.WorkBenches], amount: 2);
            AddRecipe(ItemID.SilkRope, [Ingredient(ItemID.Silk)], [TileID.Loom], amount: 10);

            AddRecipe(ItemID.SnowCloudBlock, [Ingredient(ItemID.Cloud), Ingredient(ItemID.SnowBlock, 2)],
                    [TileID.SkyMill], [Condition.InSnow]);

            if (ModContent.GetInstance<ArgosConfig>().HellMode)
            {
                AddRecipe(ItemID.Torch, [Ingredient(ItemID.Gel), Ingredient(ItemID.Wood)], [TileID.WorkBenches]);
            }
            else
            {
                AddRecipe(ItemID.Torch, [Ingredient(ItemID.Gel), Ingredient(ItemID.Wood)], [TileID.WorkBenches],
                        amount: 2);
            }

            AddRecipe(ItemID.TikiTorch,
                    [Ingredient(ItemID.Torch), Ingredient(ItemID.Wood, 4), Ingredient(ItemID.StoneBlock, 2)],
                    [TileID.WorkBenches]);
            AddRecipe(ItemID.CursedTorch, [Ingredient(ItemID.Torch, 10), Ingredient(ItemID.CursedFlame)],
                    [TileID.CrystalBall], amount: 10);
            AddRecipe(ItemID.IchorTorch, [Ingredient(ItemID.Torch, 10), Ingredient(ItemID.Ichor)], [TileID.CrystalBall],
                    amount: 10);
            AddRecipe(ItemID.RainbowTorch, [Ingredient(ItemID.Torch, 5), Ingredient(ItemID.RainbowBrick)],
                    [TileID.CrystalBall], amount: 5);
            AddRecipe(ItemID.JungleTorch, [Ingredient(ItemID.Torch, 5), Ingredient(ItemID.JungleSpores)],
                    [TileID.LivingLoom], amount: 5);
            AddRecipe(ItemID.BlueTorch, [Ingredient(ItemID.Torch, 5), Ingredient(ItemID.Sapphire)], [TileID.Anvils],
                    amount: 5);
            AddRecipe(ItemID.PurpleTorch, [Ingredient(ItemID.Torch, 5), Ingredient(ItemID.Amethyst)], [TileID.Anvils],
                    amount: 5);
            AddRecipe(ItemID.WhiteTorch, [Ingredient(ItemID.Torch, 5), Ingredient(ItemID.Diamond)], [TileID.Anvils],
                    amount: 5);
            AddRecipe(ItemID.YellowTorch, [Ingredient(ItemID.Torch, 5), Ingredient(ItemID.Topaz)], [TileID.Anvils],
                    amount: 5);
            AddRecipe(ItemID.OrangeTorch, [Ingredient(ItemID.Torch, 5), Ingredient(ItemID.Amber)], [TileID.Anvils],
                    amount: 5);
            AddRecipe(ItemID.GreenTorch, [Ingredient(ItemID.Torch, 5), Ingredient(ItemID.Emerald)], [TileID.Anvils],
                    amount: 5);
            AddRecipe(ItemID.IceTorch, [Ingredient(ItemID.Torch), Ingredient(ItemID.IceBlock)], [TileID.WorkBenches]);
            AddRecipe(ItemID.DesertTorch, [Ingredient(ItemID.Torch), Ingredient(ItemID.HardenedSand)],
                    [TileID.WorkBenches]);
            AddRecipe(ItemID.CoralTorch, [Ingredient(ItemID.Torch), Ingredient(ItemID.Coral)], [TileID.WorkBenches]);
            AddRecipe(ItemID.CorruptTorch, [Ingredient(ItemID.Torch), Ingredient(ItemID.EbonstoneBlock)],
                    [TileID.Anvils]);
            AddRecipe(ItemID.DemonTorch, [Ingredient(ItemID.Torch), Ingredient(ItemID.Obsidian)], [TileID.Anvils]);
            AddRecipe(ItemID.CrimsonTorch, [Ingredient(ItemID.Torch), Ingredient(ItemID.CrimstoneBlock)],
                    [TileID.Anvils]);
            AddRecipe(ItemID.PinkTorch, [Ingredient(ItemID.Torch), Ingredient(ItemID.PinkGel)], [TileID.Anvils]);
            AddRecipe(ItemID.MushroomTorch, [Ingredient(ItemID.Torch), Ingredient(ItemID.GlowingMushroom)],
                    [TileID.Anvils]);
            AddRecipe(ItemID.HallowedTorch, [Ingredient(ItemID.Torch), Ingredient(ItemID.PearlstoneBlock)],
                    [TileID.MythrilAnvil]);

            AddRecipe(ItemID.WorkBench,
                    [Ingredient(ItemID.Wood, 25), Ingredient(ItemID.WoodPlatform, 8), Ingredient(ItemID.Cobweb, 12)]);

            AddRecipe(ItemID.LivingWoodWorkBench, [
                    Ingredient(ItemID.Wood, 25), Ingredient(ItemID.LivingWoodPlatform, 8), Ingredient(ItemID.Cobweb, 12)
            ], [TileID.LivingLoom]);

            AddRecipe(ItemID.PumpkinWorkBench, [
                    Ingredient(ItemID.Pumpkin, 25), Ingredient(ItemID.PumpkinPlatform, 8), Ingredient(ItemID.Cobweb, 12)
            ], [TileID.LivingLoom]);

            AddRecipe(ItemID.BorealWoodWorkBench, [
                    Ingredient(ItemID.BorealWood, 25), Ingredient(ItemID.BorealWoodPlatform, 8),
                    Ingredient(ItemID.Cobweb, 12)
            ]);

            AddRecipe(ItemID.RichMahoganyWorkBench, [
                    Ingredient(ItemID.RichMahogany, 25), Ingredient(ItemID.RichMahoganyPlatform, 8),
                    Ingredient(ItemID.Cobweb, 12)
            ]);

            AddRecipe(ItemID.PalmWoodWorkBench, [
                    Ingredient(ItemID.PalmWood, 25), Ingredient(ItemID.PalmWoodPlatform, 8),
                    Ingredient(ItemID.Cobweb, 12)
            ]);

            AddRecipe(ItemID.EbonwoodWorkBench, [
                    Ingredient(ItemID.Ebonwood, 25), Ingredient(ItemID.EbonwoodPlatform, 8),
                    Ingredient(ItemID.Cobweb, 12)
            ]);

            AddRecipe(ItemID.DynastyWorkBench, [
                    Ingredient(ItemID.DynastyWood, 25), Ingredient(ItemID.DynastyPlatform, 8),
                    Ingredient(ItemID.Cobweb, 12)
            ]);

            AddRecipe(ItemID.BambooWorkbench, [
                    Ingredient(ItemID.BambooBlock, 25), Ingredient(ItemID.BambooPlatform, 8),
                    Ingredient(ItemID.Cobweb, 12)
            ]);

            AddRecipe(ItemID.ShadewoodWorkBench, [
                    Ingredient(ItemID.Shadewood, 25), Ingredient(ItemID.ShadewoodPlatform, 8),
                    Ingredient(ItemID.Cobweb, 12)
            ]);

            AddRecipe(ItemID.MushroomWorkBench, [
                    Ingredient(ItemID.GlowingMushroom, 25), Ingredient(ItemID.MushroomPlatform, 8),
                    Ingredient(ItemID.Cobweb, 12)
            ]);

            AddRecipe(ItemID.SandstoneWorkbench, [
                    Ingredient(ItemID.Sandstone, 25), Ingredient(ItemID.SandstonePlatform, 8),
                    Ingredient(ItemID.AntlionMandible, 4)
            ], [TileID.Anvils]);

            AddRecipe(ItemID.MarbleWorkBench, [Ingredient(ItemID.MarbleBlock, 25)], [TileID.Anvils]);

            AddRecipe(ItemID.GraniteWorkBench, [Ingredient(ItemID.GraniteBlock, 25)], [TileID.Anvils]);

            AddRecipe(ItemID.AshWoodWorkbench, [
                    Ingredient(ItemID.AshWood, 25), Ingredient(ItemID.AshWoodPlatform, 8), Ingredient(ItemID.Cobweb, 12)
            ]);

            AddRecipe(ItemID.CactusWorkBench, [
                    Ingredient(ItemID.Cactus, 25), Ingredient(ItemID.CactusPlatform, 4),
                    Ingredient(ItemID.WoodPlatform, 4), Ingredient(ItemID.Cobweb, 12)
            ]);

            AddRecipe(ItemID.Furnace,
                    [Ingredient(ItemID.StoneBlock, 25), Ingredient(ItemID.ClayBlock, 16), Ingredient(ItemID.Torch, 4)],
                    recipeGroups: [RecipeGroup("CopperOre", 8), RecipeGroup("IronOre", 6), RecipeGroup("Wood", 8)],
                    tiles: [TileID.WorkBenches]);

            AddRecipe(ItemID.IronAnvil, [Ingredient(ItemID.IronBar, 12)], recipeGroups: [RecipeGroup("CopperBar", 4)],
                    tiles: [TileID.Furnaces, TileID.WorkBenches]);

            AddRecipe(ItemID.LeadAnvil, [Ingredient(ItemID.LeadBar, 12)], recipeGroups: [RecipeGroup("CopperBar", 4)],
                    tiles: [TileID.Furnaces, TileID.WorkBenches]);

            AddRecipe(ItemID.Sawmill,
                    [Ingredient(ItemID.WorkBench), Ingredient(ItemID.Wood, 24), Ingredient(ItemID.Chain, 4)],
                    recipeGroups: [RecipeGroup("IronBar", 6), RecipeGroup("CopperBar", 4)],
                    tiles: [TileID.WorkBenches, TileID.Anvils]);

            AddRecipe(ItemID.Loom, [
                    Ingredient(ItemID.Cobweb, 32), Ingredient(ItemID.Wood, 42), Ingredient(ItemID.RedDye, 2),
                    Ingredient(ItemID.BlueDye), Ingredient(ItemID.PinkDye)
            ], recipeGroups: [RecipeGroup("IronBar", 6)], tiles: [TileID.Sawmill, TileID.DyeVat]);

            AddRecipe(ItemID.Keg, [
                    Ingredient(ItemID.Barrel), Ingredient(ItemID.Wood, 6), Ingredient(ItemID.Daybloom, 8),
                    Ingredient(ItemID.Blinkroot, 6), Ingredient(ItemID.WaterBucket, 2)
            ], recipeGroups: [RecipeGroup("IronBar", 4)], tiles: [TileID.Sawmill]);

            AddRecipe(ItemID.CookingPot,
                    [Ingredient(ItemID.Campfire), Ingredient(ItemID.Wood, 8), Ingredient(ItemID.Fireblossom, 4)],
                    recipeGroups: [RecipeGroup("IronBar", 14)], tiles: [TileID.HeavyWorkBench]);

            AddRecipe(ItemID.HeavyWorkBench,
                    [Ingredient(ItemID.WorkBench), Ingredient(ItemID.Chain, 6), Ingredient(ItemID.Ruby, 3)],
                    recipeGroups: [RecipeGroup("IronBar", 16), RecipeGroup("IronHammer")],
                    tiles: [TileID.Anvils, TileID.WorkBenches]);

            AddRecipe(ItemID.GlassKiln,
                    [Ingredient(ItemID.Furnace), Ingredient(ItemID.Glass, 30), Ingredient(ItemID.Fireblossom, 4)],
                    recipeGroups: [RecipeGroup("SilverBar", 12)], tiles: [TileID.HeavyWorkBench],
                    conditions: [Condition.NearLava]);

            AddRecipe(ItemID.WoodHelmet, [Ingredient(ItemID.Wood, 22), Ingredient(ItemID.ClayBlock, 10)],
                    [TileID.WorkBenches]);
            AddRecipe(ItemID.WoodBreastplate, [Ingredient(ItemID.Wood, 35), Ingredient(ItemID.ClayBlock, 24)],
                    [TileID.WorkBenches]);
            AddRecipe(ItemID.WoodGreaves, [Ingredient(ItemID.Wood, 28), Ingredient(ItemID.ClayBlock, 16)],
                    [TileID.WorkBenches]);

            AddRecipe(ItemID.BorealWoodHelmet, [Ingredient(ItemID.BorealWood, 22), Ingredient(ItemID.SnowBlock, 20)],
                    [TileID.WorkBenches]);
            AddRecipe(ItemID.BorealWoodBreastplate,
                    [Ingredient(ItemID.BorealWood, 35), Ingredient(ItemID.SnowBlock, 48)], [TileID.WorkBenches]);
            AddRecipe(ItemID.BorealWoodGreaves, [Ingredient(ItemID.BorealWood, 28), Ingredient(ItemID.SnowBlock, 32)],
                    [TileID.WorkBenches]);

            AddRecipe(ItemID.RichMahoganyHelmet,
                    [Ingredient(ItemID.RichMahogany, 22), Ingredient(ItemID.BambooBlock, 20)], [TileID.WorkBenches]);
            AddRecipe(ItemID.RichMahoganyBreastplate,
                    [Ingredient(ItemID.RichMahogany, 35), Ingredient(ItemID.BambooBlock, 48)], [TileID.WorkBenches]);
            AddRecipe(ItemID.RichMahoganyGreaves,
                    [Ingredient(ItemID.RichMahogany, 28), Ingredient(ItemID.BambooBlock, 32)], [TileID.WorkBenches]);

            AddRecipe(ItemID.AshWoodHelmet, [Ingredient(ItemID.AshWood, 22), Ingredient(ItemID.AshBlock, 100)],
                    [TileID.Hellforge]);
            AddRecipe(ItemID.AshWoodBreastplate, [Ingredient(ItemID.AshWood, 35), Ingredient(ItemID.AshBlock, 100)],
                    [TileID.Hellforge]);
            AddRecipe(ItemID.AshWoodGreaves, [Ingredient(ItemID.AshWood, 28), Ingredient(ItemID.AshBlock, 100)],
                    [TileID.Hellforge]);

            AddRecipe(ItemID.PalmWoodHelmet, [Ingredient(ItemID.PalmWood, 22), Ingredient(ItemID.SandBlock, 20)],
                    [TileID.WorkBenches]);
            AddRecipe(ItemID.PalmWoodBreastplate, [Ingredient(ItemID.PalmWood, 35), Ingredient(ItemID.SandBlock, 48)],
                    [TileID.WorkBenches]);
            AddRecipe(ItemID.PalmWoodGreaves, [Ingredient(ItemID.PalmWood, 28), Ingredient(ItemID.SandBlock, 32)],
                    [TileID.WorkBenches]);

            AddRecipe(ItemID.CactusHelmet, [Ingredient(ItemID.Cactus, 22), Ingredient(ItemID.Waterleaf, 4)],
                    [TileID.WorkBenches]);
            AddRecipe(ItemID.CactusBreastplate,
                    [Ingredient(ItemID.Cactus, 35), Ingredient(ItemID.Waterleaf, 8), Ingredient(ItemID.ThornsPotion)],
                    [TileID.WorkBenches]);
            AddRecipe(ItemID.CactusLeggings, [Ingredient(ItemID.Cactus, 28), Ingredient(ItemID.Waterleaf, 6)],
                    [TileID.WorkBenches]);

            AddRecipe(ItemID.ShadewoodHelmet, [Ingredient(ItemID.Shadewood, 22), Ingredient(ItemID.ViciousPowder, 5)],
                    [TileID.WorkBenches]);
            AddRecipe(ItemID.ShadewoodBreastplate,
                    [Ingredient(ItemID.Shadewood, 35), Ingredient(ItemID.ViciousPowder, 8)], [TileID.WorkBenches]);
            AddRecipe(ItemID.ShadewoodGreaves, [Ingredient(ItemID.Shadewood, 28), Ingredient(ItemID.ViciousPowder, 6)],
                    [TileID.WorkBenches]);

            AddRecipe(ItemID.EbonwoodHelmet, [Ingredient(ItemID.Ebonwood, 22), Ingredient(ItemID.VilePowder, 5)],
                    [TileID.WorkBenches]);
            AddRecipe(ItemID.EbonwoodBreastplate, [Ingredient(ItemID.Ebonwood, 35), Ingredient(ItemID.VilePowder, 8)],
                    [TileID.WorkBenches]);
            AddRecipe(ItemID.EbonwoodGreaves, [Ingredient(ItemID.Ebonwood, 28), Ingredient(ItemID.VilePowder, 6)],
                    [TileID.WorkBenches]);

            AddRecipe(ItemID.PearlwoodHelmet,
                    [Ingredient(ItemID.Pearlwood, 22), Ingredient(ItemID.WhitePearl), Ingredient(ItemID.UnicornHorn)],
                    [TileID.WorkBenches]);
            AddRecipe(ItemID.PearlwoodBreastplate, [Ingredient(ItemID.Pearlwood, 35), Ingredient(ItemID.WhitePearl)],
                    [TileID.WorkBenches]);
            AddRecipe(ItemID.PearlwoodGreaves, [Ingredient(ItemID.Pearlwood, 28), Ingredient(ItemID.WhitePearl)],
                    [TileID.WorkBenches]);

            AddRecipe(ItemID.NecroHelmet,
                    [Ingredient(ItemID.Cobweb, 75), Ingredient(ItemID.Bone, 50), Ingredient(ItemID.Spike, 20)],
                    [TileID.BoneWelder]);
            AddRecipe(ItemID.NecroBreastplate,
                    [Ingredient(ItemID.Cobweb, 95), Ingredient(ItemID.Bone, 75), Ingredient(ItemID.Spike, 35)],
                    [TileID.BoneWelder]);
            AddRecipe(ItemID.NecroGreaves,
                    [Ingredient(ItemID.Cobweb, 80), Ingredient(ItemID.Bone, 60), Ingredient(ItemID.Spike, 28)],
                    [TileID.BoneWelder]);

            AddRecipe(ItemID.CopperHelmet, [Ingredient(ItemID.CopperBar, 18)], [TileID.Anvils]);
            AddRecipe(ItemID.CopperChainmail, [Ingredient(ItemID.CopperBar, 30)], [TileID.Anvils]);
            AddRecipe(ItemID.CopperGreaves, [Ingredient(ItemID.CopperBar, 24)], [TileID.Anvils]);

            AddRecipe(ItemID.TinHelmet, [Ingredient(ItemID.TinBar, 18)], [TileID.Anvils]);
            AddRecipe(ItemID.TinChainmail, [Ingredient(ItemID.TinBar, 30)], [TileID.Anvils]);
            AddRecipe(ItemID.TinGreaves, [Ingredient(ItemID.TinBar, 24)], [TileID.Anvils]);

            AddRecipe(ItemID.IronHelmet, [Ingredient(ItemID.IronBar, 18)], [TileID.Anvils]);
            AddRecipe(ItemID.IronChainmail, [Ingredient(ItemID.IronBar, 30)], [TileID.Anvils]);
            AddRecipe(ItemID.IronGreaves, [Ingredient(ItemID.IronBar, 24)], [TileID.Anvils]);

            AddRecipe(ItemID.LeadHelmet, [Ingredient(ItemID.LeadBar, 18)], [TileID.Anvils]);
            AddRecipe(ItemID.LeadChainmail, [Ingredient(ItemID.LeadBar, 30)], [TileID.Anvils]);
            AddRecipe(ItemID.LeadGreaves, [Ingredient(ItemID.LeadBar, 24)], [TileID.Anvils]);

            AddRecipe(ItemID.SilverHelmet, [Ingredient(ItemID.SilverBar, 18), Ingredient(ItemID.Sapphire, 2)],
                    [TileID.Anvils]);
            AddRecipe(ItemID.SilverChainmail, [Ingredient(ItemID.SilverBar, 30), Ingredient(ItemID.Emerald)],
                    [TileID.Anvils]);
            AddRecipe(ItemID.SilverGreaves, [Ingredient(ItemID.SilverBar, 24), Ingredient(ItemID.Silk, 6)],
                    [TileID.Anvils]);

            AddRecipe(ItemID.TungstenHelmet, [Ingredient(ItemID.TungstenBar, 18), Ingredient(ItemID.Sapphire, 2)],
                    [TileID.Anvils]);
            AddRecipe(ItemID.TungstenChainmail, [Ingredient(ItemID.TungstenBar, 30), Ingredient(ItemID.Emerald)],
                    [TileID.Anvils]);
            AddRecipe(ItemID.TungstenGreaves, [Ingredient(ItemID.TungstenBar, 24), Ingredient(ItemID.Silk, 6)],
                    [TileID.Anvils]);

            AddRecipe(ItemID.GoldHelmet, [Ingredient(ItemID.GoldBar, 18), Ingredient(ItemID.Ruby, 2)], [TileID.Anvils]);
            AddRecipe(ItemID.GoldChainmail, [Ingredient(ItemID.GoldBar, 30), Ingredient(ItemID.Ruby)], [TileID.Anvils]);
            AddRecipe(ItemID.GoldGreaves, [Ingredient(ItemID.GoldBar, 24), Ingredient(ItemID.Silk, 6)],
                    [TileID.Anvils]);

            AddRecipe(ItemID.PlatinumHelmet, [Ingredient(ItemID.PlatinumBar, 18), Ingredient(ItemID.Ruby, 2)],
                    [TileID.Anvils]);
            AddRecipe(ItemID.PlatinumChainmail, [Ingredient(ItemID.PlatinumBar, 30), Ingredient(ItemID.Ruby)],
                    [TileID.Anvils]);
            AddRecipe(ItemID.PlatinumGreaves, [Ingredient(ItemID.PlatinumBar, 24), Ingredient(ItemID.Silk, 6)],
                    [TileID.Anvils]);

            AddRecipe(ItemID.ShadowHelmet, [
                    Ingredient(ItemID.EbonwoodHelmet), Ingredient(ItemID.DemoniteBar, 18),
                    Ingredient(ItemID.ShadowScale, 12), Ingredient(ItemID.VilePowder, 3)
            ], [TileID.Anvils], [Condition.InCorrupt]);
            AddRecipe(ItemID.ShadowScalemail, [
                    Ingredient(ItemID.EbonwoodBreastplate), Ingredient(ItemID.DemoniteBar, 30),
                    Ingredient(ItemID.ShadowScale, 22), Ingredient(ItemID.VilePowder, 3)
            ], [TileID.Anvils], [Condition.InCorrupt]);
            AddRecipe(ItemID.ShadowGreaves, [
                    Ingredient(ItemID.EbonwoodGreaves), Ingredient(ItemID.DemoniteBar, 24),
                    Ingredient(ItemID.ShadowScale, 18), Ingredient(ItemID.VilePowder, 3)
            ], [TileID.Anvils], [Condition.InCorrupt]);

            AddRecipe(ItemID.CrimsonHelmet, [
                    Ingredient(ItemID.ShadewoodHelmet), Ingredient(ItemID.CrimtaneBar, 18),
                    Ingredient(ItemID.TissueSample, 12), Ingredient(ItemID.ViciousPowder, 3)
            ], [TileID.Anvils], [Condition.InCrimson]);
            AddRecipe(ItemID.CrimsonScalemail, [
                    Ingredient(ItemID.ShadewoodBreastplate), Ingredient(ItemID.CrimtaneBar, 30),
                    Ingredient(ItemID.TissueSample, 22), Ingredient(ItemID.ViciousPowder, 3)
            ], [TileID.Anvils], [Condition.InCrimson]);
            AddRecipe(ItemID.CrimsonGreaves, [
                    Ingredient(ItemID.ShadewoodGreaves), Ingredient(ItemID.CrimtaneBar, 24),
                    Ingredient(ItemID.TissueSample, 18), Ingredient(ItemID.ViciousPowder, 3)
            ], [TileID.Anvils], [Condition.InCrimson]);

            AddRecipe(ItemID.CobaltHelmet, [Ingredient(ItemID.CobaltBar, 18)], [TileID.MythrilAnvil],
                    recipeGroups: [RecipeGroup("CopperHelmet")]);
            AddRecipe(ItemID.CobaltHat, [Ingredient(ItemID.CobaltBar, 18)], [TileID.MythrilAnvil],
                    recipeGroups: [RecipeGroup("CopperHelmet")]);
            AddRecipe(ItemID.CobaltMask, [Ingredient(ItemID.CobaltBar, 18)], [TileID.MythrilAnvil],
                    recipeGroups: [RecipeGroup("CopperHelmet")]);
            AddRecipe(ItemID.CobaltBreastplate, [Ingredient(ItemID.CobaltBar, 30)], [TileID.MythrilAnvil],
                    recipeGroups: [RecipeGroup("CopperChainmail")]);
            AddRecipe(ItemID.CobaltLeggings, [Ingredient(ItemID.CobaltBar, 24)], [TileID.MythrilAnvil],
                    recipeGroups: [RecipeGroup("CopperGreaves")]);

            AddRecipe(ItemID.PalladiumHelmet, [Ingredient(ItemID.PalladiumBar, 18)], [TileID.MythrilAnvil],
                    recipeGroups: [RecipeGroup("CopperHelmet")]);
            AddRecipe(ItemID.PalladiumHeadgear, [Ingredient(ItemID.PalladiumBar, 18)], [TileID.MythrilAnvil],
                    recipeGroups: [RecipeGroup("CopperHelmet")]);
            AddRecipe(ItemID.PalladiumMask, [Ingredient(ItemID.PalladiumBar, 18)], [TileID.MythrilAnvil],
                    recipeGroups: [RecipeGroup("CopperHelmet")]);
            AddRecipe(ItemID.PalladiumBreastplate, [Ingredient(ItemID.PalladiumBar, 30)], [TileID.MythrilAnvil],
                    recipeGroups: [RecipeGroup("CopperChainmail")]);
            AddRecipe(ItemID.PalladiumLeggings, [Ingredient(ItemID.PalladiumBar, 24)], [TileID.MythrilAnvil],
                    recipeGroups: [RecipeGroup("CopperGreaves")]);

            AddRecipe(ItemID.MythrilHelmet, [Ingredient(ItemID.MythrilBar, 18)], [TileID.MythrilAnvil],
                    recipeGroups: [RecipeGroup("IronHelmet")]);
            AddRecipe(ItemID.MythrilHat, [Ingredient(ItemID.MythrilBar, 18)], [TileID.MythrilAnvil],
                    recipeGroups: [RecipeGroup("IronHelmet")]);
            AddRecipe(ItemID.MythrilHood, [Ingredient(ItemID.MythrilBar, 18)], [TileID.MythrilAnvil],
                    recipeGroups: [RecipeGroup("IronHelmet")]);
            AddRecipe(ItemID.MythrilChainmail,
                    [Ingredient(ItemID.MythrilBar, 30), Ingredient(ItemID.AncientBattleArmorMaterial)],
                    [TileID.MythrilAnvil], recipeGroups: [RecipeGroup("IronChainmail")]);
            AddRecipe(ItemID.MythrilGreaves, [Ingredient(ItemID.MythrilBar, 24)], [TileID.MythrilAnvil],
                    recipeGroups: [RecipeGroup("IronGreaves")]);

            AddRecipe(ItemID.OrichalcumHelmet, [Ingredient(ItemID.OrichalcumBar, 18)], [TileID.MythrilAnvil],
                    recipeGroups: [RecipeGroup("IronHelmet")]);
            AddRecipe(ItemID.OrichalcumHeadgear, [Ingredient(ItemID.OrichalcumBar, 18)], [TileID.MythrilAnvil],
                    recipeGroups: [RecipeGroup("IronHelmet")]);
            AddRecipe(ItemID.OrichalcumMask, [Ingredient(ItemID.OrichalcumBar, 18)], [TileID.MythrilAnvil],
                    recipeGroups: [RecipeGroup("IronHelmet")]);
            AddRecipe(ItemID.OrichalcumBreastplate,
                    [Ingredient(ItemID.OrichalcumBar, 30), Ingredient(ItemID.AncientBattleArmorMaterial)],
                    [TileID.MythrilAnvil], recipeGroups: [RecipeGroup("IronChainmail")]);
            AddRecipe(ItemID.OrichalcumLeggings, [Ingredient(ItemID.OrichalcumBar, 24)], [TileID.MythrilAnvil],
                    recipeGroups: [RecipeGroup("IronGreaves")]);

            AddRecipe(ItemID.AdamantiteHelmet, [Ingredient(ItemID.AdamantiteBar, 18)], [TileID.MythrilAnvil],
                    recipeGroups: [RecipeGroup("SilverHelmet")]);
            AddRecipe(ItemID.AdamantiteMask, [Ingredient(ItemID.AdamantiteBar, 18)], [TileID.MythrilAnvil],
                    recipeGroups: [RecipeGroup("SilverHelmet")]);
            AddRecipe(ItemID.AdamantiteHeadgear, [Ingredient(ItemID.AdamantiteBar, 18)], [TileID.MythrilAnvil],
                    recipeGroups: [RecipeGroup("SilverHelmet")]);
            AddRecipe(ItemID.AdamantiteBreastplate,
                    [Ingredient(ItemID.AdamantiteBar, 30), Ingredient(ItemID.FrostCore)], [TileID.MythrilAnvil],
                    recipeGroups: [RecipeGroup("SilverChainmail")]);
            AddRecipe(ItemID.AdamantiteLeggings, [Ingredient(ItemID.AdamantiteBar, 24)], [TileID.MythrilAnvil],
                    recipeGroups: [RecipeGroup("SilverGreaves")]);

            AddRecipe(ItemID.TitaniumHelmet, [Ingredient(ItemID.TitaniumBar, 18)], [TileID.MythrilAnvil],
                    recipeGroups: [RecipeGroup("SilverHelmet")]);
            AddRecipe(ItemID.TitaniumHeadgear, [Ingredient(ItemID.TitaniumBar, 18)], [TileID.MythrilAnvil],
                    recipeGroups: [RecipeGroup("SilverHelmet")]);
            AddRecipe(ItemID.TitaniumMask, [Ingredient(ItemID.TitaniumBar, 18)], [TileID.MythrilAnvil],
                    recipeGroups: [RecipeGroup("SilverHelmet")]);
            AddRecipe(ItemID.TitaniumBreastplate, [Ingredient(ItemID.TitaniumBar, 30), Ingredient(ItemID.FrostCore)],
                    [TileID.MythrilAnvil], recipeGroups: [RecipeGroup("SilverChainmail")]);
            AddRecipe(ItemID.TitaniumLeggings, [Ingredient(ItemID.TitaniumBar, 24)], [TileID.MythrilAnvil],
                    recipeGroups: [RecipeGroup("SilverGreaves")]);

            AddRecipe(ItemID.HallowedHelmet, [Ingredient(ItemID.HallowedBar, 18)], [TileID.MythrilAnvil],
                    recipeGroups: [RecipeGroup("GoldHelmet")]);
            AddRecipe(ItemID.HallowedHeadgear, [Ingredient(ItemID.HallowedBar, 18)], [TileID.MythrilAnvil],
                    recipeGroups: [RecipeGroup("GoldHelmet")]);
            AddRecipe(ItemID.HallowedHood, [Ingredient(ItemID.HallowedBar, 18)], [TileID.MythrilAnvil],
                    recipeGroups: [RecipeGroup("GoldHelmet")]);
            AddRecipe(ItemID.HallowedMask, [Ingredient(ItemID.HallowedBar, 18)], [TileID.MythrilAnvil],
                    recipeGroups: [RecipeGroup("GoldHelmet")]);
            AddRecipe(ItemID.HallowedPlateMail, [Ingredient(ItemID.HallowedBar, 30), Ingredient(ItemID.RedCape)],
                    [TileID.MythrilAnvil], recipeGroups: [RecipeGroup("GoldChainmail")]);
            AddRecipe(ItemID.HallowedGreaves, [Ingredient(ItemID.HallowedBar, 24), Ingredient(ItemID.AsphaltBlock, 35)],
                    [TileID.MythrilAnvil], recipeGroups: [RecipeGroup("GoldGreaves")]);

            AddRecipe(ItemID.AncientHallowedHelmet, [Ingredient(ItemID.HallowedBar, 18)], [TileID.MythrilAnvil],
                    recipeGroups: [RecipeGroup("GoldHelmet")]);
            AddRecipe(ItemID.AncientHallowedHeadgear, [Ingredient(ItemID.HallowedBar, 18)], [TileID.MythrilAnvil],
                    recipeGroups: [RecipeGroup("GoldHelmet")]);
            AddRecipe(ItemID.AncientHallowedHood, [Ingredient(ItemID.HallowedBar, 18)], [TileID.MythrilAnvil],
                    recipeGroups: [RecipeGroup("GoldHelmet")]);
            AddRecipe(ItemID.AncientHallowedMask, [Ingredient(ItemID.HallowedBar, 18)], [TileID.MythrilAnvil],
                    recipeGroups: [RecipeGroup("GoldHelmet")]);
            AddRecipe(ItemID.AncientHallowedPlateMail, [Ingredient(ItemID.HallowedBar, 30)], [TileID.MythrilAnvil],
                    recipeGroups: [RecipeGroup("GoldChainmail")]);
            AddRecipe(ItemID.AncientHallowedGreaves,
                    [Ingredient(ItemID.HallowedBar, 24), Ingredient(ItemID.AsphaltBlock, 35)], [TileID.MythrilAnvil],
                    recipeGroups: [RecipeGroup("GoldGreaves")]);

            AddRecipe(ItemID.MeteorHelmet,
                    [Ingredient(ItemID.MeteoriteBar, 12), Ingredient(ItemID.Lens, 2), Ingredient(ItemID.Obsidian, 15)],
                    [TileID.Anvils]);
            AddRecipe(ItemID.MeteorSuit, [Ingredient(ItemID.MeteoriteBar, 25), Ingredient(ItemID.Obsidian, 20)],
                    [TileID.Anvils]);
            AddRecipe(ItemID.MeteorLeggings, [Ingredient(ItemID.MeteoriteBar, 20), Ingredient(ItemID.Obsidian, 15)],
                    [TileID.Anvils]);

            AddRecipe(ItemID.BeeHeadgear, [Ingredient(ItemID.BeeWax, 10), Ingredient(ItemID.Stinger, 12)],
                    [TileID.HoneyDispenser]);
            AddRecipe(ItemID.BeeBreastplate,
                    [Ingredient(ItemID.BeeWax, 14), Ingredient(ItemID.Stinger, 16), Ingredient(ItemID.BottledHoney, 8)],
                    [TileID.HoneyDispenser]);
            AddRecipe(ItemID.BeeGreaves, [Ingredient(ItemID.BeeWax, 12), Ingredient(ItemID.Stinger, 10)],
                    [TileID.HoneyDispenser]);

            AddRecipe(ItemID.SpookyHelmet, [
                    Ingredient(ItemID.SpookyWood, 222), Ingredient(ItemID.SpectreBar, 15),
                    Ingredient(ItemID.PumpkinHelmet)
            ], [TileID.MythrilAnvil]);
            AddRecipe(ItemID.SpookyBreastplate, [
                    Ingredient(ItemID.SpookyWood, 444), Ingredient(ItemID.SpectreBar, 25),
                    Ingredient(ItemID.SpookyTwig), Ingredient(ItemID.PumpkinHelmet)
            ], [TileID.MythrilAnvil]);
            AddRecipe(ItemID.SpookyLeggings, [
                    Ingredient(ItemID.SpookyWood, 333), Ingredient(ItemID.SpectreBar, 20),
                    Ingredient(ItemID.PumpkinLeggings)
            ], [TileID.MythrilAnvil]);

            AddRecipe(ItemID.PumpkinHelmet, [
                    Ingredient(ItemID.Pumpkin, 40), Ingredient(ItemID.GrassSeeds, 100),
                    Ingredient(ItemID.YellowMarigold)
            ], [TileID.LivingLoom]);
            AddRecipe(ItemID.PumpkinBreastplate, [
                    Ingredient(ItemID.Pumpkin, 85), Ingredient(ItemID.GrassSeeds, 150),
                    Ingredient(ItemID.YellowMarigold, 2)
            ], [TileID.LivingLoom]);
            AddRecipe(ItemID.PumpkinLeggings, [
                    Ingredient(ItemID.Pumpkin, 50), Ingredient(ItemID.GrassSeeds, 120),
                    Ingredient(ItemID.YellowMarigold, 2)
            ], [TileID.LivingLoom]);

            AddRecipe(ItemID.FossilHelm,
                    [Ingredient(ItemID.FossilOre, 25), Ingredient(ItemID.AntlionMandible, 6), Ingredient(ItemID.Amber)],
                    [TileID.Anvils]);
            AddRecipe(ItemID.FossilShirt, [
                    Ingredient(ItemID.FossilOre, 30), Ingredient(ItemID.AntlionMandible, 14),
                    Ingredient(ItemID.Amber, 2)
            ], [TileID.Anvils]);
            AddRecipe(ItemID.FossilPants, [
                    Ingredient(ItemID.FossilOre, 20), Ingredient(ItemID.AntlionMandible, 11), Ingredient(ItemID.Amber)
            ], [TileID.Anvils]);

            AddRecipe(ItemID.MoltenHelmet, [
                    Ingredient(ItemID.HellstoneBar, 20), Ingredient(ItemID.LavaBucket, 12),
                    Ingredient(ItemID.AshWoodHelmet)
            ], [TileID.Hellforge], [Condition.NearLava]);
            AddRecipe(ItemID.MoltenBreastplate, [
                    Ingredient(ItemID.HellstoneBar, 30), Ingredient(ItemID.LavaBucket, 20),
                    Ingredient(ItemID.AshWoodBreastplate)
            ], [TileID.Hellforge], [Condition.NearLava]);
            AddRecipe(ItemID.MoltenGreaves, [
                    Ingredient(ItemID.HellstoneBar, 25), Ingredient(ItemID.LavaBucket, 16),
                    Ingredient(ItemID.AshWoodGreaves)
            ], [TileID.Hellforge], [Condition.NearLava]);

            AddRecipe(ItemID.JungleHat, [
                    Ingredient(ItemID.JungleSpores, 10), Ingredient(ItemID.Vine, 3),
                    Ingredient(ItemID.RichMahoganyHelmet)
            ], [TileID.LivingLoom]);
            AddRecipe(ItemID.JungleShirt, [
                    Ingredient(ItemID.JungleSpores, 22), Ingredient(ItemID.Stinger, 8), Ingredient(ItemID.Vine, 3),
                    Ingredient(ItemID.RichMahoganyBreastplate)
            ], [TileID.LivingLoom]);
            AddRecipe(ItemID.JunglePants, [
                    Ingredient(ItemID.JungleSpores, 16), Ingredient(ItemID.Stinger, 2), Ingredient(ItemID.Vine, 2),
                    Ingredient(ItemID.RichMahoganyGreaves)
            ], [TileID.LivingLoom]);

            AddRecipe(ItemID.VortexHelmet, [Ingredient(ItemID.FragmentVortex, 12), Ingredient(ItemID.LunarBar, 10)],
                    recipeGroups: [RecipeGroup("ShroomiteHelmet")], tiles: [TileID.LunarCraftingStation]);
            AddRecipe(ItemID.VortexBreastplate, [
                    Ingredient(ItemID.FragmentVortex, 24), Ingredient(ItemID.LunarBar, 20),
                    Ingredient(ItemID.ShroomiteBreastplate)
            ], [TileID.LunarCraftingStation]);
            AddRecipe(ItemID.VortexLeggings, [
                    Ingredient(ItemID.FragmentVortex, 18), Ingredient(ItemID.LunarBar, 14),
                    Ingredient(ItemID.ShroomiteLeggings)
            ], [TileID.LunarCraftingStation]);

            AddRecipe(ItemID.TurtleHelmet, [Ingredient(ItemID.ChlorophyteBar, 16), Ingredient(ItemID.MoltenHelmet)],
                    [TileID.MythrilAnvil]);
            AddRecipe(ItemID.TurtleScaleMail, [
                    Ingredient(ItemID.ChlorophyteBar, 26), Ingredient(ItemID.MoltenBreastplate),
                    Ingredient(ItemID.TortoiseBanner)
            ], [TileID.MythrilAnvil]);
            AddRecipe(ItemID.TurtleLeggings, [Ingredient(ItemID.ChlorophyteBar, 20), Ingredient(ItemID.MoltenGreaves)],
                    [TileID.MythrilAnvil]);

            AddRecipe(ItemID.SpiderMask,
                    [Ingredient(ItemID.SpiderFang, 20), Ingredient(ItemID.BeeHeadgear), Ingredient(ItemID.Cobweb, 250)],
                    [TileID.MythrilAnvil]);
            AddRecipe(ItemID.SpiderBreastplate, [
                    Ingredient(ItemID.SpiderFang, 14), Ingredient(ItemID.BeeBreastplate),
                    Ingredient(ItemID.BlackRecluseBanner), Ingredient(ItemID.Cobweb, 500)
            ], [TileID.MythrilAnvil]);
            AddRecipe(ItemID.SpiderGreaves,
                    [Ingredient(ItemID.SpiderFang, 16), Ingredient(ItemID.BeeGreaves), Ingredient(ItemID.Cobweb, 375)],
                    [TileID.MythrilAnvil]);

            AddRecipe(ItemID.SolarFlareHelmet, [
                    Ingredient(ItemID.FragmentSolar, 12), Ingredient(ItemID.LunarBar, 10),
                    Ingredient(ItemID.BeetleHelmet)
            ], [TileID.LunarCraftingStation]);
            AddRecipe(ItemID.SolarFlareBreastplate,
                    [Ingredient(ItemID.FragmentSolar, 24), Ingredient(ItemID.LunarBar, 20)],
                    recipeGroups: [RecipeGroup("BeetleScaleMail")], tiles: [TileID.LunarCraftingStation]);
            AddRecipe(ItemID.SolarFlareLeggings, [
                    Ingredient(ItemID.FragmentSolar, 18), Ingredient(ItemID.LunarBar, 14),
                    Ingredient(ItemID.BeetleLeggings)
            ], [TileID.LunarCraftingStation]);

            AddRecipe(ItemID.NebulaHelmet, [Ingredient(ItemID.FragmentNebula, 12), Ingredient(ItemID.LunarBar, 10)],
                    recipeGroups: [RecipeGroup("SpectreMask")], tiles: [TileID.LunarCraftingStation]);
            AddRecipe(ItemID.NebulaBreastplate, [
                    Ingredient(ItemID.FragmentNebula, 24), Ingredient(ItemID.LunarBar, 20),
                    Ingredient(ItemID.SpectreRobe)
            ], [TileID.LunarCraftingStation]);
            AddRecipe(ItemID.NebulaLeggings, [
                    Ingredient(ItemID.FragmentNebula, 18), Ingredient(ItemID.LunarBar, 14),
                    Ingredient(ItemID.SpectrePants)
            ], [TileID.LunarCraftingStation]);

            AddRecipe(ItemID.StardustHelmet, [
                    Ingredient(ItemID.FragmentStardust, 12), Ingredient(ItemID.LunarBar, 10),
                    Ingredient(ItemID.TikiMask), Ingredient(ItemID.SpookyHelmet)
            ], [TileID.LunarCraftingStation]);
            AddRecipe(ItemID.StardustBreastplate, [
                    Ingredient(ItemID.FragmentStardust, 24), Ingredient(ItemID.LunarBar, 20),
                    Ingredient(ItemID.TikiShirt), Ingredient(ItemID.SpookyBreastplate)
            ], [TileID.LunarCraftingStation]);
            AddRecipe(ItemID.StardustLeggings, [
                    Ingredient(ItemID.FragmentStardust, 18), Ingredient(ItemID.LunarBar, 14),
                    Ingredient(ItemID.TikiPants), Ingredient(ItemID.SpookyLeggings)
            ], [TileID.LunarCraftingStation]);

            AddRecipe(ItemID.Robe,
                    [Ingredient(ItemID.Silk, 25), Ingredient(ItemID.BlueDye, 2), Ingredient(ItemID.RedDye)],
                    [TileID.Loom]);

            AddRecipe(ItemID.AmethystRobe, [Ingredient(ItemID.Robe), Ingredient(ItemID.Amethyst, 15)], [TileID.Loom]);
            AddRecipe(ItemID.TopazRobe, [Ingredient(ItemID.AmethystRobe), Ingredient(ItemID.Topaz, 15)], [TileID.Loom]);
            AddRecipe(ItemID.SapphireRobe, [Ingredient(ItemID.TopazRobe), Ingredient(ItemID.Sapphire, 15)],
                    [TileID.Loom]);
            AddRecipe(ItemID.EmeraldRobe, [Ingredient(ItemID.SapphireRobe), Ingredient(ItemID.Emerald, 15)],
                    [TileID.Loom]);
            AddRecipe(ItemID.RubyRobe, [Ingredient(ItemID.EmeraldRobe), Ingredient(ItemID.Ruby, 15)], [TileID.Loom]);
            AddRecipe(ItemID.AmberRobe, [Ingredient(ItemID.RubyRobe), Ingredient(ItemID.Amber, 15)], [TileID.Loom]);
            AddRecipe(ItemID.DiamondRobe, [Ingredient(ItemID.AmberRobe), Ingredient(ItemID.Diamond, 15)],
                    [TileID.Loom]);

            AddRecipe(ItemID.FlamingArrow, [Ingredient(ItemID.WoodenArrow, 10), Ingredient(ItemID.Torch)],
                    [TileID.Campfire], amount: 10);

            AddRecipe(ItemID.FrostburnArrow, [Ingredient(ItemID.WoodenArrow, 10), Ingredient(ItemID.IceTorch)],
                    [TileID.IceMachine], amount: 10);

            AddRecipe(ItemID.JestersArrow, [Ingredient(ItemID.WoodenArrow, 10), Ingredient(ItemID.FallenStar)],
                    [TileID.SkyMill], amount: 10);

            AddRecipe(ItemID.HellfireArrow, [Ingredient(ItemID.FlamingArrow, 50), Ingredient(ItemID.HellstoneBar)],
                    [TileID.Hellforge], amount: 50);

            AddRecipe(ItemID.UnholyArrow, [Ingredient(ItemID.WoodenArrow, 10), Ingredient(ItemID.VilePowder, 5)],
                    [TileID.DemonAltar], amount: 10);

            AddRecipe(ItemID.UnholyArrow, [Ingredient(ItemID.WoodenArrow, 10), Ingredient(ItemID.ViciousPowder, 5)],
                    [TileID.DemonAltar], amount: 10);

            AddRecipe(ItemID.CursedArrow, [Ingredient(ItemID.UnholyArrow, 50), Ingredient(ItemID.CursedFlame, 3)],
                    [TileID.DemonAltar], amount: 50);

            AddRecipe(ItemID.HolyArrow, [
                    Ingredient(ItemID.JestersArrow, 75), Ingredient(ItemID.UnicornHorn),
                    Ingredient(ItemID.PixieDust, 4), Ingredient(ItemID.Feather, 2)
            ], [TileID.MythrilAnvil], amount: 75);

            AddRecipe(ItemID.ChlorophyteArrow, [Ingredient(ItemID.WoodenArrow, 100), Ingredient(ItemID.ChlorophyteBar)],
                    [TileID.MythrilAnvil], amount: 100);

            AddRecipe(ItemID.MoonlordArrow, [Ingredient(ItemID.ChlorophyteArrow, 150), Ingredient(ItemID.LunarBar)],
                    [TileID.LunarCraftingStation], amount: 150);

            AddRecipe(ItemID.VenomArrow, [Ingredient(ItemID.ChlorophyteArrow, 25), Ingredient(ItemID.VialofVenom)],
                    [TileID.BewitchingTable], amount: 25);

            AddRecipe(ItemID.IchorArrow, [Ingredient(ItemID.UnholyArrow, 50), Ingredient(ItemID.Ichor, 3)],
                    [TileID.DemonAltar], amount: 50);

            AddRecipe(ItemID.SilverBullet, [Ingredient(ItemID.MusketBall, 50), Ingredient(ItemID.SilverBar)],
                    [TileID.Anvils], amount: 50);

            AddRecipe(ItemID.TungstenBullet, [Ingredient(ItemID.MusketBall, 50), Ingredient(ItemID.TungstenBar)],
                    [TileID.Anvils], amount: 50);

            AddRecipe(ItemID.CrystalBullet, [Ingredient(ItemID.MusketBall, 50), Ingredient(ItemID.CrystalShard, 2)],
                    [TileID.MythrilAnvil], amount: 50);

            AddRecipe(ItemID.CursedBullet, [Ingredient(ItemID.MusketBall, 80), Ingredient(ItemID.CursedFlame, 3)],
                    [TileID.MythrilAnvil], amount: 80);

            AddRecipe(ItemID.IchorBullet, [Ingredient(ItemID.MusketBall, 80), Ingredient(ItemID.Ichor, 3)],
                    [TileID.MythrilAnvil], amount: 80);

            AddRecipe(ItemID.ChlorophyteBullet,
                    [Ingredient(ItemID.CrystalBullet, 50), Ingredient(ItemID.ChlorophyteBar)], [TileID.MythrilAnvil],
                    amount: 50);

            AddRecipe(ItemID.MoonlordBullet, [Ingredient(ItemID.ChlorophyteBullet, 150), Ingredient(ItemID.LunarBar)],
                    [TileID.LunarCraftingStation], amount: 150);

            AddRecipe(ItemID.EndlessQuiver, [
                    Ingredient(ItemID.WoodenArrow, 9999), Ingredient(ItemID.MagicQuiver),
                    Ingredient(ItemID.SoulofSight, 5)
            ], [TileID.CrystalBall]);

            AddRecipe(ItemID.EndlessMusketPouch,
                    [Ingredient(ItemID.MusketBall, 9999), Ingredient(ItemID.SoulofSight, 5)], [TileID.CrystalBall]);
        }
    }
}
