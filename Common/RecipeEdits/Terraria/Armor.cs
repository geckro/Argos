using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Argos.Common.RecipeEdits.Terraria;

public class Armor : GlobalItem
{
    public override void AddRecipes()
    {
        RecipeHelper.AddRecipe(ItemID.WoodHelmet, [(ItemID.Wood, 22), (ItemID.ClayBlock, 10)], [TileID.WorkBenches]);

        RecipeHelper.AddRecipe(ItemID.WoodBreastplate, [(ItemID.Wood, 35), (ItemID.ClayBlock, 24)],
                [TileID.WorkBenches]);

        RecipeHelper.AddRecipe(ItemID.WoodGreaves, [(ItemID.Wood, 28), (ItemID.ClayBlock, 16)], [TileID.WorkBenches]);

        RecipeHelper.AddRecipe(ItemID.BeeHeadgear, [(ItemID.BeeWax, 10), (ItemID.Stinger, 12)],
                [TileID.HoneyDispenser]);

        RecipeHelper.AddRecipe(ItemID.BeeBreastplate,
                [(ItemID.BeeWax, 14), (ItemID.Stinger, 16), (ItemID.BottledHoney, 8)], [TileID.HoneyDispenser]);

        RecipeHelper.AddRecipe(ItemID.BeeGreaves, [(ItemID.BeeWax, 12), (ItemID.Stinger, 10)], [TileID.HoneyDispenser]);

        RecipeHelper.AddRecipe(ItemID.MoltenHelmet,
                [(ItemID.HellstoneBar, 20), (ItemID.LavaBucket, 12), (ItemID.AshWoodHelmet, 1)], [TileID.Hellforge],
                [Condition.NearLava]);

        RecipeHelper.AddRecipe(ItemID.MoltenBreastplate,
                [(ItemID.HellstoneBar, 30), (ItemID.LavaBucket, 20), (ItemID.AshWoodBreastplate, 1)],
                [TileID.Hellforge], [Condition.NearLava]);

        RecipeHelper.AddRecipe(ItemID.MoltenGreaves,
                [(ItemID.HellstoneBar, 25), (ItemID.LavaBucket, 16), (ItemID.AshWoodGreaves, 1)], [TileID.Hellforge],
                [Condition.NearLava]);

        RecipeHelper.AddRecipe(ItemID.JungleHat,
                [(ItemID.JungleSpores, 10), (ItemID.Vine, 3), (ItemID.RichMahoganyHelmet, 1)], [TileID.LivingLoom]);

        RecipeHelper.AddRecipe(ItemID.JungleShirt,
                [(ItemID.JungleSpores, 22), (ItemID.Stinger, 8), (ItemID.Vine, 3), (ItemID.RichMahoganyBreastplate, 1)],
                [TileID.LivingLoom]);

        RecipeHelper.AddRecipe(ItemID.JunglePants,
                [(ItemID.JungleSpores, 16), (ItemID.Stinger, 2), (ItemID.Vine, 2), (ItemID.RichMahoganyGreaves, 1)],
                [TileID.LivingLoom]);

        RecipeHelper.AddRecipe(ItemID.VortexHelmet, [(ItemID.FragmentVortex, 12), (ItemID.LunarBar, 10)],
                recipeGroups: [("ShroomiteHelmet", 1)], tiles: [TileID.LunarCraftingStation]);

        RecipeHelper.AddRecipe(ItemID.VortexBreastplate,
                [(ItemID.FragmentVortex, 24), (ItemID.LunarBar, 20), (ItemID.ShroomiteBreastplate, 1)],
                [TileID.LunarCraftingStation]);

        RecipeHelper.AddRecipe(ItemID.VortexLeggings,
                [(ItemID.FragmentVortex, 18), (ItemID.LunarBar, 14), (ItemID.ShroomiteLeggings, 1)],
                [TileID.LunarCraftingStation]);

        RecipeHelper.AddRecipe(ItemID.SolarFlareHelmet,
                [(ItemID.FragmentSolar, 12), (ItemID.LunarBar, 10), (ItemID.BeetleHelmet, 1)],
                [TileID.LunarCraftingStation]);

        RecipeHelper.AddRecipe(ItemID.SolarFlareBreastplate, [(ItemID.FragmentSolar, 24), (ItemID.LunarBar, 20)],
                recipeGroups: [("BeetleScaleMail", 1)], tiles: [TileID.LunarCraftingStation]);

        RecipeHelper.AddRecipe(ItemID.SolarFlareLeggings,
                [(ItemID.FragmentSolar, 18), (ItemID.LunarBar, 14), (ItemID.BeetleLeggings, 1)],
                [TileID.LunarCraftingStation]);

        RecipeHelper.AddRecipe(ItemID.NebulaHelmet, [(ItemID.FragmentNebula, 12), (ItemID.LunarBar, 10)],
                recipeGroups: [("SpectreMask", 1)], tiles: [TileID.LunarCraftingStation]);

        RecipeHelper.AddRecipe(ItemID.NebulaBreastplate,
                [(ItemID.FragmentNebula, 24), (ItemID.LunarBar, 20), (ItemID.SpectreRobe, 1)],
                [TileID.LunarCraftingStation]);

        RecipeHelper.AddRecipe(ItemID.NebulaLeggings,
                [(ItemID.FragmentNebula, 18), (ItemID.LunarBar, 14), (ItemID.SpectrePants, 1)],
                [TileID.LunarCraftingStation]);

        RecipeHelper.AddRecipe(ItemID.StardustHelmet,
                [(ItemID.FragmentStardust, 12), (ItemID.LunarBar, 10), (ItemID.TikiMask, 1), (ItemID.SpookyHelmet, 1)],
                [TileID.LunarCraftingStation]);

        RecipeHelper.AddRecipe(ItemID.StardustBreastplate, [
                (ItemID.FragmentStardust, 24), (ItemID.LunarBar, 20), (ItemID.TikiShirt, 1),
                (ItemID.SpookyBreastplate, 1)
        ], [TileID.LunarCraftingStation]);

        RecipeHelper.AddRecipe(ItemID.StardustLeggings, [
                (ItemID.FragmentStardust, 18), (ItemID.LunarBar, 14), (ItemID.TikiPants, 1), (ItemID.SpookyLeggings, 1)
        ], [TileID.LunarCraftingStation]);
    }
}
