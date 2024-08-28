using Terraria.ID;
using Terraria.ModLoader;

namespace Argos.Common.RecipeEdits.Terraria;

public class BossSummons : GlobalItem
{
    public override void AddRecipes()
    {
        RecipeHelper.AddRecipe(ItemID.SuspiciousLookingEye,
                [(ItemID.Lens, 8), (ItemID.RottenChunk, 3), (ItemID.VilePowder, 6)], [TileID.DemonAltar]);
        RecipeHelper.AddRecipe(ItemID.SuspiciousLookingEye,
                [(ItemID.Lens, 8), (ItemID.Vertebrae, 3), (ItemID.ViciousPowder, 6)], [TileID.DemonAltar]);
        RecipeHelper.AddRecipe(ItemID.SlimeCrown, [(ItemID.GoldCrown, 1), (ItemID.Gel, 50), (ItemID.PinkGel, 10)],
                [TileID.DemonAltar]);
        RecipeHelper.AddRecipe(ItemID.SlimeCrown, [(ItemID.PlatinumCrown, 1), (ItemID.Gel, 50), (ItemID.PinkGel, 10)],
                [TileID.DemonAltar]);
        RecipeHelper.AddRecipe(ItemID.WormFood, [(ItemID.RottenChunk, 30), (ItemID.Stinger, 8)], [TileID.DemonAltar]);
        RecipeHelper.AddRecipe(ItemID.BloodySpine, [(ItemID.Vertebrae, 30), (ItemID.Stinger, 8)], [TileID.DemonAltar]);
        RecipeHelper.AddRecipe(ItemID.Abeemination, [(ItemID.Hive, 10), (ItemID.Stinger, 6), (ItemID.HoneyBlock, 6), (ItemID.CrispyHoneyBlock, 6)], [TileID.DemonAltar]);
        RecipeHelper.AddRecipe(ItemID.DeerThing, [(ItemID.FlinxFur, 5), (ItemID.Lens, 4), (ItemID.BeeWax, 6), (ItemID.IceBlock, 80)], [TileID.DemonAltar]);
        RecipeHelper.AddRecipe(ItemID.MechanicalEye, [(ItemID.BlackLens, 1), (ItemID.SuspiciousLookingEye, 1), (ItemID.SoulofLight, 8), (ItemID.Wire, 80)], [TileID.MythrilAnvil]);
        RecipeHelper.AddRecipe(ItemID.MechanicalWorm, [(ItemID.Lens, 8), (ItemID.WormFood, 1), (ItemID.SoulofNight, 8), (ItemID.Wire, 80)], [TileID.MythrilAnvil]);
        RecipeHelper.AddRecipe(ItemID.MechanicalWorm, [(ItemID.Lens, 8), (ItemID.BloodySpine, 1), (ItemID.SoulofNight, 8), (ItemID.Wire, 80)], [TileID.MythrilAnvil]);
        RecipeHelper.AddRecipe(ItemID.MechanicalSkull, [(ItemID.Lens, 6), (ItemID.ClothierVoodooDoll, 1), (ItemID.SoulofFlight, 25), (ItemID.Wire, 80)], [TileID.MythrilAnvil]);
        RecipeHelper.AddRecipe(ItemID.GoblinBattleStandard, [(ItemID.TatteredCloth, 10), (ItemID.RichMahogany, 18)], recipeGroups: [("DemoniteBar", 5)], tiles: [TileID.DemonAltar]);
        RecipeHelper.AddRecipe(ItemID.CelestialSigil, [(ItemID.FragmentSolar, 12), (ItemID.FragmentVortex, 12), (ItemID.FragmentNebula, 12), (ItemID.FragmentStardust, 12), (ItemID.MartianConduitPlating, 100)], [TileID.LunarCraftingStation]);
    }
}

