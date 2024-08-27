using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Argos.Common.RecipeEdits.Terraria;

public class Potions : GlobalItem
{
    public override void AddRecipes()
    {
        RecipeHelper.AddRecipe(ItemID.RegenerationPotion,
                [(ItemID.BottledWater, 1), (ItemID.Daybloom, 1), (ItemID.Mushroom, 2)], [TileID.Bottles]);

        RecipeHelper.AddRecipe(ItemID.SwiftnessPotion,
                [(ItemID.BottledWater, 1), (ItemID.Cactus, 2), (ItemID.Blinkroot, 1), (ItemID.Daybloom, 1)],
                [TileID.Bottles, TileID.Sunflower]);

        RecipeHelper.AddRecipe(ItemID.GillsPotion,
                [(ItemID.BottledWater, 3), (ItemID.Waterleaf, 2), (ItemID.Coral, 1), (ItemID.ShellPileBlock, 2)],
                [TileID.Bottles], [Condition.NearWater]);

        RecipeHelper.AddRecipe(ItemID.LifeforcePotion, [
                (ItemID.BottledHoney, 1), (ItemID.Moonglow, 1), (ItemID.Fireblossom, 2), (ItemID.Prismite, 1),
                (ItemID.LifeCrystal, 1)
        ], [TileID.Bottles]);

        RecipeHelper.AddRecipe(ItemID.IronskinPotion,
                [(ItemID.BottledWater, 1), (ItemID.Daybloom, 1), (ItemID.GlowingMushroom, 2)], [TileID.Bottles],
                recipeGroups: [("IronOre", 2)]);
    }
}

public class Food : GlobalItem
{
    public override void AddRecipes()
    {
        RecipeHelper.AddRecipe(ItemID.CookedFish, [(ItemID.Bass, 1), (ItemID.Acorn, 1), (ItemID.Mushroom, 1)],
                [TileID.CookingPots], [Condition.NearWater]);

        RecipeHelper.AddRecipe(ItemID.CookedFish, [(ItemID.Trout, 1), (ItemID.ShellPileBlock, 1), (ItemID.Mushroom, 1)],
                [TileID.CookingPots], [Condition.NearWater]);

        RecipeHelper.AddRecipe(ItemID.CookedFish, [(ItemID.AtlanticCod, 1), (ItemID.Acorn, 1), (ItemID.Shiverthorn, 1)],
                [TileID.CookingPots], [Condition.NearWater]);

        RecipeHelper.AddRecipe(ItemID.SeafoodDinner, [(ItemID.Mushroom, 2), (ItemID.Acorn, 3), (ItemID.Waterleaf, 1)],
                [TileID.CookingPots], [Condition.NearWater], [("DoubleCod", 3)]);

        RecipeHelper.AddRecipe(ItemID.RoastedBird, [(ItemID.GlowingMushroom, 2), (ItemID.Daybloom, 1)],
                [TileID.CookingPots, TileID.Furnaces], recipeGroups: [("Bird", 1)]);

        RecipeHelper.AddRecipe(ItemID.GoldenDelight,
                [(ItemID.DynastyBowl, 1), (ItemID.FallenStar, 3), (ItemID.BottledHoney, 2)],
                [TileID.CookingPots, TileID.GlassKiln], recipeGroups: [("GoldBunny", 1)]);

        RecipeHelper.AddRecipe(ItemID.BowlofSoup,
                [(ItemID.Mushroom, 2), (ItemID.Goldfish, 1), (ItemID.Daybloom, 2), (ItemID.Bowl, 1)],
                [TileID.CookingPots], [Condition.NearWater]);

        RecipeHelper.AddRecipe(ItemID.PumpkinPie,
                [(ItemID.Pumpkin, 12), (ItemID.Acorn, 4), (ItemID.GlowingMushroom, 6)],
                [TileID.Furnaces, TileID.CookingPots], [Condition.NearWater]);

        RecipeHelper.AddRecipe(ItemID.GrubSoup, [
                (ItemID.Grubby, 3), (ItemID.Sluggy, 2), (ItemID.Buggy, 1), (ItemID.GlassBowl, 1),
                (ItemID.JungleSpores, 3)
        ], [TileID.CookingPots], [Condition.NearWater]);

        RecipeHelper.AddRecipe(ItemID.MonsterLasagna, [
                (ItemID.RottenChunk, 8), (ItemID.Deathweed, 2), (ItemID.VileMushroom, 4),
                (ItemID.PurificationPowder, 12)
        ], [TileID.Furnaces, TileID.CookingPots]);

        RecipeHelper.AddRecipe(ItemID.MonsterLasagna, [
                (ItemID.Vertebrae, 8), (ItemID.Deathweed, 2), (ItemID.ViciousMushroom, 4),
                (ItemID.PurificationPowder, 12)
        ], [TileID.Furnaces, TileID.CookingPots]);
    }
}

public class Flasks : GlobalItem
{
    public override void AddRecipes()
    {
        RecipeHelper.AddRecipe(ItemID.FlaskofFire, [
                (ItemID.BottledHoney, 1), (ItemID.Hellstone, 5), (ItemID.Fireblossom, 2), (ItemID.Obsidian, 6),
                (ItemID.SpicyPepper, 1)
        ], [TileID.ImbuingStation], [Condition.NearLava]);

        RecipeHelper.AddRecipe(ItemID.FlaskofPoison, [
                (ItemID.BottledHoney, 1), (ItemID.Stinger, 5), (ItemID.JungleSpores, 6), (ItemID.Moonglow, 3),
                (ItemID.Mango, 1)
        ], [TileID.ImbuingStation], [Condition.NearHoney]);

        RecipeHelper.AddRecipe(ItemID.FlaskofParty, [
                (ItemID.BottledWater, 1), (ItemID.Confetti, 15), (ItemID.SillyBalloonGreen, 20),
                (ItemID.SillyBalloonPink, 20), (ItemID.SillyBalloonPurple, 20)
        ], [TileID.ImbuingStation], [Condition.BirthdayParty]);

        RecipeHelper.AddRecipe(ItemID.FlaskofGold,
                [(ItemID.BottledWater, 1), (ItemID.GoldDust, 8), (ItemID.GoldCoin, 3), (ItemID.Marble, 80)],
                [TileID.ImbuingStation], [Condition.InMarble]);

        RecipeHelper.AddRecipe(ItemID.FlaskofIchor,
                [(ItemID.BottledWater, 1), (ItemID.Ichor, 4), (ItemID.SoulofNight, 2), (ItemID.Vertebrae, 5)],
                [TileID.ImbuingStation], [Condition.NearShimmer]);

        RecipeHelper.AddRecipe(ItemID.FlaskofCursedFlames,
                [(ItemID.BottledWater, 1), (ItemID.CursedFlame, 4), (ItemID.SoulofNight, 2), (ItemID.RottenChunk, 5)],
                [TileID.ImbuingStation], [Condition.NearShimmer]);

        RecipeHelper.AddRecipe(ItemID.FlaskofVenom,
                [(ItemID.FlaskofPoison, 1), (ItemID.VialofVenom, 8), (ItemID.Granite, 80)], [TileID.ImbuingStation],
                [Condition.InGranite]);

        RecipeHelper.AddRecipe(ItemID.FlaskofNanites,
                [(ItemID.FlaskofFire, 1), (ItemID.Nanites, 10), (ItemID.Ectoplasm, 3), (ItemID.EchoBlock, 8)],
                [TileID.ImbuingStation], [Condition.InSpace]);
    }
}

public class BuffStations : GlobalItem
{
    public override void AddRecipes()
    {
        RecipeHelper.AddRecipe(ItemID.Campfire, [(ItemID.Torch, 45), (ItemID.Wood, 12)], [TileID.WorkBenches]);
        RecipeHelper.AddRecipe(ItemID.FrozenCampfire, [(ItemID.IceTorch, 45), (ItemID.BorealWood, 12)],
                [TileID.IceMachine]);
        RecipeHelper.AddRecipe(ItemID.JungleCampfire, [(ItemID.JungleCampfire, 45), (ItemID.RichMahogany, 12)],
                [TileID.WorkBenches]);
        RecipeHelper.AddRecipe(ItemID.DesertCampfire, [(ItemID.DesertTorch, 45), (ItemID.PalmWood, 12)],
                [TileID.GlassKiln]);
        RecipeHelper.AddRecipe(ItemID.MushroomCampfire, [(ItemID.MushroomTorch, 45), (ItemID.GlowingMushroom, 12)],
                [TileID.WorkBenches]);
        RecipeHelper.AddRecipe(ItemID.CoralCampfire, [(ItemID.CoralTorch, 45), (ItemID.ReefBlock, 12)],
                [TileID.WorkBenches]);
        RecipeHelper.AddRecipe(ItemID.CorruptCampfire, [(ItemID.CorruptTorch, 45), (ItemID.Ebonwood, 12)],
                [TileID.DemonAltar]);
        RecipeHelper.AddRecipe(ItemID.CrimsonCampfire, [(ItemID.CrimsonTorch, 45), (ItemID.Shadewood, 12)],
                [TileID.DemonAltar]);
        RecipeHelper.AddRecipe(ItemID.IchorCampfire, [(ItemID.IchorTorch, 45), (ItemID.SpookyWood, 12)],
                [TileID.DemonAltar]);
        RecipeHelper.AddRecipe(ItemID.CursedCampfire, [(ItemID.CursedTorch, 45), (ItemID.SpookyWood, 12)],
                [TileID.DemonAltar]);
        RecipeHelper.AddRecipe(ItemID.BoneCampfire, [(ItemID.BoneTorch, 45), (ItemID.Bone, 12)], [TileID.BoneWelder]);
        RecipeHelper.AddRecipe(ItemID.UltraBrightCampfire, [(ItemID.UltrabrightTorch, 45), (ItemID.DynastyWood, 12)],
                [TileID.WorkBenches]);
        RecipeHelper.AddRecipe(ItemID.DemonCampfire, [(ItemID.DemonTorch, 45), (ItemID.AshWood, 12)],
                [TileID.Hellforge]);
        RecipeHelper.AddRecipe(ItemID.ShimmerCampfire, [(ItemID.ShimmerTorch, 45), (ItemID.StoneBlock, 12)],
                [TileID.CookingPots]);
        RecipeHelper.AddRecipe(ItemID.RainbowCampfire, [(ItemID.RainbowTorch, 45), (ItemID.RainbowBrick, 12)],
                [TileID.MeatGrinder]);
        RecipeHelper.AddRecipe(ItemID.HallowedCampfire, [(ItemID.HallowedTorch, 45), (ItemID.Pearlwood, 12)],
                [TileID.MythrilAnvil]);

        RecipeHelper.AddRecipe(ItemID.HeartLantern, [(ItemID.LifeCrystal, 2), (ItemID.CagedLantern, 1)],
                [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.StarinaBottle, [(ItemID.ManaCrystal, 2), (ItemID.BottledHoney, 1)],
                [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.PeaceCandle, [
                (ItemID.PinkTorch, 1), (ItemID.WaterCandle, 1), (ItemID.CalmingPotion, 2),
                (ItemID.InvisibilityPotion, 1)
        ], [TileID.BoneWelder]);

        // can be gotten pre skele to make some grind easier
        RecipeHelper.AddRecipe(ItemID.WaterCandle,
                [(ItemID.BlueTorch, 1), (ItemID.Candle, 1), (ItemID.BattlePotion, 2)], [TileID.Sinks, TileID.Anvils]);
    }
}
