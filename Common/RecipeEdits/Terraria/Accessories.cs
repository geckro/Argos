using Terraria.ID;
using Terraria.ModLoader;

namespace Argos.Common.RecipeEdits.Terraria;

public class Accessories : GlobalItem
{
    public override void AddRecipes()
    {
        RecipeHelper.AddRecipe(ItemID.Magiluminescence, [(ItemID.Topaz, 10), (ItemID.Amber, 8), (ItemID.Feather, 4), (ItemID.YellowDye, 6)],
                recipeGroups: [("DemoniteBar", 15)], tiles: [TileID.HeavyWorkBench]);

        RecipeHelper.AddRecipe(ItemID.WhiteString, [(ItemID.Cobweb, 40), (ItemID.Silk, 5), (ItemID.Diamond, 1)], [TileID.Loom]);

        RecipeHelper.AddRecipe(ItemID.RedString, [(ItemID.WhiteString, 1), (ItemID.RedDye, 2), (ItemID.Ruby, 1)], [TileID.Loom, TileID.DyeVat]);

        RecipeHelper.AddRecipe(ItemID.SkyBlueString, [(ItemID.WhiteString, 1), (ItemID.SkyBlueDye, 2), (ItemID.Sapphire, 1)], [TileID.Loom, TileID.DyeVat]);

        RecipeHelper.AddRecipe(ItemID.OrangeString, [(ItemID.WhiteString, 1), (ItemID.OrangeDye, 2), (ItemID.Amber, 1)], [TileID.Loom, TileID.DyeVat]);

        RecipeHelper.AddRecipe(ItemID.GreenString, [(ItemID.WhiteString, 1), (ItemID.GreenDye, 2), (ItemID.Emerald, 1)], [TileID.Loom, TileID.DyeVat]);

        RecipeHelper.AddRecipe(ItemID.YellowString, [(ItemID.WhiteString, 1), (ItemID.YellowDye, 2), (ItemID.Topaz, 1)], [TileID.Loom, TileID.DyeVat]);

        RecipeHelper.AddRecipe(ItemID.PurpleString, [(ItemID.WhiteString, 1), (ItemID.PurpleDye, 2), (ItemID.Amethyst, 1)], [TileID.Loom, TileID.DyeVat]);

        RecipeHelper.AddRecipe(ItemID.RainbowString, [(ItemID.WhiteString, 1), (ItemID.RainbowDye, 2)], [TileID.Loom, TileID.DyeVat]);
    }
}

public class Hooks : GlobalItem
{
    public override void AddRecipes()
    {
        RecipeHelper.AddRecipe(ItemID.GrapplingHook, [(ItemID.Chain, 6), (ItemID.Hook, 1)], [TileID.Anvils], recipeGroups: [("IronBar", 6)]);

        RecipeHelper.AddRecipe(ItemID.AmethystHook, [(ItemID.Amethyst, 15), (ItemID.Hook, 1)], [TileID.Anvils], recipeGroups: [("SilverBar", 6)]);

        RecipeHelper.AddRecipe(ItemID.TopazHook, [(ItemID.Topaz, 15), (ItemID.Hook, 1)], [TileID.Anvils], recipeGroups: [("SilverBar", 6)]);

        RecipeHelper.AddRecipe(ItemID.EmeraldHook, [(ItemID.Emerald, 15), (ItemID.Hook, 1)], [TileID.Anvils], recipeGroups: [("SilverBar", 6)]);

        RecipeHelper.AddRecipe(ItemID.SapphireHook, [(ItemID.Sapphire, 15), (ItemID.Hook, 1)], [TileID.Anvils], recipeGroups: [("SilverBar", 6)]);

        RecipeHelper.AddRecipe(ItemID.RubyHook, [(ItemID.Ruby, 15), (ItemID.Hook, 1)], [TileID.Anvils], recipeGroups: [("SilverBar", 6)]);

        RecipeHelper.AddRecipe(ItemID.DiamondHook, [(ItemID.Diamond, 15), (ItemID.Hook, 1)], [TileID.Anvils], recipeGroups: [("SilverBar", 6)]);

        RecipeHelper.AddRecipe(ItemID.AmberHook, [(ItemID.Amber, 15), (ItemID.Hook, 1)], [TileID.Anvils], recipeGroups: [("SilverBar", 6)]);
    }
}
