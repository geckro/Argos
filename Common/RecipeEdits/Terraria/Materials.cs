using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Argos.Common.RecipeEdits.Terraria;

public class Materials : GlobalItem
{
    public override void AddRecipes()
    {
        RecipeHelper.AddRecipe(ItemID.LunarBar,
                [(ItemID.LunarOre, 5), (ItemID.ChlorophyteBar, 1), (ItemID.SpectreBar, 1), (ItemID.ShroomiteBar, 1)],
                [TileID.LunarCraftingStation]);

        RecipeHelper.AddRecipe(ItemID.Bottle, [(ItemID.Glass, 1)], [TileID.Furnaces, TileID.Anvils]);
        RecipeHelper.AddRecipe(ItemID.Chain, [], [TileID.Anvils], recipeGroups:[("IronBar", 1)], amount: 3);
        RecipeHelper.AddRecipe(ItemID.Leather, [(ItemID.RottenChunk, 6)], [TileID.Furnaces], [Condition.NearWater]);
        RecipeHelper.AddRecipe(ItemID.Leather, [(ItemID.Vertebrae, 6)], [TileID.Furnaces], [Condition.NearWater]);
        RecipeHelper.AddRecipe(ItemID.Silk, [(ItemID.Cobweb, 8)], [TileID.Loom], [Condition.NearWater]);
        RecipeHelper.AddRecipe(ItemID.EnchantedNightcrawler, [(ItemID.Worm, 1), (ItemID.FallenStar, 1)], conditions: [Condition.LanternNight]);
        RecipeHelper.AddRecipe(ItemID.DemoniteBar, [(ItemID.DemoniteOre, 4), (ItemID.Ebonwood, 2)], [TileID.Furnaces]);
        RecipeHelper.AddRecipe(ItemID.CrimtaneBar, [(ItemID.CrimtaneOre, 4), (ItemID.Shadewood, 2)], [TileID.Furnaces]);
        RecipeHelper.AddRecipe(ItemID.CobaltBar, [(ItemID.CobaltOre, 4)], [TileID.Hellforge]);
        RecipeHelper.AddRecipe(ItemID.PalladiumBar, [(ItemID.PalladiumOre, 4)], [TileID.Hellforge]);
        RecipeHelper.AddRecipe(ItemID.SpectreBar, [(ItemID.ChlorophyteBar, 1), (ItemID.Ectoplasm, 1), (ItemID.Bone, 5)], [TileID.CrystalBall]);
        RecipeHelper.AddRecipe(ItemID.HellstoneBar,
                [(ItemID.Hellstone, 4), (ItemID.Obsidian, 1), (ItemID.AshBlock, 10)], [TileID.Hellforge]);
    }
}
