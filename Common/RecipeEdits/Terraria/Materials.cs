using Terraria.ID;
using Terraria.ModLoader;

namespace Argos.Common.RecipeEdits.Terraria;

public class Materials : GlobalItem
{
    public override void AddRecipes()
    {
        RecipeHelper.AddRecipe(ItemID.LunarBar, [(ItemID.LunarOre, 5), (ItemID.ChlorophyteBar, 1), (ItemID.SpectreBar, 1), (ItemID.ShroomiteBar, 1)],
                [TileID.LunarCraftingStation]);
    }
}
