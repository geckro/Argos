using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Argos.Common.RecipeEdits.Luiafk;

public class Luiafk : GlobalItem
{
    public override void AddRecipes()
    {
        if (!EnabledMods.LuiafkEnabled)
        {
            return;
        }

        EnabledMods.ModLuiafkEnabled.TryFind("UnlimitedBoneArrows", out ModItem unlBoneArrows);
        EnabledMods.ModLuiafkEnabled.TryFind("UnlimitedChlorophyteArrows", out ModItem unlChloroArrows);
        EnabledMods.ModLuiafkEnabled.TryFind("UnlimitedCursedArrows", out ModItem unlCursedArrows);
        EnabledMods.ModLuiafkEnabled.TryFind("UnlimitedFlamingArrows", out ModItem unlFlamingArrows);
        EnabledMods.ModLuiafkEnabled.TryFind("UnlimitedFrostburnArrows", out ModItem unlFrostburnArrows);
        EnabledMods.ModLuiafkEnabled.TryFind("UnlimitedHellfireArrows", out ModItem unlHellfireArrows);
        EnabledMods.ModLuiafkEnabled.TryFind("UnlimitedHolyArrows", out ModItem unlHolyArrows);
        EnabledMods.ModLuiafkEnabled.TryFind("UnlimitedIchorArrows", out ModItem unlIchorArrows);
        EnabledMods.ModLuiafkEnabled.TryFind("UnlimitedJesterArrows", out ModItem unlJesterArrows);
        EnabledMods.ModLuiafkEnabled.TryFind("UnlimitedLuminiteArrows", out ModItem unlLuminiteArrows);
        EnabledMods.ModLuiafkEnabled.TryFind("UnlimitedShimmerArrows", out ModItem unlShimmerArrows);
        EnabledMods.ModLuiafkEnabled.TryFind("UnlimitedUnholyArrows", out ModItem unlUnholyArrows);
        EnabledMods.ModLuiafkEnabled.TryFind("UnlimitedVenomArrows", out ModItem unlVenomArrows);
        EnabledMods.ModLuiafkEnabled.TryFind("UnlimitedWoodenArrows", out ModItem unlWoodArrowsDisable);

        EnabledMods.ModLuiafkEnabled.TryFind("UnlimitedChlorophyteBullets", out ModItem unlChloroBullets);
        EnabledMods.ModLuiafkEnabled.TryFind("UnlimitedLuminiteBullets", out ModItem unlLuminiteBullets);
        EnabledMods.ModLuiafkEnabled.TryFind("UnlimitedMeteoriteBullets", out ModItem unlMeteorShot);
        EnabledMods.ModLuiafkEnabled.TryFind("UnlimitedMusketBalls", out ModItem unlMusketBallsDisable);

        EnabledMods.ModLuiafkEnabled.TryFind("UnlimitedTorches", out ModItem unlTorches);

        RecipeHelper.RecipesToDisable.Add(unlWoodArrowsDisable.Type);
        RecipeHelper.RecipesToDisable.Add(unlMusketBallsDisable.Type);
        // RecipeHelper.AddToDisabledRecipes(ItemID.CopperBar, Recipe.Create(ItemID.CopperBar).AddIngredient(ItemID.TinBar).AddTile(TileID.Furnaces));

        RecipeHelper.AddRecipe(unlBoneArrows.Type, [(ItemID.EndlessQuiver, 1), (ItemID.BoneArrow, 9999)], [TileID.BoneWelder]);
        RecipeHelper.AddRecipe(unlChloroArrows.Type, [(ItemID.EndlessQuiver, 1), (ItemID.ChlorophyteArrow, 9999)], [TileID.Autohammer]);
        RecipeHelper.AddRecipe(unlCursedArrows.Type, [(unlUnholyArrows.Type, 1), (ItemID.CursedArrow, 9999)], [TileID.DemonAltar]);
        RecipeHelper.AddRecipe(unlFlamingArrows.Type, [(ItemID.EndlessQuiver, 1), (ItemID.FlamingArrow, 9999)], [TileID.Hellforge]);
        RecipeHelper.AddRecipe(unlFrostburnArrows.Type, [(ItemID.EndlessQuiver, 1), (ItemID.FrostburnArrow, 9999)], [TileID.IceMachine]);
        RecipeHelper.AddRecipe(unlHellfireArrows.Type, [(unlFlamingArrows.Type, 1), (ItemID.HellfireArrow, 9999)], [TileID.Hellforge]);
        RecipeHelper.AddRecipe(unlHolyArrows.Type, [(unlJesterArrows.Type, 1), (ItemID.HolyArrow, 9999)], [TileID.SkyMill]);
        RecipeHelper.AddRecipe(unlIchorArrows.Type, [(unlUnholyArrows.Type, 1), (ItemID.IchorArrow, 9999)], [TileID.DemonAltar]);
        RecipeHelper.AddRecipe(unlJesterArrows.Type, [(ItemID.EndlessQuiver, 1), (ItemID.JestersArrow, 9999)], [TileID.SkyMill]);
        RecipeHelper.AddRecipe(unlLuminiteArrows.Type, [(unlChloroArrows.Type, 1), (ItemID.MoonlordArrow, 9999)], [TileID.LunarCraftingStation]);
        RecipeHelper.AddRecipe(unlShimmerArrows.Type, [(ItemID.EndlessQuiver, 1), (ItemID.ShimmerArrow, 9999)], [TileID.CrystalBall], [Condition.InAether]);
        RecipeHelper.AddRecipe(unlUnholyArrows.Type, [(ItemID.EndlessQuiver, 1), (ItemID.UnholyArrow, 9999)], [TileID.DemonAltar]);
        RecipeHelper.AddRecipe(unlVenomArrows.Type, [(unlChloroArrows.Type, 1), (ItemID.VenomArrow, 9999)], [TileID.BewitchingTable]);

        RecipeHelper.AddRecipe(unlChloroBullets.Type, [(ItemID.EndlessMusketPouch, 1), (ItemID.MoonlordBullet, 9999)], [TileID.Autohammer]);
        RecipeHelper.AddRecipe(unlLuminiteBullets.Type, [(unlChloroBullets.Type, 1), (ItemID.ChlorophyteBullet, 9999)], [TileID.LunarCraftingStation]);
        RecipeHelper.AddRecipe(unlMeteorShot.Type, [(ItemID.EndlessMusketPouch, 1), (ItemID.MeteorShot, 9999)], [TileID.Hellforge]);

        RecipeHelper.AddRecipe(unlTorches.Type, [(ItemID.Torch, 9999)], [TileID.Campfire]);
    }
}
