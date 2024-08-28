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

        RecipeHelper.AddRecipe(ItemID.PortableStool, [(ItemID.WoodenChair, 1), (ItemID.Wood, 80), (ItemID.BuilderPotion, 2)], [TileID.WorkBenches], moddedIngredients: [(ModContent.ItemType<SharedChestWooden>(), 1)]);

        RecipeHelper.AddRecipe(ItemID.Radar, [(ItemID.Emerald, 4), (ItemID.Lens, 1)], [TileID.HeavyWorkBench], moddedIngredients: [(ModContent.ItemType<SharedChestWooden>(), 1)], recipeGroups: [("GoldBar", 8), ("CopperBar", 12)]);

        RecipeHelper.AddRecipe(ItemID.HermesBoots, [(ItemID.Silk, 15), (ItemID.SwiftnessPotion, 3), (ItemID.Sunflower, 2), (ItemID.Feather, 4)], [TileID.Anvils], moddedIngredients: [(ModContent.ItemType<SharedChestGolden>(), 1)]);

        RecipeHelper.AddRecipe(ItemID.CloudinaBottle, [(ItemID.BottledWater, 1), (ItemID.Cloud, 100), (ItemID.RainCloud, 25)], [TileID.Anvils], moddedIngredients: [(ModContent.ItemType<SharedChestGolden>(), 1)]);

        RecipeHelper.AddRecipe(ItemID.BandofRegeneration, [(ItemID.LifeCrystal, 1), (ItemID.RegenerationPotion, 3), (ItemID.Ruby, 5)], [TileID.Anvils], moddedIngredients: [(ModContent.ItemType<SharedChestGolden>(), 1)]);

        RecipeHelper.AddRecipe(ItemID.MagicMirror, [(ItemID.RecallPotion, 20), (ItemID.Diamond, 3)], [TileID.Anvils], recipeGroups: [("GoldBar", 12)], moddedIngredients: [(ModContent.ItemType<SharedChestGolden>(), 1)]);

        RecipeHelper.AddRecipe(ItemID.IceMirror, [(ItemID.RecallPotion, 20), (ItemID.Diamond, 1), (ItemID.IceBlock, 250)], [TileID.Anvils], recipeGroups: [("GoldBar", 12)], moddedIngredients: [(ModContent.ItemType<SharedChestIce>(), 1)]);
    }
}
