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
        RecipeHelper.AddRecipe(ItemID.DemoniteBar, [(ItemID.DemoniteOre, 4), (ItemID.Ebonwood, 2)], [TileID.Furnaces]);
        RecipeHelper.AddRecipe(ItemID.CrimtaneBar, [(ItemID.CrimtaneOre, 4), (ItemID.Shadewood, 2)], [TileID.Furnaces]);
        RecipeHelper.AddRecipe(ItemID.HellstoneBar,
                [(ItemID.Hellstone, 4), (ItemID.Obsidian, 1), (ItemID.AshBlock, 10)], [TileID.Hellforge]);
    }
}
