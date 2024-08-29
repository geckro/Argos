using Argos.Common.Config;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Argos.Common.RecipeHelper;

namespace Argos.Common.RecipeEdits;

public class LuiafkAdditions : GlobalItem
{
    public override void AddRecipes()
    {
        if (!EnabledMods.LuiafkEnabled || !ModContent.GetInstance<ArgosConfig>().EnableLuiafkSupport)
        {
            return;
        }

        EnabledMods.ModLuiafkEnabled.TryFind("UnlimitedBoneArrows", out ModItem unlBoneArrows);
        EnabledMods.ModLuiafkEnabled.TryFind("UnlimitedChlorophyteArrows", out ModItem unlChloroArrows);
        EnabledMods.ModLuiafkEnabled.TryFind("UnlimitedChlorophyteBullets", out ModItem unlChloroBullets);
        EnabledMods.ModLuiafkEnabled.TryFind("UnlimitedCursedArrows", out ModItem unlCursedArrows);
        EnabledMods.ModLuiafkEnabled.TryFind("UnlimitedFlamingArrows", out ModItem unlFlamingArrows);
        EnabledMods.ModLuiafkEnabled.TryFind("UnlimitedFrostburnArrows", out ModItem unlFrostburnArrows);
        EnabledMods.ModLuiafkEnabled.TryFind("UnlimitedHellfireArrows", out ModItem unlHellfireArrows);
        EnabledMods.ModLuiafkEnabled.TryFind("UnlimitedHolyArrows", out ModItem unlHolyArrows);
        EnabledMods.ModLuiafkEnabled.TryFind("UnlimitedIchorArrows", out ModItem unlIchorArrows);
        EnabledMods.ModLuiafkEnabled.TryFind("UnlimitedJesterArrows", out ModItem unlJesterArrows);
        EnabledMods.ModLuiafkEnabled.TryFind("UnlimitedLuminiteArrows", out ModItem unlLuminiteArrows);
        EnabledMods.ModLuiafkEnabled.TryFind("UnlimitedLuminiteBullets", out ModItem unlLuminiteBullets);
        EnabledMods.ModLuiafkEnabled.TryFind("UnlimitedMeteoriteBullets", out ModItem unlMeteorShot);
        EnabledMods.ModLuiafkEnabled.TryFind("UnlimitedMusketBalls", out ModItem unlMusketBallsDisable);
        EnabledMods.ModLuiafkEnabled.TryFind("UnlimitedShimmerArrows", out ModItem unlShimmerArrows);
        EnabledMods.ModLuiafkEnabled.TryFind("UnlimitedTorches", out ModItem unlTorches);
        EnabledMods.ModLuiafkEnabled.TryFind("UnlimitedUnholyArrows", out ModItem unlUnholyArrows);
        EnabledMods.ModLuiafkEnabled.TryFind("UnlimitedVenomArrows", out ModItem unlVenomArrows);
        EnabledMods.ModLuiafkEnabled.TryFind("UnlimitedWoodenArrows", out ModItem unlWoodArrowsDisable);

        RecipesToDisable.Add(unlWoodArrowsDisable.Type);
        RecipesToDisable.Add(unlMusketBallsDisable.Type);
        // RecipeHelper.AddToDisabledRecipes(ItemID.CopperBar, Recipe.Ingredient(ItemID.CopperBar).AddIngredient(ItemID.TinBar).AddTile(TileID.Furnaces));

        AddRecipe(unlBoneArrows.Type, [Ingredient(ItemID.EndlessQuiver), Ingredient(ItemID.BoneArrow, 9999)], [TileID.BoneWelder]);
        AddRecipe(unlChloroArrows.Type, [Ingredient(ItemID.EndlessQuiver), Ingredient(ItemID.ChlorophyteArrow, 9999)], [TileID.Autohammer]);
        AddRecipe(unlChloroBullets.Type, [Ingredient(ItemID.EndlessMusketPouch), Ingredient(ItemID.MoonlordBullet, 9999)], [TileID.Autohammer]);
        AddRecipe(unlCursedArrows.Type, [Ingredient(unlUnholyArrows.Type), Ingredient(ItemID.CursedArrow, 9999)], [TileID.DemonAltar]);
        AddRecipe(unlFlamingArrows.Type, [Ingredient(ItemID.EndlessQuiver), Ingredient(ItemID.FlamingArrow, 9999)], [TileID.Hellforge]);
        AddRecipe(unlFrostburnArrows.Type, [Ingredient(ItemID.EndlessQuiver), Ingredient(ItemID.FrostburnArrow, 9999)], [TileID.IceMachine]);
        AddRecipe(unlHellfireArrows.Type, [Ingredient(unlFlamingArrows.Type), Ingredient(ItemID.HellfireArrow, 9999)], [TileID.Hellforge]);
        AddRecipe(unlHolyArrows.Type, [Ingredient(unlJesterArrows.Type), Ingredient(ItemID.HolyArrow, 9999)], [TileID.SkyMill]);
        AddRecipe(unlIchorArrows.Type, [Ingredient(unlUnholyArrows.Type), Ingredient(ItemID.IchorArrow, 9999)], [TileID.DemonAltar]);
        AddRecipe(unlJesterArrows.Type, [Ingredient(ItemID.EndlessQuiver), Ingredient(ItemID.JestersArrow, 9999)], [TileID.SkyMill]);
        AddRecipe(unlLuminiteArrows.Type, [Ingredient(unlChloroArrows.Type), Ingredient(ItemID.MoonlordArrow, 9999)], [TileID.LunarCraftingStation]);
        AddRecipe(unlLuminiteBullets.Type, [Ingredient(unlChloroBullets.Type), Ingredient(ItemID.ChlorophyteBullet, 9999)], [TileID.LunarCraftingStation]);
        AddRecipe(unlMeteorShot.Type, [Ingredient(ItemID.EndlessMusketPouch), Ingredient(ItemID.MeteorShot, 9999)], [TileID.Hellforge]);
        AddRecipe(unlShimmerArrows.Type, [Ingredient(ItemID.EndlessQuiver), Ingredient(ItemID.ShimmerArrow, 9999)], [TileID.CrystalBall], [Condition.InAether]);
        AddRecipe(unlTorches.Type, [Ingredient(ItemID.Torch, 9999)], [TileID.Campfire]);
        AddRecipe(unlUnholyArrows.Type, [Ingredient(ItemID.EndlessQuiver), Ingredient(ItemID.UnholyArrow, 9999)], [TileID.DemonAltar]);
        AddRecipe(unlVenomArrows.Type, [Ingredient(unlChloroArrows.Type), Ingredient(ItemID.VenomArrow, 9999)], [TileID.BewitchingTable]);
    }
}
