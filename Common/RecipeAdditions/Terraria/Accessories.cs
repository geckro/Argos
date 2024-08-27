using Argos.Content.Parts.Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Argos.Common.RecipeAdditions.Terraria;

public class AccessoriesAdditions : GlobalItem
{
    public override void AddRecipes()
    {
        RecipeHelper.AddRecipe(ItemID.IceSkates,
                [(ItemID.IceBlock, 400), (ItemID.SnowBlock, 150), (ItemID.FlinxFur, 8), (ItemID.Silk, 16)],
                moddedIngredients: [(ModContent.ItemType<AccIceSkates>(), 1)], recipeGroups: [("SilverBar", 6)],
                tiles: [TileID.IceMachine]);
    }
}
