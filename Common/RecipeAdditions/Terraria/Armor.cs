using Argos.Content.Parts.Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Argos.Common.RecipeAdditions.Terraria;

public class ArmorAdditions : GlobalItem
{
    public override void AddRecipes()
    {
        RecipeHelper.AddRecipe(ItemID.MiningHelmet, [(ItemID.Torch, 100)], [TileID.Anvils], recipeGroups: [("GoldBar", 20)], moddedIngredients: [(ModContent.ItemType<ArmorMiningHead>(), 1)]);
        RecipeHelper.AddRecipe(ItemID.MiningShirt, [(ItemID.MiningPotion, 3), (ItemID.Silk, 20)], [TileID.Anvils], moddedIngredients: [(ModContent.ItemType<ArmorMiningChest>(), 1)]);
        RecipeHelper.AddRecipe(ItemID.MiningPants, [(ItemID.MiningPotion, 3), (ItemID.Silk, 15)], [TileID.Anvils], moddedIngredients: [(ModContent.ItemType<ArmorMiningLegs>(), 1)]);

        RecipeHelper.AddRecipe(ItemID.GladiatorHelmet, [(ItemID.Marble, 100), (ItemID.Chain, 25)], moddedIngredients: [(ModContent.ItemType<ArmorGladiatorHead>(), 1)]);
        RecipeHelper.AddRecipe(ItemID.GladiatorBreastplate, [(ItemID.Marble, 180), (ItemID.Chain, 30)], [TileID.Anvils], moddedIngredients: [(ModContent.ItemType<ArmorGladiatorChest>(), 1)]);
        RecipeHelper.AddRecipe(ItemID.GladiatorLeggings, [(ItemID.Marble, 135), (ItemID.Chain, 25)], [TileID.Anvils], moddedIngredients: [(ModContent.ItemType<ArmorGladiatorLegs>(), 1)]);

        RecipeHelper.AddRecipe(ItemID.RainHat, [(ItemID.BottledWater, 50), (ItemID.YellowDye, 2)], [TileID.WorkBenches], moddedIngredients: [(ModContent.ItemType<ArmorRainHead>(), 1)]);
        RecipeHelper.AddRecipe(ItemID.RainCoat, [(ItemID.BottledWater, 50), (ItemID.YellowDye, 2)], [TileID.WorkBenches], moddedIngredients: [(ModContent.ItemType<ArmorRainChest>(), 1)]);

        RecipeHelper.AddRecipe(ItemID.AnglerHat, [(ItemID.Bass, 25), (ItemID.Shrimp, 10)], [TileID.Anvils], moddedIngredients: [(ModContent.ItemType<ArmorAnglerHead>(), 1)]);
        RecipeHelper.AddRecipe(ItemID.AnglerVest, [(ItemID.AtlanticCod, 20), (ItemID.RockLobster, 15), (ItemID.GoldenCarp, 1)], [TileID.Anvils], moddedIngredients: [(ModContent.ItemType<ArmorAnglerChest>(), 1)]);
        RecipeHelper.AddRecipe(ItemID.AnglerPants, [(ItemID.NeonTetra, 20), (ItemID.Trout, 30), (ItemID.Salmon, 10)], [TileID.Anvils], moddedIngredients: [(ModContent.ItemType<ArmorAnglerLegs>(), 1)]);
    }
}
