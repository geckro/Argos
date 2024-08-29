using Terraria;
using Terraria.ModLoader;
using static Terraria.ID.ItemID;
using static Terraria.RecipeGroup;

namespace Argos.Common;

using RG = RecipeGroup;

public class RecipeGroups : ModSystem
{
    public override void AddRecipeGroups()
    {
        RegisterGroup(nameof(AdamantiteBar), new RG(() => "Adamantite or Titanium Bar", AdamantiteBar, TitaniumBar));
        RegisterGroup(nameof(AdamantiteBreastplate),
                new RG(() => "Adamantite or Titanium Breastplate", AdamantiteBreastplate, TitaniumBreastplate));
        RegisterGroup(nameof(AdamantiteChainsaw),
                new RG(() => "Adamantite or Titanium Chainsaw", AdamantiteChainsaw, TitaniumChainsaw));
        RegisterGroup(nameof(AdamantiteDrill),
                new RG(() => "Adamantite or Titanium Drill", AdamantiteDrill, TitaniumDrill));
        RegisterGroup(nameof(AdamantiteGlaive),
                new RG(() => "Adamantite or Titanium Spear", AdamantiteGlaive, TitaniumTrident));
        RegisterGroup(nameof(AdamantiteHelmet),
                new RG(() => "Adamantite or Titanium Helmet", AdamantiteHelmet, TitaniumHelmet));
        RegisterGroup(nameof(AdamantiteLeggings),
                new RG(() => "Adamantite or Titanium Leggings", AdamantiteLeggings, TitaniumLeggings));
        RegisterGroup(nameof(AdamantiteOre), new RG(() => "Adamantite or Titanium Ore", AdamantiteOre, TitaniumOre));
        RegisterGroup(nameof(AdamantitePickaxe),
                new RG(() => "Adamantite or Titanium Pickaxe", AdamantitePickaxe, TitaniumPickaxe));
        RegisterGroup(nameof(AdamantiteRepeater),
                new RG(() => "Adamantite or Titanium Repeater", AdamantiteRepeater, TitaniumRepeater));
        RegisterGroup(nameof(AdamantiteSword),
                new RG(() => "Adamantite or Titanium Sword", AdamantiteSword, TitaniumSword));
        RegisterGroup(nameof(AdamantiteWaraxe),
                new RG(() => "Adamantite or Titanium Waraxe", AdamantiteWaraxe, TitaniumWaraxe));
        RegisterGroup(nameof(BeetleScaleMail), new RG(() => "Beetle Breastplate", BeetleScaleMail, BeetleShell));
        RegisterGroup(nameof(CobaltBar), new RG(() => "Cobalt or Palladium Bar", CobaltBar, PalladiumBar));
        RegisterGroup(nameof(CobaltChainsaw),
                new RG(() => "Cobalt or Palladium Chainsaw", CobaltChainsaw, PalladiumChainsaw));
        RegisterGroup(nameof(CobaltDrill), new RG(() => "Cobalt or Palladium Drill", CobaltDrill, PalladiumDrill));
        RegisterGroup(nameof(CobaltBreastplate),
                new RG(() => "Cobalt or Palladium Breastplate", CobaltBreastplate, PalladiumBreastplate));
        RegisterGroup(nameof(CobaltHelmet), new RG(() => "Cobalt or Palladium Helmet", CobaltHelmet, PalladiumHelmet));
        RegisterGroup(nameof(CobaltLeggings),
                new RG(() => "Cobalt or Palladium Leggings", CobaltLeggings, PalladiumLeggings));
        RegisterGroup(nameof(CobaltNaginata), new RG(() => "Cobalt or Palladium Spear", CobaltNaginata, PalladiumPike));
        RegisterGroup(nameof(CobaltOre), new RG(() => "Cobalt or Palladium Ore", CobaltOre, PalladiumOre));
        RegisterGroup(nameof(CobaltPickaxe),
                new RG(() => "Cobalt or Palladium Pickaxe", CobaltPickaxe, PalladiumPickaxe));
        RegisterGroup(nameof(CobaltRepeater),
                new RG(() => "Cobalt or Palladium Repeater", CobaltRepeater, PalladiumRepeater));
        RegisterGroup(nameof(CobaltSword), new RG(() => "Cobalt or Palladium Sword", CobaltSword, PalladiumSword));
        RegisterGroup(nameof(CobaltWaraxe), new RG(() => "Cobalt or Palladium Waraxe", CobaltWaraxe, PalladiumWaraxe));
        RegisterGroup(nameof(CopperAxe), new RG(() => "Copper or Tin Axe", CopperAxe, TinAxe));
        RegisterGroup(nameof(CopperBar), new RG(() => "Copper or Tin Bar", CopperBar, TinBar));
        RegisterGroup(nameof(CopperBow), new RG(() => "Copper or Tin Bow", CopperBow, TinBow));
        RegisterGroup(nameof(CopperBroadsword),
                new RG(() => "Copper or Tin Broadsword", CopperBroadsword, TinBroadsword));
        RegisterGroup(nameof(CopperChainmail), new RG(() => "Copper or Tin Chainmail", CopperChainmail, TinChainmail));
        RegisterGroup(nameof(CopperGreaves), new RG(() => "Copper or Tin Greaves", CopperGreaves, TinGreaves));
        RegisterGroup(nameof(CopperHammer), new RG(() => "Copper or Tin Hammer", CopperHammer, TinHammer));
        RegisterGroup(nameof(CopperHelmet), new RG(() => "Copper or Tin Helmet", CopperHelmet, TinHelmet));
        RegisterGroup(nameof(CopperOre), new RG(() => "Copper or Tin Ore", CopperOre, TinOre));
        RegisterGroup(nameof(CopperPickaxe), new RG(() => "Copper or Tin Pickaxe", CopperPickaxe, TinPickaxe));
        RegisterGroup(nameof(CopperShortsword),
                new RG(() => "Copper or Tin ShortSword", CopperShortsword, TinShortsword));
        RegisterGroup(nameof(DemonBow), new RG(() => "Evil Bow", DemonBow, TendonBow));
        RegisterGroup(nameof(DemoniteBar), new RG(() => "Evil Bar", DemoniteBar, CrimtaneBar));
        RegisterGroup(nameof(DemoniteOre), new RG(() => "Evil Ore", DemoniteOre, CrimtaneOre));
        RegisterGroup(nameof(GoldAxe), new RG(() => "Gold or Platinum Axe", GoldAxe, PlatinumAxe));
        RegisterGroup(nameof(GoldBar), new RG(() => "Gold or Platinum Bar", GoldBar, PlatinumBar));
        RegisterGroup(nameof(GoldBow), new RG(() => "Gold or Platinum Bow", GoldBow, PlatinumBow));
        RegisterGroup(nameof(GoldBroadsword),
                new RG(() => "Gold or Platinum Broadsword", GoldBroadsword, PlatinumBroadsword));
        RegisterGroup(nameof(GoldChainmail),
                new RG(() => "Gold or Platinum Chainmail", GoldChainmail, PlatinumChainmail));
        RegisterGroup(nameof(GoldGreaves), new RG(() => "Gold or Platinum Greaves", GoldGreaves, PlatinumGreaves));
        RegisterGroup(nameof(GoldHammer), new RG(() => "Gold or Platinum Hammer", GoldHammer, PlatinumHammer));
        RegisterGroup(nameof(GoldHelmet), new RG(() => "Gold or Platinum Helmet", GoldHelmet, PlatinumHelmet));
        RegisterGroup(nameof(GoldOre), new RG(() => "Gold or Platinum Ore", GoldOre, PlatinumOre));
        RegisterGroup(nameof(GoldPickaxe), new RG(() => "Gold or Platinum Pickaxe", GoldPickaxe, PlatinumPickaxe));
        RegisterGroup(nameof(GoldShortsword),
                new RG(() => "Gold or Platinum ShortSword", GoldShortsword, PlatinumShortsword));
        RegisterGroup(nameof(IronAnvil), new RG(() => "Iron or Lead Anvil", IronAnvil, LeadAnvil));
        RegisterGroup(nameof(IronAxe), new RG(() => "Iron or Lead Axe", IronAxe, LeadAxe));
        RegisterGroup(nameof(IronBow), new RG(() => "Iron or Lead Bow", IronBow, LeadBow));
        RegisterGroup(nameof(IronBroadsword), new RG(() => "Iron or Lead Broadsword", IronBroadsword, LeadBroadsword));
        RegisterGroup(nameof(IronChainmail), new RG(() => "Iron or Lead Chainmail", IronChainmail, LeadChainmail));
        RegisterGroup(nameof(IronGreaves), new RG(() => "Iron or Lead Greaves", IronGreaves, LeadGreaves));
        RegisterGroup(nameof(IronHammer), new RG(() => "Iron or Lead Hammer", IronHammer, LeadHammer));
        RegisterGroup(nameof(IronHelmet), new RG(() => "Iron or Lead Helmet", IronHelmet, LeadHelmet));
        RegisterGroup(nameof(IronOre), new RG(() => "Iron or Lead Ore", IronOre, LeadOre));
        RegisterGroup(nameof(IronPickaxe), new RG(() => "Iron or Lead Pickaxe", IronPickaxe, LeadPickaxe));
        RegisterGroup(nameof(IronShortsword), new RG(() => "Iron or Lead ShortSword", IronShortsword, LeadShortsword));
        RegisterGroup(nameof(LightsBane), new RG(() => "Evil Sword", LightsBane, BloodButcherer));
        RegisterGroup(nameof(MythrilAnvil), new RG(() => "Hardmode Anvils", MythrilAnvil, OrichalcumAnvil));
        RegisterGroup(nameof(MythrilBar), new RG(() => "Mythril or Orichalcum Bar", MythrilBar, OrichalcumBar));
        RegisterGroup(nameof(MythrilChainmail),
                new RG(() => "Mythril or Orichalcum Breastplate", MythrilChainmail, OrichalcumBreastplate));
        RegisterGroup(nameof(MythrilChainsaw),
                new RG(() => "Mythril or Orichalcum Chainsaw", MythrilChainsaw, OrichalcumChainsaw));
        RegisterGroup(nameof(MythrilDrill), new RG(() => "Mythril or Orichalcum Drill", MythrilDrill, OrichalcumDrill));
        RegisterGroup(nameof(MythrilGreaves),
                new RG(() => "Mythril or Orichalcum Leggings", MythrilGreaves, OrichalcumLeggings));
        RegisterGroup(nameof(MythrilHalberd),
                new RG(() => "Mythril or Orichalcum Spear", MythrilHalberd, OrichalcumHalberd));
        RegisterGroup(nameof(MythrilHelmet),
                new RG(() => "Mythril or Orichalcum Helmet", MythrilHelmet, OrichalcumHelmet));
        RegisterGroup(nameof(MythrilOre), new RG(() => "Mythril or Orichalcum Ore", MythrilOre, OrichalcumOre));
        RegisterGroup(nameof(MythrilPickaxe),
                new RG(() => "Mythril or Orichalcum Pickaxe", MythrilPickaxe, OrichalcumPickaxe));
        RegisterGroup(nameof(MythrilRepeater),
                new RG(() => "Mythril or Orichalcum Repeater", MythrilRepeater, OrichalcumRepeater));
        RegisterGroup(nameof(MythrilSword), new RG(() => "Mythril or Orichalcum Sword", MythrilSword, OrichalcumSword));
        RegisterGroup(nameof(MythrilWaraxe),
                new RG(() => "Mythril or Orichalcum Waraxe", MythrilWaraxe, OrichalcumWaraxe));
        RegisterGroup(nameof(NightmarePickaxe), new RG(() => "Evil Pickaxe", NightmarePickaxe, DeathbringerPickaxe));
        RegisterGroup(nameof(ShadowGreaves), new RG(() => "Evil Greaves", ShadowGreaves, CrimsonGreaves));
        RegisterGroup(nameof(ShadowHelmet), new RG(() => "Evil Helmet", ShadowHelmet, CrimsonHelmet));
        RegisterGroup(nameof(ShadowScale), new RG(() => "Evil Scale", ShadowScale, TissueSample));
        RegisterGroup(nameof(ShadowScalemail), new RG(() => "Evil Scalemail", ShadowScalemail, CrimsonScalemail));
        RegisterGroup(nameof(ShroomiteHelmet),
                new RG(() => "Shroomite Helmet", ShroomiteHelmet, ShroomiteHeadgear, ShroomiteMask));
        RegisterGroup(nameof(SilverAxe), new RG(() => "Silver or Tungsten Axe", SilverAxe, TungstenAxe));
        RegisterGroup(nameof(SilverBar), new RG(() => "Silver or Tungsten Bar", SilverBar, TungstenBar));
        RegisterGroup(nameof(SilverBow), new RG(() => "Silver or Tungsten Bow", SilverBow, TungstenBow));
        RegisterGroup(nameof(SilverBroadsword),
                new RG(() => "Silver or Tungsten Broadsword", SilverBroadsword, TungstenBroadsword));
        RegisterGroup(nameof(SilverChainmail),
                new RG(() => "Silver or Tungsten Chainmail", SilverChainmail, TungstenChainmail));
        RegisterGroup(nameof(SilverGreaves),
                new RG(() => "Silver or Tungsten Greaves", SilverGreaves, TungstenGreaves));
        RegisterGroup(nameof(SilverHammer), new RG(() => "Silver or Tungsten Hammer", SilverHammer, TungstenHammer));
        RegisterGroup(nameof(SilverHelmet), new RG(() => "Silver or Tungsten Helmet", SilverHelmet, TungstenHelmet));
        RegisterGroup(nameof(SilverOre), new RG(() => "Silver or Tungsten Ore", SilverOre, TungstenOre));
        RegisterGroup(nameof(SilverPickaxe),
                new RG(() => "Silver or Tungsten Pickaxe", SilverPickaxe, TungstenPickaxe));
        RegisterGroup(nameof(SilverShortsword),
                new RG(() => "Silver or Tungsten ShortSword", SilverShortsword, TungstenShortsword));
        RegisterGroup(nameof(SpectreMask), new RG(() => "Spectre Head", SpectreMask, SpectreHood));
        RegisterGroup(nameof(TheBreaker), new RG(() => "Evil Hammer", TheBreaker, FleshGrinder));
        RegisterGroup(nameof(WarAxeoftheNight), new RG(() => "Evil Axe", WarAxeoftheNight, BloodLustCluster));
        RegisterGroup(nameof(DoubleCod),
                new RG(() => "Most Buff Fish", ArmoredCavefish, ChaosFish, CrimsonTigerfish, Damselfish, DoubleCod,
                        Ebonkoi, FlarefinKoi, FrostMinnow, Hemopiranha, Obsidifish, PrincessFish, Prismite,
                        VariegatedLardfish));
        RegisterGroup(nameof(Bird), new RG(() => "Birds", Bird, Cardinal, BlueJay, Seagull, Penguin));
        RegisterGroup(nameof(GoldBunny),
                new RG(() => "Golden Critters", GoldBunny, GoldBird, GoldMouse, GoldGrasshopper, GoldWorm, GoldGoldfish,
                        GoldWaterStrider, GoldSeahorse, GoldButterfly, GoldLadyBug, GoldFrog, SquirrelGold,
                        GoldDragonfly));
        RegisterGroup(nameof(HermesBoots),
                new RG(() => "Speedy Boots", HermesBoots, FlurryBoots, SailfishBoots, SandBoots));
    }
}
