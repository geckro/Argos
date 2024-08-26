using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Argos.Common.RecipeEdits.Terraria;

public class Pickaxes : GlobalItem
{
    public override void AddRecipes()
    {
        RecipeHelper.AddRecipe(ItemID.CopperPickaxe, [(ItemID.CopperBar, 12), (ItemID.CactusPickaxe, 1)],
                recipeGroups: [("Wood", 6)], tiles: [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.TinPickaxe, [(ItemID.TinBar, 12), (ItemID.CactusPickaxe, 1)],
                recipeGroups: [("Wood", 6)], tiles: [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.IronPickaxe, [(ItemID.IronBar, 12)], recipeGroups: [("CopperPickaxe", 1)],
                tiles: [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.LeadPickaxe, [(ItemID.LeadBar, 12)], recipeGroups: [("CopperPickaxe", 1)],
                tiles: [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.SilverPickaxe, [(ItemID.SilverBar, 12), (ItemID.Sapphire, 1)],
                recipeGroups: [("IronPickaxe", 1)], tiles: [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.TungstenPickaxe, [(ItemID.TungstenBar, 12), (ItemID.Sapphire, 1)],
                recipeGroups: [("IronPickaxe", 1)], tiles: [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.GoldPickaxe, [(ItemID.GoldBar, 12), (ItemID.Ruby, 1)],
                recipeGroups: [("SilverPickaxe", 1)], tiles: [TileID.HeavyWorkBench]);

        RecipeHelper.AddRecipe(ItemID.PlatinumPickaxe, [(ItemID.PlatinumBar, 12), (ItemID.Ruby, 1)],
                recipeGroups: [("SilverPickaxe", 1)], tiles: [TileID.HeavyWorkBench]);

        RecipeHelper.AddRecipe(ItemID.FossilPickaxe, [(ItemID.FossilOre, 12), (ItemID.Amber, 2)],
                recipeGroups: [("GoldPickaxe", 1)], tiles: [TileID.CatBast]);

        RecipeHelper.AddRecipe(ItemID.NightmarePickaxe,
                [(ItemID.DemoniteBar, 12), (ItemID.Ebonwood, 24), (ItemID.ShadowScale, 8)],
                recipeGroups: [("GoldPickaxe", 1)], tiles: [TileID.DemonAltar], conditions: [Condition.InCorrupt]);

        RecipeHelper.AddRecipe(ItemID.DeathbringerPickaxe,
                [(ItemID.CrimtaneBar, 12), (ItemID.Shadewood, 24), (ItemID.TissueSample, 8)],
                recipeGroups: [("GoldPickaxe", 1)], tiles: [TileID.DemonAltar], conditions: [Condition.InCrimson]);

        RecipeHelper.AddRecipe(ItemID.MoltenPickaxe,
                [(ItemID.HellstoneBar, 12), (ItemID.AshWood, 24), (ItemID.BeeWax, 8)],
                recipeGroups: [("NightmarePickaxe", 1)], tiles: [TileID.Hellforge],
                conditions: [Condition.InUnderworld, Condition.NearLava]);
    }
}

public class Axes : GlobalItem
{
    public override void AddRecipes()
    {
        RecipeHelper.AddRecipe(ItemID.CopperAxe, [(ItemID.CopperBar, 8)], recipeGroups: [("Wood", 6)],
                tiles: [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.TinAxe, [(ItemID.TinBar, 8)], recipeGroups: [("Wood", 6)],
                tiles: [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.IronAxe, [(ItemID.IronBar, 8)], recipeGroups: [("CopperAxe", 1)],
                tiles: [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.LeadAxe, [(ItemID.LeadBar, 8)], recipeGroups: [("CopperAxe", 1)],
                tiles: [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.SilverAxe, [(ItemID.SilverBar, 8), (ItemID.Sapphire, 1)],
                recipeGroups: [("IronAxe", 1)], tiles: [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.TungstenAxe, [(ItemID.TungstenBar, 8), (ItemID.Sapphire, 1)],
                recipeGroups: [("IronAxe", 1)], tiles: [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.GoldAxe, [(ItemID.GoldBar, 8), (ItemID.Ruby, 1)],
                recipeGroups: [("SilverAxe", 1)], tiles: [TileID.HeavyWorkBench]);

        RecipeHelper.AddRecipe(ItemID.PlatinumAxe, [(ItemID.PlatinumBar, 8), (ItemID.Ruby, 1)],
                recipeGroups: [("SilverAxe", 1)], tiles: [TileID.HeavyWorkBench]);

        RecipeHelper.AddRecipe(ItemID.WarAxeoftheNight, [(ItemID.DemoniteBar, 8), (ItemID.Ebonwood, 24)],
                recipeGroups: [("GoldAxe", 1)], tiles: [TileID.DemonAltar], conditions: [Condition.InCorrupt]);

        RecipeHelper.AddRecipe(ItemID.BloodLustCluster, [(ItemID.CrimtaneBar, 8), (ItemID.Shadewood, 24)],
                recipeGroups: [("GoldAxe", 1)], tiles: [TileID.DemonAltar], conditions: [Condition.InCrimson]);

        RecipeHelper.AddRecipe(ItemID.MoltenHamaxe,
                [(ItemID.HellstoneBar, 8), (ItemID.AshWood, 24), (ItemID.BeeWax, 8)], [TileID.Hellforge],
                [Condition.InUnderworld, Condition.NearLava], [("WarAxeoftheNight", 1)]);
    }
}

public class FishingPoles : GlobalItem
{
    public override void AddRecipes()
    {
        RecipeHelper.AddRecipe(ItemID.WoodFishingPole, [(ItemID.Wood, 24), (ItemID.Cobweb, 20), (ItemID.Acorn, 3)],
                [TileID.WorkBenches]);
    }
}

public class Hammers : GlobalItem
{
        public override void AddRecipes()
        {
                RecipeHelper.AddRecipe(ItemID.WoodenHammer, [(ItemID.Wood, 14), (ItemID.StoneBlock, 25)],
                                [TileID.WorkBenches]);
        }
}