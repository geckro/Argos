using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Argos.Common.RecipeEdits.Terraria;

public class Swords : GlobalItem
{
    public override void AddRecipes()
    {
        RecipeHelper.AddRecipe(ItemID.FieryGreatsword,
                [(ItemID.HellstoneBar, 20), (ItemID.AshBlock, 250), (ItemID.AshWood, 20)], [TileID.Hellforge],
                [Condition.InUnderworld, Condition.NearLava]);

        RecipeHelper.AddRecipe(ItemID.WoodenSword, [(ItemID.Wood, 12), (ItemID.StoneBlock, 6), (ItemID.WebRope, 4)],
                [TileID.WorkBenches]);

        RecipeHelper.AddRecipe(ItemID.BorealWoodSword, [(ItemID.BorealWood, 12), (ItemID.SnowBlock, 6), (ItemID.WebRope, 4)],
                [TileID.WorkBenches]);

        RecipeHelper.AddRecipe(ItemID.AshWoodSword, [(ItemID.AshWood, 12), (ItemID.AshBlock, 24), (ItemID.WebRope, 4)],
                [TileID.Hellforge]);

        RecipeHelper.AddRecipe(ItemID.RichMahoganySword, [(ItemID.RichMahogany, 12), (ItemID.MudBlock, 6), (ItemID.WebRope, 4)],
                [TileID.WorkBenches]);

        RecipeHelper.AddRecipe(ItemID.PalmWoodSword, [(ItemID.PalmWood, 12), (ItemID.SandBlock, 6), (ItemID.WebRope, 4)],
                [TileID.WorkBenches]);

        RecipeHelper.AddRecipe(ItemID.EbonwoodSword, [(ItemID.Ebonwood, 12), (ItemID.VilePowder, 2), (ItemID.WebRope, 4)],
                [TileID.WorkBenches]);

        RecipeHelper.AddRecipe(ItemID.ShadewoodSword, [(ItemID.Shadewood, 12), (ItemID.VilePowder, 6), (ItemID.WebRope, 4)],
                [TileID.WorkBenches]);

        RecipeHelper.AddRecipe(ItemID.PearlwoodSword, [(ItemID.Pearlwood, 12), (ItemID.PearlstoneBlock, 6), (ItemID.WebRope, 4)],
                [TileID.WorkBenches]);

        RecipeHelper.AddRecipe(ItemID.CactusSword,
                [(ItemID.Cactus, 16), (ItemID.Waterleaf, 2), (ItemID.WoodenSword, 1)], [TileID.WorkBenches]);

        RecipeHelper.AddRecipe(ItemID.CopperBroadsword, [(ItemID.CopperBar, 10), (ItemID.WoodenSword, 1)],
                [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.TinBroadsword, [(ItemID.TinBar, 10), (ItemID.WoodenSword, 1)], [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.IronBroadsword, [(ItemID.IronBar, 10)], [TileID.Anvils],
                recipeGroups: [("CopperBroadsword", 1)]);

        RecipeHelper.AddRecipe(ItemID.LeadBroadsword, [(ItemID.LeadBar, 10)], [TileID.Anvils],
                recipeGroups: [("CopperBroadsword", 1)]);

        RecipeHelper.AddRecipe(ItemID.SilverBroadsword, [(ItemID.GoldBar, 10), (ItemID.Sapphire, 1)], [TileID.Anvils],
                recipeGroups: [("IronBroadsword", 1)]);

        RecipeHelper.AddRecipe(ItemID.TungstenBroadsword, [(ItemID.PlatinumBar, 10), (ItemID.Sapphire, 1)],
                [TileID.Anvils], recipeGroups: [("IronBroadsword", 1)]);

        RecipeHelper.AddRecipe(ItemID.GoldBroadsword, [(ItemID.GoldBar, 10), (ItemID.Ruby, 1)], [TileID.Anvils],
                recipeGroups: [("SilverBroadsword", 1)]);

        RecipeHelper.AddRecipe(ItemID.PlatinumBroadsword, [(ItemID.PlatinumBar, 10), (ItemID.Ruby, 1)], [TileID.Anvils],
                recipeGroups: [("SilverBroadsword", 1)]);

        RecipeHelper.AddRecipe(ItemID.CopperShortsword, [(ItemID.CopperBar, 8), (ItemID.WoodenSword, 1)],
                [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.TinShortsword, [(ItemID.TinBar, 8), (ItemID.WoodenSword, 1)], [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.IronShortsword, [(ItemID.IronBar, 8)], [TileID.Anvils],
                recipeGroups: [("CopperShortsword", 1)]);

        RecipeHelper.AddRecipe(ItemID.LeadShortsword, [(ItemID.LeadBar, 8)], [TileID.Anvils],
                recipeGroups: [("CopperShortsword", 1)]);

        RecipeHelper.AddRecipe(ItemID.SilverShortsword, [(ItemID.GoldBar, 8), (ItemID.Sapphire, 1)], [TileID.Anvils],
                recipeGroups: [("IronShortsword", 1)]);

        RecipeHelper.AddRecipe(ItemID.TungstenShortsword, [(ItemID.PlatinumBar, 8), (ItemID.Sapphire, 1)],
                [TileID.Anvils], recipeGroups: [("IronShortsword", 1)]);

        RecipeHelper.AddRecipe(ItemID.GoldShortsword, [(ItemID.GoldBar, 8), (ItemID.Ruby, 1)], [TileID.Anvils],
                recipeGroups: [("SilverShortsword", 1)]);

        RecipeHelper.AddRecipe(ItemID.PlatinumShortsword, [(ItemID.PlatinumBar, 8), (ItemID.Ruby, 1)], [TileID.Anvils],
                recipeGroups: [("SilverShortsword", 1)]);

        RecipeHelper.AddRecipe(ItemID.LightsBane,
                [(ItemID.DemoniteBar, 14), (ItemID.RottenChunk, 4), (ItemID.VilePowder, 6)], [TileID.Anvils],
                recipeGroups: [("GoldBroadsword", 1)]);

        RecipeHelper.AddRecipe(ItemID.BloodButcherer,
                [(ItemID.CrimtaneBar, 14), (ItemID.Vertebrae, 4), (ItemID.ViciousPowder, 6)], [TileID.Anvils],
                recipeGroups: [("GoldBroadsword", 1)]);

        RecipeHelper.AddRecipe(ItemID.BladeofGrass,
                [(ItemID.Stinger, 16), (ItemID.JungleSpores, 15), (ItemID.Vine, 4), (ItemID.RichMahoganySword, 1)],
                [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.NightsEdge, [
                (ItemID.LightsBane, 1), (ItemID.Muramasa, 1), (ItemID.BladeofGrass, 1), (ItemID.FieryGreatsword, 1),
                (ItemID.AntlionClaw, 1)
        ], [TileID.DemonAltar]);

        RecipeHelper.AddRecipe(ItemID.NightsEdge, [
                (ItemID.BloodButcherer, 1), (ItemID.Muramasa, 1), (ItemID.BladeofGrass, 1), (ItemID.FieryGreatsword, 1),
                (ItemID.AntlionClaw, 1)
        ], [TileID.DemonAltar]);

        RecipeHelper.AddRecipe(ItemID.CobaltSword, [(ItemID.CobaltBar, 14), (ItemID.BoneSword, 1)], [TileID.HeavyWorkBench]);

        RecipeHelper.AddRecipe(ItemID.PalladiumSword, [(ItemID.PalladiumBar, 14), (ItemID.BoneSword, 1)], [TileID.HeavyWorkBench]);

        RecipeHelper.AddRecipe(ItemID.MythrilSword, [(ItemID.MythrilBar, 14)], [TileID.MythrilAnvil], recipeGroups: [("CobaltSword", 1)]);

        RecipeHelper.AddRecipe(ItemID.OrichalcumSword, [(ItemID.OrichalcumBar, 14)], [TileID.MythrilAnvil], recipeGroups: [("CobaltSword", 1)]);

        RecipeHelper.AddRecipe(ItemID.AdamantiteSword, [(ItemID.AdamantiteBar, 14)], [TileID.MythrilAnvil], recipeGroups: [("MythrilSword", 1)]);

        RecipeHelper.AddRecipe(ItemID.TitaniumSword, [(ItemID.TitaniumBar, 14)], [TileID.MythrilAnvil], recipeGroups: [("MythrilSword", 1)]);

        RecipeHelper.AddRecipe(ItemID.Excalibur,
                [(ItemID.EnchantedSword, 1), (ItemID.HallowedBar, 12), (ItemID.SoulofLight, 6)], [TileID.MythrilAnvil]);

        RecipeHelper.AddRecipe(ItemID.TrueExcalibur, [
                (ItemID.Excalibur, 1), (ItemID.ChlorophyteBar, 30), (ItemID.PixieBanner, 1),
                (ItemID.AngryTrapperBanner, 1), (ItemID.FungiBulbBanner, 1)
        ], [TileID.MythrilAnvil]);

        RecipeHelper.AddRecipe(ItemID.TrueNightsEdge, [
                (ItemID.NightsEdge, 1), (ItemID.SoulofFright, 25), (ItemID.CorruptorBanner, 1),
                (ItemID.CursedSkullBanner, 1), (ItemID.LavaBatBanner, 1)
        ], [TileID.MythrilAnvil]);

        RecipeHelper.AddRecipe(ItemID.TrueNightsEdge, [
                (ItemID.NightsEdge, 1), (ItemID.SoulofFright, 25), (ItemID.IchorStickerBanner, 1),
                (ItemID.CursedSkullBanner, 1), (ItemID.LavaBatBanner, 1)
        ], [TileID.MythrilAnvil]);

        RecipeHelper.AddRecipe(ItemID.TerraBlade, [
                (ItemID.TrueNightsEdge, 1), (ItemID.TrueExcalibur, 1), (ItemID.BrokenHeroSword, 2),
                (ItemID.Ectoplasm, 10), (ItemID.GrassSeeds, 25), (ItemID.CorruptSeeds, 25), (ItemID.CrimsonSeeds, 25),
                (ItemID.JungleGrassSeeds, 25), (ItemID.MushroomGrassSeeds, 25), (ItemID.AshGrassSeeds, 25),
                (ItemID.HallowedSeeds, 25)
        ], [TileID.Autohammer]);

        RecipeHelper.AddRecipe(ItemID.Zenith, [
                        (ItemID.TerraBlade, 1),
                        (ItemID.Meowmere, 1),
                        (ItemID.StarWrath, 1),
                        (ItemID.InfluxWaver, 1),
                        (ItemID.TheHorsemansBlade, 1),
                        (ItemID.Seedler, 1),
                        (ItemID.BeeKeeper, 1),
                        (ItemID.Terragrim, 1),
                        (ItemID.CopperShortsword, 1),
                        (ItemID.DD2SquireBetsySword, 1),
                        (ItemID.DD2SquireDemonSword, 1),
                        (ItemID.Keybrand, 1),
                        (ItemID.PiercingStarlight, 1),
                        (ItemID.BreakerBlade, 1),
                        (ItemID.ChristmasTreeSword, 1),
                        (ItemID.Frostbrand, 1)
                ], [TileID.LunarCraftingStation, TileID.Toilets],
                [Condition.InAether, Condition.NearHoney, Condition.BirthdayParty]);
    }
}

public class Summon : GlobalItem
{
    public override void AddRecipes()
    {
        RecipeHelper.AddRecipe(ItemID.StardustDragonStaff,
                [(ItemID.FragmentStardust, 20), (ItemID.MartianConduitPlating, 80)], [TileID.LunarCraftingStation]);

        RecipeHelper.AddRecipe(ItemID.StardustCellStaff,
                [(ItemID.FragmentStardust, 20), (ItemID.MartianConduitPlating, 80), (ItemID.DeadlySphereStaff, 1)],
                [TileID.LunarCraftingStation]);

        RecipeHelper.AddRecipe(ItemID.HornetStaff,
                [(ItemID.BeeWax, 16), (ItemID.LivingMahoganyWand, 1), (ItemID.Hive, 250)], [TileID.HoneyDispenser]);

        RecipeHelper.AddRecipe(ItemID.ImpStaff,
                [(ItemID.HellstoneBar, 20), (ItemID.FireImpBanner, 1), (ItemID.Bone, 45)], [TileID.Hellforge],
                [Condition.NearLava]);
    }
}

public class Bows : GlobalItem
{
    public override void AddRecipes()
    {
        RecipeHelper.AddRecipe(ItemID.WoodenBow, [(ItemID.Wood, 12), (ItemID.Cobweb, 20)], [TileID.WorkBenches]);

        RecipeHelper.AddRecipe(ItemID.BorealWoodBow, [(ItemID.BorealWood, 12), (ItemID.Cobweb, 20)],
                [TileID.WorkBenches]);

        RecipeHelper.AddRecipe(ItemID.AshWoodBow, [(ItemID.AshWood, 12), (ItemID.Cobweb, 20)],
                [TileID.Hellforge]);

        RecipeHelper.AddRecipe(ItemID.RichMahoganyBow, [(ItemID.RichMahogany, 12), (ItemID.Cobweb, 20)],
                [TileID.WorkBenches]);

        RecipeHelper.AddRecipe(ItemID.PalmWoodBow, [(ItemID.PalmWood, 12), (ItemID.Cobweb, 20)],
                [TileID.WorkBenches]);

        RecipeHelper.AddRecipe(ItemID.EbonwoodBow, [(ItemID.Ebonwood, 12), (ItemID.Cobweb, 20), (ItemID.EbonstoneBlock, 25)],
                [TileID.WorkBenches]);

        RecipeHelper.AddRecipe(ItemID.ShadewoodBow, [(ItemID.Shadewood, 12), (ItemID.Cobweb, 20), (ItemID.CrimstoneBlock, 25)],
                [TileID.WorkBenches]);

        RecipeHelper.AddRecipe(ItemID.PearlwoodBow, [(ItemID.Pearlwood, 12), (ItemID.Cobweb, 20), (ItemID.PearlstoneBlock, 25)],
                [TileID.WorkBenches]);

        RecipeHelper.AddRecipe(ItemID.CopperBow, [(ItemID.CopperBar, 12), (ItemID.WoodenBow, 1)],
                recipeGroups: [("Wood", 6)], tiles: [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.TinBow, [(ItemID.TinBar, 12), (ItemID.WoodenBow, 1)], recipeGroups: [("Wood", 6)],
                tiles: [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.IronBow, [(ItemID.IronBar, 12)], recipeGroups: [("CopperBow", 1)],
                tiles: [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.LeadBow, [(ItemID.LeadBar, 12)], recipeGroups: [("CopperBow", 1)],
                tiles: [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.SilverBow, [(ItemID.SilverBar, 12), (ItemID.Sapphire, 1)],
                recipeGroups: [("IronBow", 1)], tiles: [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.TungstenBow, [(ItemID.TungstenBar, 12), (ItemID.Sapphire, 1)],
                recipeGroups: [("IronBow", 1)], tiles: [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.GoldBow, [(ItemID.GoldBar, 12), (ItemID.Ruby, 1)],
                recipeGroups: [("SilverBow", 1)], tiles: [TileID.HeavyWorkBench]);

        RecipeHelper.AddRecipe(ItemID.PlatinumBow, [(ItemID.PlatinumBar, 12), (ItemID.Ruby, 1)],
                recipeGroups: [("SilverBow", 1)], tiles: [TileID.HeavyWorkBench]);

        RecipeHelper.AddRecipe(ItemID.DemonBow,
                [(ItemID.DemoniteBar, 12), (ItemID.Ebonwood, 12), (ItemID.VioletDye, 1)],
                recipeGroups: [("GoldBow", 1)], tiles: [TileID.DemonAltar], conditions: [Condition.InCorrupt]);

        RecipeHelper.AddRecipe(ItemID.TendonBow, [(ItemID.CrimtaneBar, 12), (ItemID.Shadewood, 12), (ItemID.RedDye, 1)],
                recipeGroups: [("GoldBow", 1)], tiles: [TileID.DemonAltar], conditions: [Condition.InCrimson]);

        RecipeHelper.AddRecipe(ItemID.MoltenFury, [(ItemID.HellstoneBar, 16), (ItemID.FlamingArrow, 500)],
                recipeGroups: [("DemonBow", 1)], tiles: [TileID.Hellforge],
                conditions: [Condition.InUnderworld, Condition.NearLava]);

        RecipeHelper.AddRecipe(ItemID.CobaltRepeater, [(ItemID.CobaltBar, 14), (ItemID.HellwingBow, 1)], [TileID.HeavyWorkBench]);

        RecipeHelper.AddRecipe(ItemID.PalladiumRepeater, [(ItemID.PalladiumBar, 14), (ItemID.HellwingBow, 1)], [TileID.HeavyWorkBench]);

        RecipeHelper.AddRecipe(ItemID.MythrilRepeater, [(ItemID.MythrilBar, 14)], [TileID.MythrilAnvil], recipeGroups: [("CobaltRepeater", 1)]);

        RecipeHelper.AddRecipe(ItemID.OrichalcumRepeater, [(ItemID.OrichalcumBar, 14)], [TileID.MythrilAnvil], recipeGroups: [("CobaltRepeater", 1)]);

        RecipeHelper.AddRecipe(ItemID.AdamantiteRepeater, [(ItemID.AdamantiteBar, 14)], [TileID.MythrilAnvil], recipeGroups: [("MythrilRepeater", 1)]);

        RecipeHelper.AddRecipe(ItemID.TitaniumRepeater, [(ItemID.TitaniumBar, 14)], [TileID.MythrilAnvil], recipeGroups: [("MythrilRepeater", 1)]);

        RecipeHelper.AddRecipe(ItemID.HallowedRepeater, [(ItemID.HallowedBar, 16), (ItemID.SoulofSight, 3)], [TileID.DemonAltar], recipeGroups: [("AdamantiteRepeater", 1)]);

    }
}

public class Guns : GlobalItem
{
    public override void AddRecipes()
    {
        RecipeHelper.AddRecipe(ItemID.PhoenixBlaster,
                [(ItemID.HellstoneBar, 16), (ItemID.Handgun, 1), (ItemID.HellfireArrow, 200)], [TileID.Hellforge],
                [Condition.NearLava]);

        RecipeHelper.AddRecipe(ItemID.StarCannon,
        [
                (ItemID.Minishark, 1), (ItemID.SpaceGun, 1), (ItemID.PhoenixBlaster, 1), (ItemID.FallenStar, 15),
                (ItemID.HellstoneBar, 20)
        ], [TileID.Hellforge, TileID.SkyMill], [Condition.InSpace]);
    }
}

public class RangedConsumables : GlobalItem
{
    public override void AddRecipes()
    {
        RecipeHelper.AddRecipe(ItemID.Beenade, [(ItemID.BeeWax, 1), (ItemID.Grenade, 1), (ItemID.Hive, 3)],
                [TileID.HoneyDispenser]);
    }
}

public class Boomerangs : GlobalItem
{
    public override void AddRecipes()
    {
        RecipeHelper.AddRecipe(ItemID.EnchantedBoomerang,
                [(ItemID.WoodenBoomerang, 1), (ItemID.FallenStar, 5), (ItemID.Ruby, 3)], [TileID.Anvils],
                [Condition.InSpace]);

        RecipeHelper.AddRecipe(ItemID.Flamarang,
                [(ItemID.HellstoneBar, 15), (ItemID.IceBoomerang, 1), (ItemID.FlaskofFire, 1)], [TileID.Hellforge],
                [Condition.InUnderworld, Condition.NearLava]);
    }
}

public class Spears : GlobalItem
{
    public override void AddRecipes()
    {
        RecipeHelper.AddRecipe(ItemID.Gungnir,
                [(ItemID.HallowedBar, 12), (ItemID.SoulofLight, 8), (ItemID.PixieDust, 12)],
                [TileID.MythrilAnvil], recipeGroups: [("AdamantiteGlaive", 1)]);

        RecipeHelper.AddRecipe(ItemID.CobaltNaginata, [(ItemID.CobaltBar, 12), (ItemID.DarkLance, 1)], [TileID.HeavyWorkBench]);

        RecipeHelper.AddRecipe(ItemID.PalladiumPike, [(ItemID.PalladiumBar, 12), (ItemID.DarkLance, 1)], [TileID.HeavyWorkBench]);

        RecipeHelper.AddRecipe(ItemID.MythrilHalberd, [(ItemID.MythrilBar, 12)], [TileID.MythrilAnvil], recipeGroups: [("CobaltNaginata", 1)]);

        RecipeHelper.AddRecipe(ItemID.OrichalcumHalberd, [(ItemID.OrichalcumBar, 12)], [TileID.MythrilAnvil], recipeGroups: [("CobaltNaginata", 1)]);

        RecipeHelper.AddRecipe(ItemID.AdamantiteGlaive, [(ItemID.AdamantiteBar, 12)], [TileID.MythrilAnvil], recipeGroups: [("MythrilHalberd", 1)]);

        RecipeHelper.AddRecipe(ItemID.TitaniumTrident, [(ItemID.TitaniumBar, 14)], [TileID.MythrilAnvil], recipeGroups: [("MythrilHalberd", 1)]);
    }
}

public class Yoyos : GlobalItem
{
    public override void AddRecipes()
    {
        RecipeHelper.AddRecipe(ItemID.JungleYoyo, [
                (ItemID.JungleSpores, 12), (ItemID.Stinger, 12), (ItemID.Vine, 5), (ItemID.RichMahogany, 24),
                (ItemID.GreenString, 1)
        ], [TileID.LivingLoom]);

        RecipeHelper.AddRecipe(ItemID.HiveFive,
                [(ItemID.BeeWax, 16), (ItemID.JungleYoyo, 1), (ItemID.BottledHoney, 12), (ItemID.YellowString, 1)],
                [TileID.HoneyDispenser]);
    }
}

public class Flails : GlobalItem
{
    public override void AddRecipes()
    {
        RecipeHelper.AddRecipe(ItemID.FlamingMace, [(ItemID.Mace, 1), (ItemID.Torch, 200), (ItemID.LavaBucket, 2)],
                [TileID.Anvils]);
    }
}

public class Magic : GlobalItem
{
    public override void AddRecipes()
    {
        RecipeHelper.AddRecipe(ItemID.AmethystStaff, [(ItemID.CopperBar, 12), (ItemID.Amethyst, 10)], [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.TopazStaff, [(ItemID.TinBar, 12), (ItemID.Topaz, 10)], [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.SapphireStaff,
                [(ItemID.SilverBar, 12), (ItemID.Sapphire, 10), (ItemID.GlowingMushroom, 25)], [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.EmeraldStaff,
                [(ItemID.TungstenBar, 12), (ItemID.Emerald, 10), (ItemID.GlowingMushroom, 25)], [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.RubyStaff, [(ItemID.GoldBar, 12), (ItemID.Ruby, 10), (ItemID.FlinxFur, 5)],
                [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.DiamondStaff,
                [(ItemID.PlatinumBar, 12), (ItemID.Diamond, 10), (ItemID.FlinxFur, 5)], [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.AmberStaff,
                [(ItemID.FossilOre, 20), (ItemID.Amber, 10), (ItemID.AntlionMandible, 6)], [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.SpaceGun,
                [(ItemID.FlintlockPistol, 1), (ItemID.MeteoriteBar, 20), (ItemID.Obsidian, 25)], [TileID.Anvils]);
    }
}
