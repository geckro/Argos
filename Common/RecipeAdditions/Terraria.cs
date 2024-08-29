using Argos.Content.Parts.Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Argos.Common.RecipeHelper;

namespace Argos.Common.RecipeAdditions;

public class TerrariaAdditions : GlobalItem
{
    public override void AddRecipes()
    {
        AddRecipe(ItemID.CreativeWings, [
                Ingredient(ItemID.Silk, 12), Ingredient(ItemID.Feather, 15), Ingredient(ItemID.Cloud, 50),
                Ingredient(ItemID.FeatherfallPotion, 5), Ingredient(ModContent.ItemType<SharedChestSkyIslands>())
        ], [TileID.SkyMill]);
        AddRecipe(ItemID.CelestialMagnet, [
                Ingredient(ItemID.ManaCrystal, 3),
                Ingredient(ItemID.RainCloud, 80),
                Ingredient(ItemID.MeteoriteBar, 8),
                Ingredient(ModContent.ItemType<SharedChestSkyIslands>())
        ], [TileID.SkyMill]);

        AddRecipe(ItemID.LuckyHorseshoe, [
                Ingredient(ItemID.PinkPearl), Ingredient(ItemID.WhitePearl, 2), Ingredient(ItemID.BlackPearl, 4),
                Ingredient(ModContent.ItemType<SharedChestSkyIslands>())
        ], [TileID.SkyMill], recipeGroups: [RecipeGroup("GoldBar", 14)]);

        AddRecipe(ItemID.ShinyRedBalloon, [
                Ingredient(ItemID.SkyBlueString), Ingredient(ItemID.SnowCloudBlock, 60), Ingredient(ItemID.RedDye, 2),
                Ingredient(ModContent.ItemType<SharedChestSkyIslands>())
        ], [TileID.SkyMill]);

        AddRecipe(ItemID.Bezoar, [
                Ingredient(ItemID.HornetBanner), Ingredient(ItemID.Vine, 8), Ingredient(ItemID.FlaskofPoison, 2),
                Ingredient(ItemID.BeeWax, 10),
                Ingredient(ItemID.JungleGrassSeeds, 8), Ingredient(ItemID.JungleSpores, 30),
                Ingredient(ModContent.ItemType<AccBezoar>())
        ], [TileID.ImbuingStation]);

        AddRecipe(ItemID.AdhesiveBandage, [
                Ingredient(ItemID.AnglerFishBanner), Ingredient(ItemID.SpiderFang, 12), Ingredient(ItemID.Spike, 100),
                Ingredient(ItemID.Silk, 15),
                Ingredient(ItemID.BrightOrangeDye),
                Ingredient(ModContent.ItemType<AccAdhesiveBandage>())
        ], [TileID.Loom]);

        AddRecipe(ItemID.Blindfold, [
                Ingredient(ItemID.BrightSilverDye), Ingredient(ItemID.DarkShard, 2), Ingredient(ItemID.BlackLens, 2),
                Ingredient(ItemID.Silk, 18),
                Ingredient(ModContent.ItemType<AccBlindfold>())
        ], [TileID.Loom]);

        AddRecipe(ItemID.Vitamins, [
                Ingredient(ItemID.BottledHoney, 5), Ingredient(ItemID.RegenerationPotion, 10),
                Ingredient(ItemID.LifeforcePotion, 10),
                Ingredient(ItemID.BandofRegeneration),
                Ingredient(ModContent.ItemType<AccVitamins>())
        ], [TileID.AlchemyTable]);

        AddRecipe(ItemID.ArmorPolish, [
                Ingredient(ItemID.Ectoplasm, 15), Ingredient(ItemID.LightShard, 3),
                Ingredient(ModContent.ItemType<AccArmorPolish>())
        ], [TileID.BoneWelder], recipeGroups: [RecipeGroup("AdamantiteBar", 16)]);

        AddRecipe(ItemID.Megaphone, [
                Ingredient(ItemID.ManaCrystal, 5), Ingredient(ItemID.RedDye, 2), Ingredient(ItemID.Wire, 50),
                Ingredient(ModContent.ItemType<AccMegaphone>())
        ], [TileID.MythrilAnvil], recipeGroups: [RecipeGroup("AdamantiteBar", 14)]);

        AddRecipe(ItemID.TrifoldMap, [
                Ingredient(ItemID.PirateMap), Ingredient(ItemID.CrimsandBlock, 100),
                Ingredient(ItemID.EbonsandBlock, 100),
                Ingredient(ItemID.PearlsandBlock, 100), Ingredient(ItemID.SandBlock, 100),
                Ingredient(ModContent.ItemType<AccTrifoldMap>())
        ], [TileID.Loom]);

        AddRecipe(ItemID.FastClock, [
                Ingredient(ItemID.GoldWatch), Ingredient(ItemID.PlatinumWatch), Ingredient(ItemID.PixieDust, 50),
                Ingredient(ItemID.SoulofFlight, 20), Ingredient(ModContent.ItemType<AccFastClock>())
        ], [TileID.MythrilAnvil]);

        AddRecipe(ItemID.PocketMirror, [
                Ingredient(ItemID.MagicMirror), Ingredient(ItemID.IceMirror), Ingredient(ItemID.Marble, 250),
                Ingredient(ItemID.SoulofLight, 12), Ingredient(ModContent.ItemType<AccPocketMirror>())
        ], [TileID.MythrilAnvil]);

        AddRecipe(ItemID.Nazar, [
                Ingredient(ItemID.BlackLens), Ingredient(ItemID.Bone, 100), Ingredient(ItemID.BlueDye, 3),
                Ingredient(ItemID.LargeSapphire), Ingredient(ModContent.ItemType<AccNazar>())
        ], [TileID.BoneWelder]);

        AddRecipe(ItemID.IceSkates, [
                Ingredient(ItemID.IceBlock, 400), Ingredient(ItemID.SnowBlock, 150), Ingredient(ItemID.FlinxFur, 8),
                Ingredient(ItemID.Silk, 16), Ingredient(ModContent.ItemType<AccIceSkates>())
        ], [TileID.IceMachine], recipeGroups: [RecipeGroup("SilverBar", 6)]);

        AddRecipe(ItemID.PortableStool, [
                Ingredient(ItemID.WoodenChair), Ingredient(ItemID.Wood, 80), Ingredient(ItemID.BuilderPotion, 2),
                Ingredient(ModContent.ItemType<SharedChestWooden>())
        ], [TileID.WorkBenches]);

        AddRecipe(ItemID.Radar, [
                Ingredient(ItemID.Emerald, 4), Ingredient(ItemID.Lens),
                Ingredient(ModContent.ItemType<SharedChestWooden>())
        ], [TileID.HeavyWorkBench], recipeGroups: [RecipeGroup("GoldBar", 8), RecipeGroup("CopperBar", 12)]);

        AddRecipe(ItemID.HermesBoots, [
                Ingredient(ItemID.Silk, 15), Ingredient(ItemID.SwiftnessPotion, 3), Ingredient(ItemID.Sunflower, 2),
                Ingredient(ModContent.ItemType<SharedChestGolden>()),
                Ingredient(ItemID.Feather, 4)
        ], [TileID.Anvils]);

        AddRecipe(ItemID.CloudinaBottle, [
                Ingredient(ItemID.BottledWater), Ingredient(ItemID.Cloud, 100), Ingredient(ItemID.RainCloud, 25),
                Ingredient(ModContent.ItemType<SharedChestGolden>())
        ], [TileID.Anvils]);

        AddRecipe(ItemID.BandofRegeneration, [
                Ingredient(ItemID.LifeCrystal), Ingredient(ItemID.RegenerationPotion, 3), Ingredient(ItemID.Ruby, 5),
                Ingredient(ModContent.ItemType<SharedChestGolden>())
        ], [TileID.Anvils]);

        AddRecipe(ItemID.MagicMirror, [
                Ingredient(ItemID.RecallPotion, 20), Ingredient(ItemID.Diamond, 3),
                Ingredient(ModContent.ItemType<SharedChestGolden>())
        ], [TileID.Anvils], recipeGroups: [RecipeGroup("GoldBar", 12)]);

        AddRecipe(ItemID.IceMirror, [
                Ingredient(ItemID.RecallPotion, 20), Ingredient(ItemID.Diamond), Ingredient(ItemID.IceBlock, 250),
                Ingredient(ModContent.ItemType<SharedChestIce>())
        ], [TileID.Anvils], recipeGroups: [RecipeGroup("GoldBar", 12)]);

        AddRecipe(ItemID.MiningHelmet,
                [Ingredient(ItemID.Torch, 100), Ingredient(ModContent.ItemType<ArmorMiningHead>())], [TileID.Anvils],
                recipeGroups: [RecipeGroup("GoldBar", 20)]);
        AddRecipe(ItemID.MiningShirt, [
                Ingredient(ItemID.MiningPotion, 3), Ingredient(ItemID.Silk, 20),
                Ingredient(ModContent.ItemType<ArmorMiningChest>())
        ], [TileID.Anvils]);
        AddRecipe(ItemID.MiningPants, [
                Ingredient(ItemID.MiningPotion, 3), Ingredient(ItemID.Silk, 15),
                Ingredient(ModContent.ItemType<ArmorMiningLegs>())
        ], [TileID.Anvils]);

        AddRecipe(ItemID.GladiatorHelmet, [
                Ingredient(ItemID.Marble, 100), Ingredient(ItemID.Chain, 25),
                Ingredient(ModContent.ItemType<ArmorGladiatorHead>())
        ]);
        AddRecipe(ItemID.GladiatorBreastplate, [
                Ingredient(ItemID.Marble, 180), Ingredient(ItemID.Chain, 30),
                Ingredient(ModContent.ItemType<ArmorGladiatorChest>())
        ], [TileID.Anvils]);
        AddRecipe(ItemID.GladiatorLeggings, [
                Ingredient(ItemID.Marble, 135), Ingredient(ItemID.Chain, 25),
                Ingredient(ModContent.ItemType<ArmorGladiatorLegs>())
        ], [TileID.Anvils]);

        AddRecipe(ItemID.RainHat, [
                Ingredient(ItemID.BottledWater, 50), Ingredient(ItemID.YellowDye, 2),
                Ingredient(ModContent.ItemType<ArmorRainHead>())
        ], [TileID.WorkBenches]);
        AddRecipe(ItemID.RainCoat, [
                Ingredient(ItemID.BottledWater, 50), Ingredient(ItemID.YellowDye, 2),
                Ingredient(ModContent.ItemType<ArmorRainChest>())
        ], [TileID.WorkBenches]);

        AddRecipe(ItemID.AnglerHat, [
                Ingredient(ItemID.Bass, 25), Ingredient(ItemID.Shrimp, 10),
                Ingredient(ModContent.ItemType<ArmorAnglerHead>())
        ], [TileID.Anvils]);
        AddRecipe(ItemID.AnglerVest, [
                Ingredient(ItemID.AtlanticCod, 20), Ingredient(ItemID.RockLobster, 15), Ingredient(ItemID.GoldenCarp),
                Ingredient(ModContent.ItemType<ArmorAnglerChest>())
        ], [TileID.Anvils]);
        AddRecipe(ItemID.AnglerPants, [
                Ingredient(ItemID.NeonTetra, 20), Ingredient(ItemID.Trout, 30), Ingredient(ItemID.Salmon, 10),
                Ingredient(ModContent.ItemType<ArmorAnglerLegs>())
        ], [TileID.Anvils]);

        AddRecipe(ItemID.GuideVoodooDoll, [
                Ingredient(ItemID.ClothierVoodooDoll), Ingredient(ItemID.Silk, 25), Ingredient(ItemID.HellstoneBar, 12),
                Ingredient(ModContent.ItemType<BossSummonGuideVoodooDoll>(), 3)
        ], [TileID.DemonAltar]);

        AddRecipe(ItemID.ClothierVoodooDoll, [
                Ingredient(ItemID.Silk, 25), Ingredient(ItemID.FamiliarWig), Ingredient(ItemID.FamiliarShirt),
                Ingredient(ItemID.FamiliarPants), Ingredient(ItemID.Bone, 50),
                Ingredient(ModContent.ItemType<BossSummonClothierVoodooDoll>(), 2)
        ], [TileID.DemonAltar, TileID.BoneWelder]);

        AddRecipe(ItemID.Starfury, [
                Ingredient(ItemID.FallenStar, 25), Ingredient(ItemID.PinkGel, 20),
                Ingredient(ModContent.ItemType<SharedChestSkyIslands>())
        ], [TileID.SkyMill], recipeGroups: [RecipeGroup("GoldBroadsword")]);

        AddRecipe(ItemID.Mace, [
                Ingredient(ItemID.RichMahogany, 12), Ingredient(ItemID.Chain, 9),
                Ingredient(ModContent.ItemType<SharedChestGolden>())
        ], [TileID.HeavyWorkBench], recipeGroups: [RecipeGroup("IronBar", 25)]);

        AddRecipe(ItemID.WoodenBoomerang, [
                Ingredient(ItemID.Wood, 24), Ingredient(ItemID.StoneBlock, 12),
                Ingredient(ModContent.ItemType<SharedChestWooden>())
        ], [TileID.WorkBenches], recipeGroups: [RecipeGroup("IronBar", 6)]);

        AddRecipe(ItemID.Spear, [Ingredient(ModContent.ItemType<SharedChestWooden>())], [TileID.Anvils],
                recipeGroups: [RecipeGroup("GoldBar", 8), RecipeGroup("SilverBar", 6)]);

        AddRecipe(ItemID.AntlionClaw, [
                Ingredient(ItemID.CactusSword), Ingredient(ItemID.Sandstone, 60), Ingredient(ItemID.Amber, 2),
                Ingredient(ModContent.ItemType<MeleeSwordMandibleBlade>(), 2)
        ], [TileID.Anvils]);

        AddRecipe(ItemID.IceBlade, [
                Ingredient(ItemID.IceBlock, 120), Ingredient(ItemID.Shiverthorn, 8),
                Ingredient(ModContent.ItemType<SharedChestIce>())
        ], recipeGroups: [RecipeGroup("GoldBroadsword")], tiles: [TileID.IceMachine]);

        AddRecipe(ItemID.IceBoomerang, [
                Ingredient(ItemID.IceBlock, 150), Ingredient(ItemID.Shiverthorn, 6), Ingredient(ItemID.FlinxFur, 4),
                Ingredient(ItemID.WoodenBoomerang), Ingredient(ModContent.ItemType<SharedChestIce>())
        ], [TileID.IceMachine]);

        AddRecipe(ItemID.SnowballCannon, [
                Ingredient(ItemID.Snowball, 500), Ingredient(ItemID.BorealWoodBow),
                Ingredient(ModContent.ItemType<SharedChestIce>())
        ], recipeGroups: [RecipeGroup("SilverBar", 12)], tiles: [TileID.IceMachine]);

        AddRecipe(ItemID.IceBow, [
                Ingredient(ItemID.MoltenFury), Ingredient(ItemID.FrostburnArrow, 750), Ingredient(ItemID.FrostCore),
                Ingredient(ModContent.ItemType<SharedMimicIce>())
        ], [TileID.IceMachine, TileID.MythrilAnvil]);

        AddRecipe(ItemID.Frostbrand, [
                Ingredient(ItemID.IceBlade), Ingredient(ItemID.FrostCore), Ingredient(ItemID.LivingFrostFireBlock, 100),
                Ingredient(ModContent.ItemType<SharedMimicIce>())
        ], [TileID.IceMachine, TileID.MythrilAnvil]);

        AddRecipe(ItemID.IceSickle, [
                Ingredient(ItemID.Sickle), Ingredient(ItemID.IceFeather), Ingredient(ItemID.IceElementalBanner),
                Ingredient(ModContent.ItemType<MeleeSwordIceSickle>())
        ], [TileID.IceMachine, TileID.MythrilAnvil]);

        AddRecipe(ItemID.FlowerofFrost, [
                Ingredient(ItemID.FlowerofFire), Ingredient(ItemID.PixieDust, 12), Ingredient(ItemID.FrostCore),
                Ingredient(ModContent.ItemType<SharedMimicIce>())
        ], [TileID.IceMachine, TileID.MythrilAnvil]);

        AddRecipe(ItemID.FlowerofFire, [
                Ingredient(ItemID.NaturesGift), Ingredient(ItemID.HellstoneBar, 16), Ingredient(ItemID.Fireblossom, 12),
                Ingredient(ModContent.ItemType<SharedChestShadowUnderworld>())
        ], [TileID.Hellforge]);

        AddRecipe(ItemID.DarkLance, [
                Ingredient(ItemID.ThunderSpear), Ingredient(ItemID.AshWood, 120), Ingredient(ItemID.Obsidian, 45),
                Ingredient(ModContent.ItemType<SharedChestShadowUnderworld>())
        ], [TileID.Hellforge, TileID.DemonAltar]);

        AddRecipe(ItemID.Flamelash, [
                Ingredient(ItemID.MagicMissile), Ingredient(ItemID.HellstoneBar, 16),
                Ingredient(ItemID.LavaSlimeBanner), Ingredient(ModContent.ItemType<SharedChestShadowUnderworld>())
        ], [TileID.Hellforge]);

        AddRecipe(ItemID.HellwingBow, [
                Ingredient(ItemID.MoltenFury), Ingredient(ItemID.LavaBucket, 8), Ingredient(ItemID.HellbatBanner),
                Ingredient(ModContent.ItemType<SharedChestShadowUnderworld>())
        ], [TileID.Hellforge]);

        AddRecipe(ItemID.Sunfury, [
                Ingredient(ItemID.FlamingMace), Ingredient(ItemID.HellstoneBar, 12), Ingredient(ItemID.Sunflower, 12),
                Ingredient(ItemID.ObsidianRose),
                Ingredient(ModContent.ItemType<SharedChestShadowUnderworld>())
        ], [TileID.Hellforge, TileID.SkyMill]);

        AddRecipe(ItemID.DemonScythe, [
                        Ingredient(ItemID.Book), Ingredient(ItemID.DemonBanner),
                        Ingredient(ModContent.ItemType<MageDemonScythe>())
                ], recipeGroups: [RecipeGroup("DemoniteBar", 16), RecipeGroup("ShadowScale", 12)],
                tiles: [TileID.Hellforge, TileID.Bookcases]);

        AddRecipe(ItemID.Cascade, [
                Ingredient(ItemID.Rally), Ingredient(ItemID.HellstoneBar, 18), Ingredient(ItemID.FlaskofFire),
                Ingredient(ItemID.Bone, 35),
                Ingredient(ModContent.ItemType<MeleeYoyoCascade>())
        ], [TileID.Hellforge]);

        AddRecipe(ItemID.HelFire, [
                Ingredient(ItemID.Cascade), Ingredient(ItemID.LivingFireBlock, 150),
                Ingredient(ModContent.ItemType<MeleeYoyoHelFire>())
        ], [TileID.Hellforge, TileID.CrystalBall]);

        AddRecipe(ItemID.Amarok, [
                Ingredient(ItemID.Valor), Ingredient(ItemID.LivingFrostFireBlock, 150), Ingredient(ItemID.FrostCore),
                Ingredient(ModContent.ItemType<MeleeYoyoAmarok>())
        ], [TileID.IceMachine, TileID.CrystalBall]);

        AddRecipe(ItemID.Yelets, [
                Ingredient(ItemID.HiveFive), Ingredient(ItemID.ButterflyDust, 2), Ingredient(ItemID.TatteredBeeWing, 2),
                Ingredient(ItemID.TurtleShell),
                Ingredient(ModContent.ItemType<MeleeYoyoYelets>())
        ], [TileID.MythrilAnvil]);

        AddRecipe(ItemID.Terrarian, [
                Ingredient(ItemID.LunarBar, 20), Ingredient(ItemID.TheEyeOfCthulhu), Ingredient(ItemID.Kraken),
                Ingredient(ItemID.FragmentSolar, 15),
                Ingredient(ModContent.ItemType<SharedMoonLord>())
        ], [TileID.LunarCraftingStation]);
    }
}
