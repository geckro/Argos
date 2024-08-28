using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Argos.Common.RecipeEdits.Terraria;

public class Accessories : GlobalItem
{
    public override void AddRecipes()
    {
        RecipeHelper.AddRecipe(ItemID.Magiluminescence,
                [(ItemID.Topaz, 10), (ItemID.Amber, 8), (ItemID.Feather, 4), (ItemID.YellowDye, 6)],
                recipeGroups: [("DemoniteBar", 15)], tiles: [TileID.HeavyWorkBench]);

        RecipeHelper.AddRecipe(ItemID.WhiteString, [(ItemID.Cobweb, 40), (ItemID.Silk, 5), (ItemID.Diamond, 1)],
                [TileID.Loom]);

        RecipeHelper.AddRecipe(ItemID.AnkhShield, [(ItemID.ObsidianShield, 1), (ItemID.AnkhCharm, 1), (ItemID.FrozenShield, 1), (ItemID.HeroShield, 1)], [TileID.MythrilAnvil], [Condition.InAether]);

        RecipeHelper.AddRecipe(ItemID.AnkhCharm, [(ItemID.ArmorBracing, 1), (ItemID.MedicatedBandage, 1), (ItemID.ThePlan, 1), (ItemID.CountercurseMantra, 1), (ItemID.ReflectiveShades, 1), (ItemID.PharaohsMask, 1), (ItemID.PharaohsRobe, 1)], [TileID.MythrilAnvil], [Condition.InDesert]);

        RecipeHelper.AddRecipe(ItemID.ObsidianSkull, [(ItemID.Obsidian, 35), (ItemID.Skull, 1)], [TileID.Hellforge]);

        RecipeHelper.AddRecipe(ItemID.SpectreBoots, [(ItemID.RocketBoots, 1), (ItemID.SkyBlueDye, 1)],
                [TileID.TinkerersWorkbench], recipeGroups:
                [
                        ("HermesBoots", 1)
                ]);

        RecipeHelper.AddRecipe(ItemID.LightningBoots,
        [
                (ItemID.SpectreBoots, 1), (ItemID.AnkletoftheWind, 1), (ItemID.Aglet, 1), (ItemID.FallenStar, 5),
                (ItemID.YellowDye, 1)
        ], [TileID.TinkerersWorkbench]);

        RecipeHelper.AddRecipe(ItemID.FrostsparkBoots,
                [(ItemID.LightningBoots, 1), (ItemID.IceSkates, 1), (ItemID.CyanDye, 1)],
                [TileID.TinkerersWorkbench, TileID.IceMachine]);

        RecipeHelper.AddRecipe(ItemID.TerrasparkBoots,
        [
                (ItemID.FrostsparkBoots, 1), (ItemID.LavaWaders, 1), (ItemID.GreenDye, 1), (ItemID.SwiftnessPotion, 10)
        ], [TileID.TinkerersWorkbench]);

        RecipeHelper.AddRecipe(ItemID.ObsidianWaterWalkingBoots,
        [
                (ItemID.ObsidianSkull, 1), (ItemID.WaterWalkingBoots, 1), (ItemID.FlameWakerBoots, 1),
                (ItemID.ObsidianSkinPotion, 3)
        ], [TileID.TinkerersWorkbench]);

        RecipeHelper.AddRecipe(ItemID.RedString, [(ItemID.WhiteString, 1), (ItemID.RedDye, 2), (ItemID.Ruby, 1)],
                [TileID.Loom, TileID.DyeVat]);

        RecipeHelper.AddRecipe(ItemID.SkyBlueString,
                [(ItemID.WhiteString, 1), (ItemID.SkyBlueDye, 2), (ItemID.Sapphire, 1)], [TileID.Loom, TileID.DyeVat]);

        RecipeHelper.AddRecipe(ItemID.OrangeString, [(ItemID.WhiteString, 1), (ItemID.OrangeDye, 2), (ItemID.Amber, 1)],
                [TileID.Loom, TileID.DyeVat]);

        RecipeHelper.AddRecipe(ItemID.GreenString, [(ItemID.WhiteString, 1), (ItemID.GreenDye, 2), (ItemID.Emerald, 1)],
                [TileID.Loom, TileID.DyeVat]);

        RecipeHelper.AddRecipe(ItemID.YellowString, [(ItemID.WhiteString, 1), (ItemID.YellowDye, 2), (ItemID.Topaz, 1)],
                [TileID.Loom, TileID.DyeVat]);

        RecipeHelper.AddRecipe(ItemID.PurpleString,
                [(ItemID.WhiteString, 1), (ItemID.PurpleDye, 2), (ItemID.Amethyst, 1)], [TileID.Loom, TileID.DyeVat]);

        RecipeHelper.AddRecipe(ItemID.RainbowString, [(ItemID.WhiteString, 1), (ItemID.RainbowDye, 2)],
                [TileID.Loom, TileID.DyeVat]);
    }
}

public class Hooks : GlobalItem
{
    public override void AddRecipes()
    {
        RecipeHelper.AddRecipe(ItemID.GrapplingHook, [(ItemID.Chain, 6), (ItemID.Hook, 1)], [TileID.Anvils],
                recipeGroups: [("IronBar", 6)]);

        RecipeHelper.AddRecipe(ItemID.AmethystHook, [(ItemID.Amethyst, 15), (ItemID.Hook, 1)], [TileID.Anvils],
                recipeGroups: [("SilverBar", 6)]);

        RecipeHelper.AddRecipe(ItemID.TopazHook, [(ItemID.Topaz, 15), (ItemID.Hook, 1)], [TileID.Anvils],
                recipeGroups: [("SilverBar", 6)]);

        RecipeHelper.AddRecipe(ItemID.EmeraldHook, [(ItemID.Emerald, 15), (ItemID.Hook, 1)], [TileID.Anvils],
                recipeGroups: [("SilverBar", 6)]);

        RecipeHelper.AddRecipe(ItemID.SapphireHook, [(ItemID.Sapphire, 15), (ItemID.Hook, 1)], [TileID.Anvils],
                recipeGroups: [("SilverBar", 6)]);

        RecipeHelper.AddRecipe(ItemID.RubyHook, [(ItemID.Ruby, 15), (ItemID.Hook, 1)], [TileID.Anvils],
                recipeGroups: [("SilverBar", 6)]);

        RecipeHelper.AddRecipe(ItemID.DiamondHook, [(ItemID.Diamond, 15), (ItemID.Hook, 1)], [TileID.Anvils],
                recipeGroups: [("SilverBar", 6)]);

        RecipeHelper.AddRecipe(ItemID.AmberHook, [(ItemID.Amber, 15), (ItemID.Hook, 1)], [TileID.Anvils],
                recipeGroups: [("SilverBar", 6)]);
    }
}
