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

        RecipeHelper.AddRecipe(ItemID.LightsBane,
                [(ItemID.DemoniteBar, 14), (ItemID.RottenChunk, 4), (ItemID.VilePowder, 6)], [TileID.Anvils],
                recipeGroups: [("GoldBroadsword", 1)]);

        RecipeHelper.AddRecipe(ItemID.BloodButcherer,
                [(ItemID.CrimtaneBar, 14), (ItemID.Vertebrae, 4), (ItemID.ViciousPowder, 6)], [TileID.Anvils],
                recipeGroups: [("GoldBroadsword", 1)]);

        RecipeHelper.AddRecipe(ItemID.BladeofGrass,
                [(ItemID.Stinger, 16), (ItemID.JungleSpores, 15), (ItemID.Vine, 4), (ItemID.RichMahoganySword, 1)],
                [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.NightsEdge,
        [
                (ItemID.LightsBane, 1), (ItemID.Muramasa, 1), (ItemID.BladeofGrass, 1), (ItemID.FieryGreatsword, 1),
                (ItemID.AntlionClaw, 1)
        ], [TileID.DemonAltar]);

        RecipeHelper.AddRecipe(ItemID.NightsEdge,
        [
                (ItemID.BloodButcherer, 1), (ItemID.Muramasa, 1), (ItemID.BladeofGrass, 1), (ItemID.FieryGreatsword, 1),
                (ItemID.AntlionClaw, 1)
        ], [TileID.DemonAltar]);

        RecipeHelper.AddRecipe(ItemID.Excalibur,
                [(ItemID.EnchantedSword, 1), (ItemID.HallowedBar, 12), (ItemID.SoulofLight, 6)], [TileID.MythrilAnvil]);

        RecipeHelper.AddRecipe(ItemID.TrueExcalibur,
        [
                (ItemID.Excalibur, 1), (ItemID.ChlorophyteBar, 30), (ItemID.PixieBanner, 1),
                (ItemID.AngryTrapperBanner, 1), (ItemID.FungiBulbBanner, 1)
        ], [TileID.MythrilAnvil]);

        RecipeHelper.AddRecipe(ItemID.TrueNightsEdge,
        [
                (ItemID.NightsEdge, 1), (ItemID.SoulofFright, 25), (ItemID.CorruptorBanner, 1),
                (ItemID.CursedSkullBanner, 1), (ItemID.LavaBatBanner, 1)
        ], [TileID.MythrilAnvil]);

        RecipeHelper.AddRecipe(ItemID.TrueNightsEdge,
        [
                (ItemID.NightsEdge, 1), (ItemID.SoulofFright, 25), (ItemID.IchorStickerBanner, 1),
                (ItemID.CursedSkullBanner, 1), (ItemID.LavaBatBanner, 1)
        ], [TileID.MythrilAnvil]);

        RecipeHelper.AddRecipe(ItemID.TerraBlade,
        [
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
    }
}

public class Bows : GlobalItem
{
    public override void AddRecipes()
    {
        RecipeHelper.AddRecipe(ItemID.WoodenBow, [(ItemID.Wood, 12), (ItemID.Cobweb, 20)], [TileID.WorkBenches]);

        RecipeHelper.AddRecipe(ItemID.MoltenFury, [(ItemID.HellstoneBar, 16), (ItemID.FlamingArrow, 500)],
                recipeGroups: [("DemonBow", 1)], tiles: [TileID.Hellforge],
                conditions: [Condition.InUnderworld, Condition.NearLava]);
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
                [(ItemID.DarkLance, 1), (ItemID.HallowedBar, 14), (ItemID.SoulofLight, 8), (ItemID.PixieDust, 12)],
                [TileID.MythrilAnvil]);
    }
}