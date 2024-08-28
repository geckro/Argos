using Argos.Content.Parts.Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Argos.Common.RecipeAdditions.Terraria;

public class AccessoriesAdditions : GlobalItem
{
    public override void AddRecipes()
    {
        RecipeHelper.AddRecipe(ItemID.Bezoar, [(ItemID.HornetBanner, 1), (ItemID.Vine, 8), (ItemID.FlaskofPoison, 2), (ItemID.BeeWax, 10), (ItemID.JungleGrassSeeds, 8), (ItemID.JungleSpores, 30)], [TileID.ImbuingStation], moddedIngredients: [(ModContent.ItemType<AccBezoar>(), 1)]);

        RecipeHelper.AddRecipe(ItemID.AdhesiveBandage, [(ItemID.AnglerFishBanner, 1), (ItemID.SpiderFang, 12), (ItemID.Spike, 100), (ItemID.Silk, 15), (ItemID.BrightOrangeDye, 1)], [TileID.Loom], moddedIngredients: [(ModContent.ItemType<AccAdhesiveBandage>(), 1)]);

        RecipeHelper.AddRecipe(ItemID.Blindfold, [(ItemID.BrightSilverDye, 1), (ItemID.DarkShard, 2), (ItemID.BlackLens, 2), (ItemID.Silk, 18)], [TileID.Loom], moddedIngredients: [(ModContent.ItemType<AccBlindfold>(), 1)]);

        RecipeHelper.AddRecipe(ItemID.Vitamins, [(ItemID.BottledHoney, 5), (ItemID.RegenerationPotion, 10), (ItemID.LifeforcePotion, 10), (ItemID.BandofRegeneration, 1)], [TileID.AlchemyTable], moddedIngredients: [(ModContent.ItemType<AccVitamins>(), 1)]);

        RecipeHelper.AddRecipe(ItemID.ArmorPolish, [(ItemID.Ectoplasm, 15), (ItemID.LightShard, 3)], [TileID.BoneWelder], recipeGroups: [("AdamantiteBar", 18)], moddedIngredients: [(ModContent.ItemType<AccArmorPolish>(), 1)]);

        RecipeHelper.AddRecipe(ItemID.Megaphone, [(ItemID.ManaCrystal, 5), (ItemID.RedDye, 2), (ItemID.Wire, 50)], [TileID.MythrilAnvil], recipeGroups: [("AdamantiteBar", 14)], moddedIngredients: [(ModContent.ItemType<AccMegaphone>(), 1)]);

        RecipeHelper.AddRecipe(ItemID.TrifoldMap, [(ItemID.PirateMap, 1), (ItemID.CrimsandBlock, 100), (ItemID.EbonsandBlock, 100), (ItemID.PearlsandBlock, 100), (ItemID.SandBlock, 100)], [TileID.Loom], moddedIngredients: [(ModContent.ItemType<AccTrifoldMap>(), 1)]);

        RecipeHelper.AddRecipe(ItemID.FastClock, [(ItemID.GoldWatch, 1), (ItemID.PlatinumWatch, 1), (ItemID.PixieDust, 50), (ItemID.SoulofFlight, 20)], [TileID.MythrilAnvil], moddedIngredients: [(ModContent.ItemType<AccFastClock>(), 1)]);

        RecipeHelper.AddRecipe(ItemID.PocketMirror, [(ItemID.MagicMirror, 1), (ItemID.IceMirror, 1), (ItemID.Marble, 250), (ItemID.SoulofLight, 12)], [TileID.MythrilAnvil], moddedIngredients: [(ModContent.ItemType<AccPocketMirror>(), 1)]);

        RecipeHelper.AddRecipe(ItemID.Nazar, [(ItemID.BlackLens, 1), (ItemID.Bone, 100), (ItemID.BlueDye, 3), (ItemID.LargeSapphire, 1)], [TileID.BoneWelder], moddedIngredients: [(ModContent.ItemType<AccNazar>(), 1)]);

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
