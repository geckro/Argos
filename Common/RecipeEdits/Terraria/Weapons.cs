using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Argos.Common.RecipeEdits.Terraria;

public class Swords : GlobalItem
{
    public override void AddRecipes()
    {
        RecipeHelper.AddRecipe(ItemID.FieryGreatsword,
                [(ItemID.HellstoneBar, 20), (ItemID.AshBlock, 250), (ItemID.AshWood, 20)],
                [TileID.Hellforge], [Condition.InUnderworld, Condition.NearLava]);

        RecipeHelper.AddRecipe(ItemID.WoodenSword,
                [(ItemID.Wood, 12), (ItemID.StoneBlock, 6), (ItemID.WebRope, 4)],
                [TileID.WorkBenches]);
    }
}

public class Summon : GlobalItem
{
    public override void AddRecipes()
    {
        RecipeHelper.AddRecipe(ItemID.StardustDragonStaff,
                [(ItemID.FragmentStardust, 20), (ItemID.MartianConduitPlating, 80)],
                [TileID.LunarCraftingStation]);

        RecipeHelper.AddRecipe(ItemID.StardustCellStaff,
                [(ItemID.FragmentStardust, 20), (ItemID.MartianConduitPlating, 80), (ItemID.DeadlySphereStaff, 1)],
                [TileID.LunarCraftingStation]);
    }
}

public class Bows : GlobalItem
{
    public override void AddRecipes()
    {
        RecipeHelper.AddRecipe(ItemID.WoodenBow,
                [(ItemID.Wood, 12), (ItemID.Cobweb, 20)],
                [TileID.WorkBenches]);

        RecipeHelper.AddRecipe(ItemID.MoltenFury, [(ItemID.HellstoneBar, 16), (ItemID.FlamingArrow, 500)],
                recipeGroups: [("DemonBow", 1)], tiles: [TileID.Hellforge],
                conditions: [Condition.InUnderworld, Condition.NearLava]);
    }
}

public class Boomerangs : GlobalItem
{
    public override void AddRecipes()
    {
        RecipeHelper.AddRecipe(ItemID.Flamarang,
                [(ItemID.HellstoneBar, 15), (ItemID.IceBoomerang, 1), (ItemID.FlaskofFire, 1)],
                [TileID.Hellforge], [Condition.InUnderworld, Condition.NearLava]);
    }
}