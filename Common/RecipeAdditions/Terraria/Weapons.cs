using Argos.Content.Parts.Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Argos.Common.RecipeAdditions.Terraria;

public class WeaponsAdditions : GlobalItem
{
    public override void AddRecipes()
    {
        RecipeHelper.AddRecipe(ItemID.Mace, [(ItemID.RichMahogany, 12), (ItemID.Chain, 9)], [TileID.HeavyWorkBench], recipeGroups: [("IronBar", 25)], moddedIngredients: [(ModContent.ItemType<SharedChestGolden>(), 1)]);

        RecipeHelper.AddRecipe(ItemID.WoodenBoomerang, [(ItemID.Wood, 24), (ItemID.StoneBlock, 12)], [TileID.WorkBenches], recipeGroups: [("IronBar", 6)], moddedIngredients: [(ModContent.ItemType<SharedChestWooden>(), 1)]);

        RecipeHelper.AddRecipe(ItemID.Spear, [], [TileID.Anvils], recipeGroups: [("GoldBar", 8), ("SilverBar", 6)], moddedIngredients: [(ModContent.ItemType<SharedChestWooden>(), 1)]);

        RecipeHelper.AddRecipe(ItemID.AntlionClaw, [(ItemID.CactusSword, 1), (ItemID.Sandstone, 60), (ItemID.Amber, 2)],
                moddedIngredients: [(ModContent.ItemType<MeleeSwordMandibleBlade>(), 2)], tiles: [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.IceBlade, [(ItemID.IceBlock, 120), (ItemID.Shiverthorn, 8)],
                moddedIngredients: [(ModContent.ItemType<SharedChestIce>(), 1)],
                recipeGroups: [("GoldBroadsword", 1)], tiles: [TileID.IceMachine]);

        RecipeHelper.AddRecipe(ItemID.IceBoomerang,
                [(ItemID.IceBlock, 150), (ItemID.Shiverthorn, 6), (ItemID.FlinxFur, 4), (ItemID.WoodenBoomerang, 1)],
                moddedIngredients: [(ModContent.ItemType<SharedChestIce>(), 1)],
                tiles: [TileID.IceMachine]);

        RecipeHelper.AddRecipe(ItemID.SnowballCannon, [(ItemID.Snowball, 500), (ItemID.BorealWoodBow, 1)],
                moddedIngredients: [(ModContent.ItemType<SharedChestIce>(), 1)],
                recipeGroups: [("SilverBar", 12)], tiles: [TileID.IceMachine]);

        RecipeHelper.AddRecipe(ItemID.IceBow,
                [(ItemID.MoltenFury, 1), (ItemID.FrostburnArrow, 750), (ItemID.FrostCore, 1)],
                moddedIngredients: [(ModContent.ItemType<SharedMimicIce>(), 1)],
                tiles: [TileID.IceMachine, TileID.MythrilAnvil]);

        RecipeHelper.AddRecipe(ItemID.Frostbrand,
                [(ItemID.IceBlade, 1), (ItemID.FrostCore, 1), (ItemID.LivingFrostFireBlock, 100)],
                moddedIngredients: [(ModContent.ItemType<SharedMimicIce>(), 1)],
                tiles: [TileID.IceMachine, TileID.MythrilAnvil]);

        RecipeHelper.AddRecipe(ItemID.IceSickle,
                [(ItemID.Sickle, 1), (ItemID.IceFeather, 1), (ItemID.IceElementalBanner, 1)],
                moddedIngredients: [(ModContent.ItemType<MeleeSwordIceSickle>(), 1)],
                tiles: [TileID.IceMachine, TileID.MythrilAnvil]);

        RecipeHelper.AddRecipe(ItemID.FlowerofFrost,
                [(ItemID.FlowerofFire, 1), (ItemID.PixieDust, 12), (ItemID.FrostCore, 1)],
                moddedIngredients: [(ModContent.ItemType<SharedMimicIce>(), 1)],
                tiles: [TileID.IceMachine, TileID.MythrilAnvil]);

        RecipeHelper.AddRecipe(ItemID.FlowerofFire,
                [(ItemID.NaturesGift, 1), (ItemID.HellstoneBar, 16), (ItemID.Fireblossom, 12)],
                moddedIngredients: [(ModContent.ItemType<SharedChestShadowUnderworld>(), 1)], tiles: [TileID.Hellforge]);

        RecipeHelper.AddRecipe(ItemID.DarkLance,
                [(ItemID.ThunderSpear, 1), (ItemID.AshWood, 120), (ItemID.Obsidian, 45)],
                moddedIngredients: [(ModContent.ItemType<SharedChestShadowUnderworld>(), 1)],
                tiles: [TileID.Hellforge, TileID.DemonAltar]);

        RecipeHelper.AddRecipe(ItemID.Flamelash,
                [(ItemID.MagicMissile, 1), (ItemID.HellstoneBar, 16), (ItemID.LavaSlimeBanner, 1)],
                moddedIngredients: [(ModContent.ItemType<SharedChestShadowUnderworld>(), 1)], tiles: [TileID.Hellforge]);

        RecipeHelper.AddRecipe(ItemID.HellwingBow,
                [(ItemID.MoltenFury, 1), (ItemID.LavaBucket, 8), (ItemID.HellbatBanner, 1)],
                moddedIngredients: [(ModContent.ItemType<SharedChestShadowUnderworld>(), 1)], tiles: [TileID.Hellforge]);

        RecipeHelper.AddRecipe(ItemID.Sunfury,
                [(ItemID.FlamingMace, 1), (ItemID.HellstoneBar, 12), (ItemID.Sunflower, 12), (ItemID.ObsidianRose, 1)],
                moddedIngredients: [(ModContent.ItemType<SharedChestShadowUnderworld>(), 1)],
                tiles: [TileID.Hellforge, TileID.SkyMill]);

        RecipeHelper.AddRecipe(ItemID.DemonScythe, [(ItemID.Book, 1), (ItemID.DemonBanner, 1)],
                recipeGroups: [("DemoniteBar", 16), ("ShadowScale", 12)],
                moddedIngredients: [(ModContent.ItemType<MageDemonScythe>(), 1)],
                tiles: [TileID.Hellforge, TileID.Bookcases]);

        RecipeHelper.AddRecipe(ItemID.Cascade,
                [(ItemID.Rally, 1), (ItemID.HellstoneBar, 18), (ItemID.FlaskofFire, 1), (ItemID.Bone, 35)],
                moddedIngredients: [(ModContent.ItemType<MeleeYoyoCascade>(), 1)], tiles: [TileID.Hellforge]);

        RecipeHelper.AddRecipe(ItemID.HelFire, [(ItemID.Cascade, 1), (ItemID.LivingFireBlock, 150)],
                moddedIngredients: [(ModContent.ItemType<MeleeYoyoHelFire>(), 1)],
                tiles: [TileID.Hellforge, TileID.CrystalBall]);
    }
}
