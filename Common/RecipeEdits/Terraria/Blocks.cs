using Argos.Common;
using Argos.Common.Config;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Argos.Common.RecipeEdits.Terraria;

public class Blocks : GlobalItem
{
    public override void AddRecipes()
    {
        RecipeHelper.AddRecipe(ItemID.WoodenDoor, [(ItemID.Wood, 8), (ItemID.StoneBlock, 3)], [TileID.WorkBenches]);
        RecipeHelper.AddRecipe(ItemID.BorealWoodDoor, [(ItemID.BorealWood, 8), (ItemID.SnowBlock, 3)], [TileID.WorkBenches]);
        RecipeHelper.AddRecipe(ItemID.RichMahoganyDoor, [(ItemID.RichMahogany, 8), (ItemID.MudBlock, 3)], [TileID.WorkBenches]);
        RecipeHelper.AddRecipe(ItemID.PalmWoodDoor, [(ItemID.PalmWood, 8), (ItemID.SandBlock, 3)], [TileID.WorkBenches]);
        RecipeHelper.AddRecipe(ItemID.AshWoodDoor, [(ItemID.AshWood, 8), (ItemID.AshBlock, 3)], [TileID.WorkBenches]);
        RecipeHelper.AddRecipe(ItemID.EbonwoodDoor, [(ItemID.Ebonwood, 8), (ItemID.EbonstoneBlock, 3)], [TileID.WorkBenches]);
        RecipeHelper.AddRecipe(ItemID.ShadewoodDoor, [(ItemID.Shadewood, 8), (ItemID.CrimstoneBlock, 3)], [TileID.WorkBenches]);

        RecipeHelper.AddRecipe(ItemID.WoodenChair, [(ItemID.Wood, 6)], [TileID.WorkBenches]);
        RecipeHelper.AddRecipe(ItemID.BorealWoodChair, [(ItemID.BorealWood, 6)], [TileID.WorkBenches]);
        RecipeHelper.AddRecipe(ItemID.RichMahoganyChair, [(ItemID.RichMahogany, 6)], [TileID.WorkBenches]);
        RecipeHelper.AddRecipe(ItemID.PalmWoodChair, [(ItemID.PalmWood, 6)], [TileID.WorkBenches]);
        RecipeHelper.AddRecipe(ItemID.AshWoodChair, [(ItemID.AshWood, 6)], [TileID.WorkBenches]);
        RecipeHelper.AddRecipe(ItemID.EbonwoodChair, [(ItemID.Ebonwood, 6)], [TileID.WorkBenches]);
        RecipeHelper.AddRecipe(ItemID.ShadewoodChair, [(ItemID.Shadewood, 6)], [TileID.WorkBenches]);

        RecipeHelper.AddRecipe(ItemID.WoodenTable, [(ItemID.WorkBench, 1), (ItemID.Wood, 8)], [TileID.WorkBenches]);
        RecipeHelper.AddRecipe(ItemID.BorealWoodTable, [(ItemID.BorealWoodWorkBench, 1), (ItemID.BorealWood, 8)], [TileID.WorkBenches]);
        RecipeHelper.AddRecipe(ItemID.RichMahoganyTable, [(ItemID.RichMahoganyWorkBench, 1), (ItemID.RichMahogany, 8)], [TileID.WorkBenches]);
        RecipeHelper.AddRecipe(ItemID.PalmWoodTable, [(ItemID.PalmWoodWorkBench, 1), (ItemID.PalmWood, 8)], [TileID.WorkBenches]);
        RecipeHelper.AddRecipe(ItemID.AshWoodTable, [(ItemID.AshWoodWorkbench, 1), (ItemID.AshWood, 8)], [TileID.WorkBenches]);
        RecipeHelper.AddRecipe(ItemID.EbonwoodTable, [(ItemID.EbonwoodWorkBench, 1), (ItemID.Ebonwood, 8)], [TileID.WorkBenches]);
        RecipeHelper.AddRecipe(ItemID.ShadewoodTable, [(ItemID.ShadewoodWorkBench, 1), (ItemID.Shadewood, 8)], [TileID.WorkBenches]);

        RecipeHelper.AddRecipe(ItemID.Dresser, [(ItemID.WoodenTable, 1), (ItemID.Wood, 16), (ItemID.Chest, 1)], [TileID.Sawmill]);
        RecipeHelper.AddRecipe(ItemID.Barrel, [(ItemID.Wood, 6), (ItemID.Chest, 1)], [TileID.Sawmill]);
        RecipeHelper.AddRecipe(ItemID.PicnicTable, [(ItemID.WoodenTable, 1), (ItemID.Wood, 18)], [TileID.Sawmill]);
        RecipeHelper.AddRecipe(ItemID.Bench, [(ItemID.WoodenChair, 1), (ItemID.Wood, 12)], [TileID.Sawmill]);
        RecipeHelper.AddRecipe(ItemID.BanquetTable, [(ItemID.WoodenTable, 1), (ItemID.Wood, 18)], [TileID.Sawmill]);
        RecipeHelper.AddRecipe(ItemID.Bar, [(ItemID.WoodenTable, 1), (ItemID.Wood, 18)], [TileID.Sawmill]);
        RecipeHelper.AddRecipe(ItemID.BarStool, [(ItemID.WoodenChair, 1), (ItemID.Wood, 12)], [TileID.Sawmill]);
        RecipeHelper.AddRecipe(ItemID.Sofa, [(ItemID.WoodenChair, 1), (ItemID.Wood, 12), (ItemID.Silk, 4)], [TileID.Sawmill]);
        RecipeHelper.AddRecipe(ItemID.Chest, [(ItemID.Wood, 12)], [TileID.Sawmill], recipeGroups: [("IronBar", 3)]);
        RecipeHelper.AddRecipe(ItemID.Bed, [(ItemID.Wood, 25), (ItemID.Silk, 8)], [TileID.Sawmill, TileID.Loom]);
        RecipeHelper.AddRecipe(ItemID.Bookcase, [(ItemID.Wood, 30), (ItemID.Book, 12)], [TileID.Sawmill]);
        RecipeHelper.AddRecipe(ItemID.Trapdoor, [(ItemID.Wood, 12)], [TileID.Sawmill, TileID.HeavyWorkBench], recipeGroups: [("IronBar", 4)]);
        RecipeHelper.AddRecipe(ItemID.TallGate, [(ItemID.Wood, 24)], [TileID.Sawmill, TileID.HeavyWorkBench], recipeGroups: [("IronBar", 8)]);

        RecipeHelper.AddRecipe(ItemID.WebRope, [(ItemID.Cobweb, 2)], [TileID.WorkBenches], amount: 2);
        RecipeHelper.AddRecipe(ItemID.SilkRope, [(ItemID.Silk, 1)], [TileID.Loom], amount: 10);
    }
}

public class Torches : GlobalItem
{
    public override void AddRecipes()
    {
        if (ModContent.GetInstance<ArgosConfig>().HellMode)
        {
            RecipeHelper.AddRecipe(ItemID.Torch, [(ItemID.Gel, 1), (ItemID.Wood, 1)], [TileID.WorkBenches]);

        }
        else
        {
            RecipeHelper.AddRecipe(ItemID.Torch, [(ItemID.Gel, 1), (ItemID.Wood, 1)], [TileID.WorkBenches], amount: 2);
        }

        RecipeHelper.AddRecipe(ItemID.TikiTorch, [(ItemID.Torch, 1), (ItemID.Wood, 4), (ItemID.StoneBlock, 2)], [TileID.WorkBenches]);
        RecipeHelper.AddRecipe(ItemID.CursedTorch, [(ItemID.Torch, 10), (ItemID.CursedFlame, 1)], [TileID.CrystalBall],
                amount: 10);
        RecipeHelper.AddRecipe(ItemID.IchorTorch, [(ItemID.Torch, 10), (ItemID.Ichor, 1)], [TileID.CrystalBall],
                amount: 10);
        RecipeHelper.AddRecipe(ItemID.RainbowTorch, [(ItemID.Torch, 5), (ItemID.RainbowBrick, 1)], [TileID.CrystalBall],
                amount: 5);
        RecipeHelper.AddRecipe(ItemID.JungleTorch, [(ItemID.Torch, 5), (ItemID.JungleSpores, 1)], [TileID.LivingLoom],
                amount: 5);
        RecipeHelper.AddRecipe(ItemID.BlueTorch, [(ItemID.Torch, 5), (ItemID.Sapphire, 1)], [TileID.Anvils], amount: 5);
        RecipeHelper.AddRecipe(ItemID.PurpleTorch, [(ItemID.Torch, 5), (ItemID.Amethyst, 1)], [TileID.Anvils],
                amount: 5);
        RecipeHelper.AddRecipe(ItemID.WhiteTorch, [(ItemID.Torch, 5), (ItemID.Diamond, 1)], [TileID.Anvils], amount: 5);
        RecipeHelper.AddRecipe(ItemID.YellowTorch, [(ItemID.Torch, 5), (ItemID.Topaz, 1)], [TileID.Anvils], amount: 5);
        RecipeHelper.AddRecipe(ItemID.OrangeTorch, [(ItemID.Torch, 5), (ItemID.Amber, 1)], [TileID.Anvils], amount: 5);
        RecipeHelper.AddRecipe(ItemID.GreenTorch, [(ItemID.Torch, 5), (ItemID.Emerald, 1)], [TileID.Anvils], amount: 5);
        RecipeHelper.AddRecipe(ItemID.IceTorch, [(ItemID.Torch, 1), (ItemID.IceBlock, 1)], [TileID.WorkBenches]);
        RecipeHelper.AddRecipe(ItemID.DesertTorch, [(ItemID.Torch, 1), (ItemID.HardenedSand, 1)], [TileID.WorkBenches]);
        RecipeHelper.AddRecipe(ItemID.CoralTorch, [(ItemID.Torch, 1), (ItemID.Coral, 1)], [TileID.WorkBenches]);
        RecipeHelper.AddRecipe(ItemID.CorruptTorch, [(ItemID.Torch, 1), (ItemID.EbonstoneBlock, 1)], [TileID.Anvils]);
        RecipeHelper.AddRecipe(ItemID.DemonTorch, [(ItemID.Torch, 1), (ItemID.Obsidian, 1)], [TileID.Anvils]);
        RecipeHelper.AddRecipe(ItemID.CrimsonTorch, [(ItemID.Torch, 1), (ItemID.CrimstoneBlock, 1)], [TileID.Anvils]);
        RecipeHelper.AddRecipe(ItemID.PinkTorch, [(ItemID.Torch, 1), (ItemID.PinkGel, 1)], [TileID.Anvils]);
        RecipeHelper.AddRecipe(ItemID.MushroomTorch, [(ItemID.Torch, 1), (ItemID.GlowingMushroom, 1)], [TileID.Anvils]);
        RecipeHelper.AddRecipe(ItemID.HallowedTorch, [(ItemID.Torch, 1), (ItemID.PearlstoneBlock, 1)],
                [TileID.MythrilAnvil]);
    }
}

public class CraftingStations : GlobalItem
{
    public override void AddRecipes()
    {
        RecipeHelper.AddRecipe(ItemID.WorkBench, [(ItemID.Wood, 25), (ItemID.WoodPlatform, 8), (ItemID.Cobweb, 12)]);

        RecipeHelper.AddRecipe(ItemID.LivingWoodWorkBench, [(ItemID.Wood, 25), (ItemID.LivingWoodPlatform, 8), (ItemID.Cobweb, 12)], [TileID.LivingLoom]);

        RecipeHelper.AddRecipe(ItemID.PumpkinWorkBench, [(ItemID.Pumpkin, 25), (ItemID.PumpkinPlatform, 8), (ItemID.Cobweb, 12)], [TileID.LivingLoom]);

        RecipeHelper.AddRecipe(ItemID.BorealWoodWorkBench, [(ItemID.BorealWood, 25), (ItemID.BorealWoodPlatform, 8), (ItemID.Cobweb, 12)]);

        RecipeHelper.AddRecipe(ItemID.RichMahoganyWorkBench, [(ItemID.RichMahogany, 25), (ItemID.RichMahoganyPlatform, 8), (ItemID.Cobweb, 12)]);

        RecipeHelper.AddRecipe(ItemID.PalmWoodWorkBench, [(ItemID.PalmWood, 25), (ItemID.PalmWoodPlatform, 8), (ItemID.Cobweb, 12)]);

        RecipeHelper.AddRecipe(ItemID.EbonwoodWorkBench, [(ItemID.Ebonwood, 25), (ItemID.EbonwoodPlatform, 8), (ItemID.Cobweb, 12)]);

        RecipeHelper.AddRecipe(ItemID.DynastyWorkBench, [(ItemID.DynastyWood, 25), (ItemID.DynastyPlatform, 8), (ItemID.Cobweb, 12)]);

        RecipeHelper.AddRecipe(ItemID.BambooWorkbench, [(ItemID.BambooBlock, 25), (ItemID.BambooPlatform, 8), (ItemID.Cobweb, 12)]);

        RecipeHelper.AddRecipe(ItemID.ShadewoodWorkBench, [(ItemID.Shadewood, 25), (ItemID.ShadewoodPlatform, 8), (ItemID.Cobweb, 12)]);

        RecipeHelper.AddRecipe(ItemID.MushroomWorkBench, [(ItemID.GlowingMushroom, 25), (ItemID.MushroomPlatform, 8), (ItemID.Cobweb, 12)]);

        RecipeHelper.AddRecipe(ItemID.SandstoneWorkbench, [(ItemID.Sandstone, 25), (ItemID.SandstonePlatform, 8), (ItemID.AntlionMandible, 4)], [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.MarbleWorkBench, [(ItemID.MarbleBlock, 25)], [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.GraniteWorkBench, [(ItemID.GraniteBlock, 25)], [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.AshWoodWorkbench, [(ItemID.AshWood, 25), (ItemID.AshWoodPlatform, 8), (ItemID.Cobweb, 12)]);

        RecipeHelper.AddRecipe(ItemID.CactusWorkBench, [(ItemID.Cactus, 25), (ItemID.CactusPlatform, 4), (ItemID.WoodPlatform, 4), (ItemID.Cobweb, 12)]);

        RecipeHelper.AddRecipe(ItemID.Furnace, [(ItemID.StoneBlock, 25), (ItemID.ClayBlock, 16), (ItemID.Torch, 4)],
                recipeGroups: [("CopperOre", 8), ("IronOre", 6), ("Wood", 8)], tiles: [TileID.WorkBenches]);

        RecipeHelper.AddRecipe(ItemID.IronAnvil, [(ItemID.IronBar, 12)], recipeGroups: [("CopperBar", 4)],
                tiles: [TileID.Furnaces, TileID.WorkBenches]);

        RecipeHelper.AddRecipe(ItemID.LeadAnvil, [(ItemID.LeadBar, 12)], recipeGroups: [("CopperBar", 4)],
                tiles: [TileID.Furnaces, TileID.WorkBenches]);

        RecipeHelper.AddRecipe(ItemID.Sawmill, [(ItemID.WorkBench, 1), (ItemID.Wood, 24), (ItemID.Chain, 4)],
                recipeGroups: [("IronBar", 6), ("CopperBar", 4)], tiles: [TileID.WorkBenches, TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.Loom,
                [(ItemID.Cobweb, 32), (ItemID.Wood, 42), (ItemID.RedDye, 2), (ItemID.BlueDye, 1), (ItemID.PinkDye, 1)],
                recipeGroups: [("IronBar", 6)], tiles: [TileID.Sawmill, TileID.DyeVat]);

        RecipeHelper.AddRecipe(ItemID.Keg, [
                (ItemID.Barrel, 1), (ItemID.Wood, 6), (ItemID.Daybloom, 8), (ItemID.Blinkroot, 6),
                (ItemID.WaterBucket, 2)
        ], recipeGroups: [("IronBar", 4)], tiles: [TileID.Sawmill]);

        RecipeHelper.AddRecipe(ItemID.CookingPot, [(ItemID.Campfire, 1), (ItemID.Wood, 8), (ItemID.Fireblossom, 4)],
                recipeGroups: [("IronBar", 14)], tiles: [TileID.HeavyWorkBench]);

        RecipeHelper.AddRecipe(ItemID.HeavyWorkBench, [(ItemID.WorkBench, 1), (ItemID.Chain, 6), (ItemID.Ruby, 3)],
                recipeGroups: [("IronBar", 16), ("IronHammer", 1)], tiles: [TileID.Anvils, TileID.WorkBenches]);

        RecipeHelper.AddRecipe(ItemID.GlassKiln, [(ItemID.Furnace, 1), (ItemID.Glass, 30), (ItemID.Fireblossom, 4)],
                recipeGroups: [("SilverBar", 12)], tiles: [TileID.HeavyWorkBench], conditions: [Condition.NearLava]);
    }
}
