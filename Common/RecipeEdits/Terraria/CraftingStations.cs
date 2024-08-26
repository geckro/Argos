using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Argos.Common.RecipeEdits.Terraria;

public class CraftingStations : GlobalItem
{
    public override void AddRecipes()
    {
        RecipeHelper.AddRecipe(ItemID.WorkBench,
                [(ItemID.Wood, 25), (ItemID.WoodPlatform, 8), (ItemID.Cobweb, 12)]);

        RecipeHelper.AddRecipe(ItemID.Furnace,
                [(ItemID.StoneBlock, 25), (ItemID.ClayBlock, 16), (ItemID.Torch, 4)],
                recipeGroups: [("CopperOre", 8), ("IronOre", 6), ("Wood", 8)], tiles: [TileID.WorkBenches]);

        RecipeHelper.AddRecipe(ItemID.IronAnvil, [(ItemID.IronBar, 12)], recipeGroups: [("CopperBar", 4)],
                tiles: [TileID.Furnaces, TileID.WorkBenches]);

        RecipeHelper.AddRecipe(ItemID.LeadAnvil, [(ItemID.LeadBar, 12)], recipeGroups: [("CopperBar", 4)],
                tiles: [TileID.Furnaces, TileID.WorkBenches]);

        RecipeHelper.AddRecipe(ItemID.Sawmill,
                [(ItemID.WorkBench, 1), (ItemID.Wood, 24), (ItemID.Chain, 4)],
                recipeGroups: [("IronBar", 6), ("CopperBar", 4)], tiles: [TileID.WorkBenches, TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.Loom,
                [(ItemID.Cobweb, 32), (ItemID.Wood, 42), (ItemID.RedDye, 2), (ItemID.BlueDye, 1), (ItemID.PinkDye, 1)],
                recipeGroups: [("IronBar", 6)], tiles: [TileID.Sawmill, TileID.DyeVat]);

        RecipeHelper.AddRecipe(ItemID.Keg, [
                (ItemID.Barrel, 1), (ItemID.Wood, 6), (ItemID.Daybloom, 8), (ItemID.Blinkroot, 6),
                (ItemID.WaterBucket, 2)
        ], recipeGroups: [("IronBar", 4)], tiles: [TileID.Sawmill]);

        RecipeHelper.AddRecipe(ItemID.CookingPot,
                [(ItemID.Campfire, 1), (ItemID.Wood, 8), (ItemID.Fireblossom, 4)],
                recipeGroups: [("IronBar", 14)], tiles: [TileID.HeavyWorkBench]);

        RecipeHelper.AddRecipe(ItemID.HeavyWorkBench,
                [(ItemID.WorkBench, 1), (ItemID.Chain, 6), (ItemID.Ruby, 3)],
                recipeGroups: [("IronBar", 16), ("IronHammer", 1)], tiles: [TileID.Anvils, TileID.WorkBenches]);

        RecipeHelper.AddRecipe(ItemID.GlassKiln,
                [(ItemID.Furnace, 1), (ItemID.Glass, 30), (ItemID.Fireblossom, 4)],
                recipeGroups: [("SilverBar", 12)], tiles: [TileID.HeavyWorkBench], conditions: [Condition.NearLava]);
    }
}