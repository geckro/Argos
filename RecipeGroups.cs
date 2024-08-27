using Terraria;
using Terraria.ModLoader;
using static Terraria.ID.ItemID;
using static Terraria.RecipeGroup;

namespace Argos;

using RG = RecipeGroup;

public class RecipeGroups : ModSystem
{
    public override void AddRecipeGroups()
    {
        RegisterGroup(nameof(AdamantiteBar),
                new RG(() => "Any Adamantite or Titanium Bars", AdamantiteBar, TitaniumBar));
        RegisterGroup(nameof(AdamantiteBreastplate),
                new RG(() => "Any Adamantite or Titanium Breastplate", AdamantiteBreastplate, TitaniumBreastplate));
        RegisterGroup(nameof(AdamantiteHelmet),
                new RG(() => "Any Adamantite or Titanium Helmet", AdamantiteHelmet, TitaniumHelmet));
        RegisterGroup(nameof(AdamantiteLeggings),
                new RG(() => "Any Adamantite or Titanium Leggings", AdamantiteLeggings, TitaniumLeggings));
        RegisterGroup(nameof(AdamantiteOre),
                new RG(() => "Any Adamantite or Titanium Ores", AdamantiteOre, TitaniumOre));
        RegisterGroup(nameof(AdamantitePickaxe),
                new RG(() => "Any Adamantite or Titanium Pickaxes", AdamantitePickaxe, TitaniumPickaxe));
        RegisterGroup(nameof(AdamantiteRepeater),
                new RG(() => "Any Adamantite or Titanium Repeaters", AdamantiteRepeater, TitaniumRepeater));
        RegisterGroup(nameof(AdamantiteSword),
                new RG(() => "Any Adamantite or Titanium Swords", AdamantiteSword, TitaniumSword));
        RegisterGroup(nameof(AdamantiteWaraxe),
                new RG(() => "Any Adamantite or Titanium Waraxes", AdamantiteWaraxe, TitaniumWaraxe));
        RegisterGroup(nameof(BeetleScaleMail), new RG(() => "Any Beetle Breastplate", BeetleScaleMail, BeetleShell));
        RegisterGroup(nameof(CobaltBar), new RG(() => "Any Cobalt or Palladium Bars", CobaltBar, PalladiumBar));
        RegisterGroup(nameof(CobaltBreastplate),
                new RG(() => "Any Cobalt or Palladium Breastplate", CobaltBreastplate, PalladiumBreastplate));
        RegisterGroup(nameof(CobaltHelmet),
                new RG(() => "Any Cobalt or Palladium Helmet", CobaltHelmet, PalladiumHelmet));
        RegisterGroup(nameof(CobaltLeggings),
                new RG(() => "Any Cobalt or Palladium Leggings", CobaltLeggings, PalladiumLeggings));
        RegisterGroup(nameof(CobaltOre), new RG(() => "Any Cobalt or Palladium Ores", CobaltOre, PalladiumOre));
        RegisterGroup(nameof(CobaltPickaxe),
                new RG(() => "Any Cobalt or Palladium Pickaxes", CobaltPickaxe, PalladiumPickaxe));
        RegisterGroup(nameof(CobaltRepeater),
                new RG(() => "Any Cobalt or Palladium Repeaters", CobaltRepeater, PalladiumRepeater));
        RegisterGroup(nameof(CobaltSword), new RG(() => "Any Cobalt or Palladium Swords", CobaltSword, PalladiumSword));
        RegisterGroup(nameof(CobaltWaraxe),
                new RG(() => "Any Cobalt or Palladium Waraxes", CobaltWaraxe, PalladiumWaraxe));
        RegisterGroup(nameof(CopperAxe), new RG(() => "Any Copper or Tin Axes", CopperAxe, TinAxe));
        RegisterGroup(nameof(CopperBar), new RG(() => "Any Copper or Tin Bars", CopperBar, TinBar));
        RegisterGroup(nameof(CopperBow), new RG(() => "Any Copper or Tin Bows", CopperBow, TinBow));
        RegisterGroup(nameof(CopperBroadsword),
                new RG(() => "Any Copper or Tin Broadswords", CopperBroadsword, TinBroadsword));
        RegisterGroup(nameof(CopperChainmail),
                new RG(() => "Any Copper or Tin Chainmail", CopperChainmail, TinChainmail));
        RegisterGroup(nameof(CopperGreaves), new RG(() => "Any Copper or Tin Greaves", CopperGreaves, TinGreaves));
        RegisterGroup(nameof(CopperHammer), new RG(() => "Any Copper or Tin Hammers", CopperHammer, TinHammer));
        RegisterGroup(nameof(CopperHelmet), new RG(() => "Any Copper or Tin Helmet", CopperHelmet, TinHelmet));
        RegisterGroup(nameof(CopperOre), new RG(() => "Any Copper or Tin Ores", CopperOre, TinOre));
        RegisterGroup(nameof(CopperPickaxe), new RG(() => "Any Copper or Tin Pickaxes", CopperPickaxe, TinPickaxe));
        RegisterGroup(nameof(CopperShortsword),
                new RG(() => "Any Copper or Tin Shortswords", CopperShortsword, TinShortsword));
        RegisterGroup(nameof(DemonBow), new RG(() => "Any Evil Bow", DemonBow, TendonBow));
        RegisterGroup(nameof(DemoniteBar), new RG(() => "Any Evil Bars", DemoniteBar, CrimtaneBar));
        RegisterGroup(nameof(DemoniteOre), new RG(() => "Any Evil Ores", DemoniteOre, CrimtaneOre));
        RegisterGroup(nameof(GoldAxe), new RG(() => "Any Gold or Platinum Axes", GoldAxe, PlatinumAxe));
        RegisterGroup(nameof(GoldBar), new RG(() => "Any Gold or Platinum Bars", GoldBar, PlatinumBar));
        RegisterGroup(nameof(GoldBow), new RG(() => "Any Gold or Platinum Bows", GoldBow, PlatinumBow));
        RegisterGroup(nameof(GoldBroadsword),
                new RG(() => "Any Gold or Platinum Broadswords", GoldBroadsword, PlatinumBroadsword));
        RegisterGroup(nameof(GoldChainmail),
                new RG(() => "Any Gold or Platinum Chainmail", GoldChainmail, PlatinumChainmail));
        RegisterGroup(nameof(GoldGreaves), new RG(() => "Any Gold or Platinum Greaves", GoldGreaves, PlatinumGreaves));
        RegisterGroup(nameof(GoldHammer), new RG(() => "Any Gold or Platinum Hammers", GoldHammer, PlatinumHammer));
        RegisterGroup(nameof(GoldHelmet), new RG(() => "Any Gold or Platinum Helmet", GoldHelmet, PlatinumHelmet));
        RegisterGroup(nameof(GoldOre), new RG(() => "Any Gold or Platinum Ores", GoldOre, PlatinumOre));
        RegisterGroup(nameof(GoldPickaxe), new RG(() => "Any Gold or Platinum Pickaxes", GoldPickaxe, PlatinumPickaxe));
        RegisterGroup(nameof(GoldShortsword),
                new RG(() => "Any Gold or Platinum Shortswords", GoldShortsword, PlatinumShortsword));
        RegisterGroup(nameof(IronAnvil), new RG(() => "Iron or Lead Anvil", IronAnvil, LeadAnvil));
        RegisterGroup(nameof(IronAxe), new RG(() => "Any Iron or Lead Axes", IronAxe, LeadAxe));
        RegisterGroup(nameof(IronBow), new RG(() => "Any Iron or Lead Bows", IronBow, LeadBow));
        RegisterGroup(nameof(IronBroadsword),
                new RG(() => "Any Iron or Lead Broadswords", IronBroadsword, LeadBroadsword));
        RegisterGroup(nameof(IronChainmail), new RG(() => "Any Iron or Lead Chainmail", IronChainmail, LeadChainmail));
        RegisterGroup(nameof(IronGreaves), new RG(() => "Any Iron or Lead Greaves", IronGreaves, LeadGreaves));
        RegisterGroup(nameof(IronHammer), new RG(() => "Any Iron or Lead Hammers", IronHammer, LeadHammer));
        RegisterGroup(nameof(IronHelmet), new RG(() => "Any Iron or Lead Helmet", IronHelmet, LeadHelmet));
        RegisterGroup(nameof(IronOre), new RG(() => "Any Iron or Lead Ores", IronOre, LeadOre));
        RegisterGroup(nameof(IronPickaxe), new RG(() => "Any Iron or Lead Pickaxes", IronPickaxe, LeadPickaxe));
        RegisterGroup(nameof(IronShortsword),
                new RG(() => "Any Iron or Lead Shortswords", IronShortsword, LeadShortsword));
        RegisterGroup(nameof(LightsBane), new RG(() => "Any Evil Swords", LightsBane, BloodButcherer));
        RegisterGroup(nameof(MythrilAnvil), new RG(() => "Any Hardmode Anvils", MythrilAnvil, OrichalcumAnvil));
        RegisterGroup(nameof(MythrilBar), new RG(() => "Any Mythril or Orichalcum Bars", MythrilBar, OrichalcumBar));
        RegisterGroup(nameof(MythrilChainmail),
                new RG(() => "Any Mythril or Orichalcum Breastplate", MythrilChainmail, OrichalcumBreastplate));
        RegisterGroup(nameof(MythrilGreaves),
                new RG(() => "Any Mythril or Orichalcum Leggings", MythrilGreaves, OrichalcumLeggings));
        RegisterGroup(nameof(MythrilHelmet),
                new RG(() => "Any Mythril or Orichalcum Helmet", MythrilHelmet, OrichalcumHelmet));
        RegisterGroup(nameof(MythrilOre), new RG(() => "Any Mythril or Orichalcum Ores", MythrilOre, OrichalcumOre));
        RegisterGroup(nameof(MythrilPickaxe),
                new RG(() => "Any Mythril or Orichalcum Pickaxes", MythrilPickaxe, OrichalcumPickaxe));
        RegisterGroup(nameof(MythrilRepeater),
                new RG(() => "Any Mythril or Orichalcum Repeaters", MythrilRepeater, OrichalcumRepeater));
        RegisterGroup(nameof(MythrilSword),
                new RG(() => "Any Mythril or Orichalcum Swords", MythrilSword, OrichalcumSword));
        RegisterGroup(nameof(MythrilWaraxe),
                new RG(() => "Any Mythril or Orichalcum Waraxes", MythrilWaraxe, OrichalcumWaraxe));
        RegisterGroup(nameof(NightmarePickaxe),
                new RG(() => "Any Evil Pickaxes", NightmarePickaxe, DeathbringerPickaxe));
        RegisterGroup(nameof(ShadowGreaves), new RG(() => "Any Evil Greaves", ShadowGreaves, CrimsonGreaves));
        RegisterGroup(nameof(ShadowHelmet), new RG(() => "Any Evil Helmet", ShadowHelmet, CrimsonHelmet));
        RegisterGroup(nameof(ShadowScale), new RG(() => "Any Evil Scale", ShadowScale, TissueSample));
        RegisterGroup(nameof(ShadowScalemail), new RG(() => "Any Evil Scalemail", ShadowScalemail, CrimsonScalemail));
        RegisterGroup(nameof(ShroomiteHelmet),
                new RG(() => "Any Shroomite Helmet", ShroomiteHelmet, ShroomiteHeadgear, ShroomiteMask));
        RegisterGroup(nameof(SilverAxe), new RG(() => "Any Silver or Tungsten Axes", SilverAxe, TungstenAxe));
        RegisterGroup(nameof(SilverBar), new RG(() => "Any Silver or Tungsten Bars", SilverBar, TungstenBar));
        RegisterGroup(nameof(SilverBow), new RG(() => "Any Silver or Tungsten Bows", SilverBow, TungstenBow));
        RegisterGroup(nameof(SilverBroadsword),
                new RG(() => "Any Silver or Tungsten Broadswords", SilverBroadsword, TungstenBroadsword));
        RegisterGroup(nameof(SilverChainmail),
                new RG(() => "Any Silver or Tungsten Chainmail", SilverChainmail, TungstenChainmail));
        RegisterGroup(nameof(SilverGreaves),
                new RG(() => "Any Silver or Tungsten Greaves", SilverGreaves, TungstenGreaves));
        RegisterGroup(nameof(SilverHammer),
                new RG(() => "Any Silver or Tungsten Hammers", SilverHammer, TungstenHammer));
        RegisterGroup(nameof(SilverHelmet),
                new RG(() => "Any Silver or Tungsten Helmet", SilverHelmet, TungstenHelmet));
        RegisterGroup(nameof(SilverOre), new RG(() => "Any Silver or Tungsten Ores", SilverOre, TungstenOre));
        RegisterGroup(nameof(SilverPickaxe),
                new RG(() => "Any Silver or Tungsten Pickaxes", SilverPickaxe, TungstenPickaxe));
        RegisterGroup(nameof(SilverShortsword),
                new RG(() => "Any Silver or Tungsten Shortswords", SilverShortsword, TungstenShortsword));
        RegisterGroup(nameof(SpectreMask), new RG(() => "Any Spectre Head", SpectreMask, SpectreHood));
        RegisterGroup(nameof(TheBreaker), new RG(() => "Any Evil Hammers", TheBreaker, FleshGrinder));
        RegisterGroup(nameof(WarAxeoftheNight), new RG(() => "Any Evil Axes", WarAxeoftheNight, BloodLustCluster));
    }
}
