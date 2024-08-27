using Terraria.ID;
using Terraria.ModLoader;

namespace Argos.Common.RecipeEdits.Terraria;

public class Ammo : GlobalItem
{
    public override void AddRecipes()
    {
        RecipeHelper.AddRecipe(ItemID.FlamingArrow, [(ItemID.WoodenArrow, 10), (ItemID.Torch, 1)], [TileID.Campfire],
                amount: 10);

        RecipeHelper.AddRecipe(ItemID.FrostburnArrow, [(ItemID.WoodenArrow, 10), (ItemID.IceTorch, 1)],
                [TileID.IceMachine], amount: 10);

        RecipeHelper.AddRecipe(ItemID.JestersArrow, [(ItemID.WoodenArrow, 10), (ItemID.FallenStar, 1)],
                [TileID.SkyMill], amount: 10);

        RecipeHelper.AddRecipe(ItemID.HellfireArrow, [(ItemID.FlamingArrow, 50), (ItemID.HellstoneBar, 1)],
                [TileID.Hellforge], amount: 150);

        RecipeHelper.AddRecipe(ItemID.UnholyArrow, [(ItemID.WoodenArrow, 10), (ItemID.VilePowder, 5)],
                [TileID.DemonAltar], amount: 10);

        RecipeHelper.AddRecipe(ItemID.UnholyArrow, [(ItemID.WoodenArrow, 10), (ItemID.ViciousPowder, 5)],
                [TileID.DemonAltar], amount: 10);

        RecipeHelper.AddRecipe(ItemID.CursedArrow, [(ItemID.UnholyArrow, 50), (ItemID.CursedFlame, 3)],
                [TileID.DemonAltar], amount: 50);

        RecipeHelper.AddRecipe(ItemID.HolyArrow,
                [(ItemID.JestersArrow, 75), (ItemID.UnicornHorn, 1), (ItemID.PixieDust, 4), (ItemID.Feather, 2)],
                [TileID.MythrilAnvil], amount: 75);

        RecipeHelper.AddRecipe(ItemID.ChlorophyteArrow, [(ItemID.WoodenArrow, 100), (ItemID.ChlorophyteBar, 1)],
                [TileID.MythrilAnvil], amount: 100);

        RecipeHelper.AddRecipe(ItemID.MoonlordArrow, [(ItemID.ChlorophyteArrow, 150), (ItemID.LunarBar, 1)],
                [TileID.LunarCraftingStation], amount: 150);

        RecipeHelper.AddRecipe(ItemID.VenomArrow, [(ItemID.ChlorophyteArrow, 25), (ItemID.VialofVenom, 1)],
                [TileID.BewitchingTable], amount: 25);

        RecipeHelper.AddRecipe(ItemID.IchorArrow, [(ItemID.UnholyArrow, 50), (ItemID.Ichor, 3)], [TileID.DemonAltar],
                amount: 50);

        RecipeHelper.AddRecipe(ItemID.SilverBullet, [(ItemID.MusketBall, 50), (ItemID.SilverBar, 1)], [TileID.Anvils],
                amount: 50);

        RecipeHelper.AddRecipe(ItemID.TungstenBullet, [(ItemID.MusketBall, 50), (ItemID.TungstenBar, 1)],
                [TileID.Anvils], amount: 50);

        RecipeHelper.AddRecipe(ItemID.CrystalBullet, [(ItemID.MusketBall, 50), (ItemID.CrystalShard, 2)],
                [TileID.MythrilAnvil], amount: 50);

        RecipeHelper.AddRecipe(ItemID.CursedBullet, [(ItemID.MusketBall, 80), (ItemID.CursedFlame, 3)],
                [TileID.MythrilAnvil], amount: 80);

        RecipeHelper.AddRecipe(ItemID.IchorBullet, [(ItemID.MusketBall, 80), (ItemID.Ichor, 3)], [TileID.MythrilAnvil],
                amount: 80);

        RecipeHelper.AddRecipe(ItemID.ChlorophyteBullet, [(ItemID.CrystalBullet, 50), (ItemID.ChlorophyteBar, 1)],
                [TileID.MythrilAnvil], amount: 50);

        RecipeHelper.AddRecipe(ItemID.MoonlordBullet, [(ItemID.ChlorophyteBullet, 150), (ItemID.LunarBar, 1)],
                [TileID.LunarCraftingStation], amount: 150);

        RecipeHelper.AddRecipe(ItemID.EndlessQuiver,
                [(ItemID.WoodenArrow, 9999), (ItemID.MagicQuiver, 1), (ItemID.SoulofSight, 5)], [TileID.CrystalBall]);

        RecipeHelper.AddRecipe(ItemID.EndlessMusketPouch, [(ItemID.MusketBall, 9999), (ItemID.SoulofSight, 5)],
                [TileID.CrystalBall]);
    }
}
