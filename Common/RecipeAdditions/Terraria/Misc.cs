using Argos.Content.Parts.Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Argos.Common.RecipeAdditions.Terraria;

public class Misc : GlobalItem
{
    public override void AddRecipes()
    {
        RecipeHelper.AddRecipe(ItemID.GuideVoodooDoll,
                [(ItemID.ClothierVoodooDoll, 1), (ItemID.Silk, 25), (ItemID.HellstoneBar, 12)],
                moddedIngredients: [(ModContent.ItemType<BossSummonGuideVoodooDoll>(), 3)], tiles: [TileID.DemonAltar]);

        RecipeHelper.AddRecipe(ItemID.ClothierVoodooDoll, [
                        (ItemID.Silk, 25), (ItemID.FamiliarWig, 1), (ItemID.FamiliarShirt, 1),
                        (ItemID.FamiliarPants, 1), (ItemID.Bone, 50)
                ], moddedIngredients: [(ModContent.ItemType<BossSummonClothierVoodooDoll>(), 2)],
                tiles: [TileID.DemonAltar, TileID.BoneWelder]);
    }
}