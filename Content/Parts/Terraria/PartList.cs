using Terraria;
using Terraria.ModLoader;

namespace Argos.Content.Parts.Terraria;

public abstract class PartItem : ModItem
{
    public override string Texture => "Argos/Content/Parts/Terraria/PartGeneric";

    public override void SetStaticDefaults()
    {
        Item.ResearchUnlockCount = 100;
    }

    public override void SetDefaults()
    {
        Item.width = 20;
        Item.height = 20;
        Item.maxStack = Item.CommonMaxStack;
        Item.value = Item.sellPrice(copper: 1);
    }
}

// ReSharper disable ClassNeverInstantiated.Global
public class AccAdhesiveBandage : PartItem;

public class AccAnglerEarring : PartItem;

public class AccArkhalisWings : PartItem;

public class AccArmorPolish : PartItem;

public class AccBalloonPufferfish : PartItem;

public class AccBezoar : PartItem;

public class AccBlackBelt : PartItem;

public class AccBlackCounterweight : PartItem;

public class AccBlindfold : PartItem;

public class AccBlueCounterweight : PartItem;

public class AccBrickLayer : PartItem;

public class AccCenxsWings : PartItem;

public class AccChromaticCloak : PartItem;

public class AccCompass : PartItem;

public class AccCrownosWings : PartItem;

public class AccDpsMeter : PartItem;

public class AccDTownsWings : PartItem;

public class AccDepthMeter : PartItem;

public class AccExtendoGrip : PartItem;

public class AccFastClock : PartItem;

public class AccFinWings : PartItem;

public class AccFishermansPocketGuide : PartItem;

public class AccFishingBobber : PartItem;

public class AccFoodBarbariansWings : PartItem;

public class AccFrogLeg : PartItem;

public class AccFrozenTurtleShell : PartItem;

public class AccGhostarsWings : PartItem;

public class AccGravityGlobe : PartItem;

public class AccGreenCounterweight : PartItem;

public class AccGroxTheGreatsWings : PartItem;

public class AccHandWarmer : PartItem;

public class AccHerculesBeetle : PartItem;

public class AccHighTestFishingLine : PartItem;

public class AccHivePack : PartItem;

public class AccHoneyComb : PartItem;

public class AccIceSkates : PartItem;

public class AccJellyfishNecklace : PartItem;

public class AccJetpack : PartItem;

public class AccJimsWings : PartItem;

public class AccLavaCharm : PartItem;

public class AccLavaproofFishingHook : PartItem;

public class AccLazuresWings : PartItem;

public class AccLeafWings : PartItem;

public class AccLeinforsWings : PartItem;

public class AccLifeformAnalyzer : PartItem;

public class AccLokisWings : PartItem;

public class AccMagicQuiver : PartItem;

public class AccMagmaStone : PartItem;

public class AccMechanicalLens : PartItem;

public class AccMechanicalRuler : PartItem;

public class AccMegaphone : PartItem;

public class AccMetalDetector : PartItem;

public class AccMoonCharm : PartItem;

public class AccMoonStone : PartItem;

public class AccNaturesGift : PartItem;

public class AccNazar : PartItem;

public class AccNeptunesShell : PartItem;

public class AccObsidianRose : PartItem;

public class AccPaintSprayer : PartItem;

public class AccPaladinsShield : PartItem;

public class AccPocketMirror : PartItem;

public class AccPortableCementMixer : PartItem;

public class AccPresserator : PartItem;

public class AccPurpleCounterweight : PartItem;

public class AccPygmyNecklace : PartItem;

public class AccRadioThing : PartItem;

public class AccRedCounterweight : PartItem;

public class AccRedsWings : PartItem;

public class AccRifleScope : PartItem;

public class AccRocketBoots : PartItem;

public class AccSafemansWings : PartItem;

public class AccSextant : PartItem;

public class AccShackle : PartItem;

public class AccSharkToothNecklace : PartItem;

public class AccShinyStone : PartItem;

public class AccSkiphsWings : PartItem;

public class AccSoaringInsignia : PartItem;

public class AccSpectreGoggles : PartItem;

public class AccSteampunkWings : PartItem;

public class AccStopwatch : PartItem;

public class AccTabi : PartItem;

public class AccTackleBox : PartItem;

public class AccTallyCounter : PartItem;

public class AccToolbelt : PartItem;

public class AccToolbox : PartItem;

public class AccTreasureMagnet : PartItem;

public class AccTrifoldMap : PartItem;

public class AccTsunamiInABottle : PartItem;

public class AccVanityAngelHalo : PartItem;

public class AccVanityBloodMoonMonolith : PartItem;

public class AccVanityCrimsonCape : PartItem;

public class AccVanityDiamondRing : PartItem;

public class AccVanityFakeUnicornHorn : PartItem;

public class AccVanityFlameWakerBoots : PartItem;

public class AccVanityGingerBeard : PartItem;

public class AccVanityGlassSlipper : PartItem;

public class AccVanityHunterCloak : PartItem;

public class AccVanityJungleRose : PartItem;

public class AccVanityMysteriousCape : PartItem;

public class AccVanityPrinceCape : PartItem;

public class AccVanityRedCape : PartItem;

public class AccVanityWinterCape : PartItem;

public class AccVitamins : PartItem;

public class AccVolatileGelatin : PartItem;

public class AccWaterWalkingBoots : PartItem;

public class AccWillsWings : PartItem;

public class AccYellowCounterweight : PartItem;

public class AccYoraizorsWings : PartItem;

public class AccYoyoGlove : PartItem;

public class ArmorAncientCobaltChest : PartItem;

public class ArmorAncientCobaltHead : PartItem;

public class ArmorAncientCobaltLegs : PartItem;

public class ArmorAncientShadowChest : PartItem;

public class ArmorAncientShadowHead : PartItem;

public class ArmorAncientShadowLegs : PartItem;

public class ArmorAnglerChest : PartItem;

public class ArmorAnglerHead : PartItem;

public class ArmorAnglerLegs : PartItem;

public class ArmorDivingHelmet : PartItem;

public class ArmorDjinnsCurse : PartItem;

public class ArmorGi : PartItem;

public class ArmorGladiatorChest : PartItem;

public class ArmorGladiatorHead : PartItem;

public class ArmorGladiatorLegs : PartItem;

public class ArmorGreenCap : PartItem;

public class ArmorMagicHat : PartItem;

public class ArmorMiningChest : PartItem;

public class ArmorMiningHead : PartItem;

public class ArmorMiningLegs : PartItem;

public class ArmorMoonLordLegs : PartItem;

public class ArmorMysticRobe : PartItem;

public class ArmorNightVisionHelmet : PartItem;

public class ArmorRainChest : PartItem;

public class ArmorRainHead : PartItem;

public class ArmorRainLegs : PartItem;

public class ArmorSnowChest : PartItem;

public class ArmorSnowHead : PartItem;

public class ArmorSnowLegs : PartItem;

public class ArmorTikiChest : PartItem;

public class ArmorTikiHead : PartItem;

public class ArmorTikiLegs : PartItem;

public class ArmorVanityBunnyHood : PartItem;

public class ArmorVikingHelmet : PartItem;

public class ArmorWizardHat : PartItem;

public class BlockWandLeafWand : PartItem;

public class BlockWandLivingWoodWand : PartItem;

public class BlockWandRichMahoganyLeafWand : PartItem;

public class BlockWandLivingMahoganyWand : PartItem;

public class BossSummonClothierVoodooDoll : PartItem;

public class BossSummonGuideVoodooDoll : PartItem;

public class CraftingStationAutohammer : PartItem;

public class CraftingStationBlendOMatic : PartItem;

public class CraftingStationDecayChamber : PartItem;

public class CraftingStationDyeVat : PartItem;

public class CraftingStationFleshCloningVat : PartItem;

public class CraftingStationSteampunkBoiler : PartItem;

public class HookSquirrel : PartItem;

public class KiteBlueJellyfish : PartItem;

public class KiteWanderingEye : PartItem;

public class MageBloodThorn : PartItem;

public class MageCrystalZapper : PartItem;

public class MageDemonScythe : PartItem;

public class MageFrostStaff : PartItem;

public class MageGrayZapinator : PartItem;

public class MageIceRod : PartItem;

public class MageInfernoFork : PartItem;

public class MageMagnetSphere : PartItem;

public class MageMedusaHead : PartItem;

public class MageNimbusRod : PartItem;

public class MageOrangeZapinator : PartItem;

public class MagePoisonStaff : PartItem;

public class MageRainbowGun : PartItem;

public class MageResonanceScepter : PartItem;

public class MageShadowbeamStaff : PartItem;

public class MageSpectreStaff : PartItem;

public class MageToxicFlask : PartItem;

public class MageUnholyTrident : PartItem;

public class MageWaterBolt : PartItem;

public class MeleeBoomerangBananarang : PartItem;

public class MeleeBoomerangBloodyMachete : PartItem;

public class MeleeBoomerangCombatWrench : PartItem;

public class MeleeBoomerangFruitcakeChakram : PartItem;

public class MeleeBoomerangIceBoomerang : PartItem;

public class MeleeBoomerangPaladinsHammer : PartItem;

public class MeleeBoomerangSergeantUnitedShield : PartItem;

public class MeleeBoomerangShroomerang : PartItem;

public class MeleeFlailAnchor : PartItem;

public class MeleeFlailChainKnife : PartItem;

public class MeleeFlailDripplerCrippler : PartItem;

public class MeleeFlailKOCannon : PartItem;

public class MeleeOtherJoustingLance : PartItem;

public class MeleeOtherScourgeOfTheCorruptor : PartItem;

public class MeleeOtherShadowJoustingLance : PartItem;

public class MeleeOtherVampireKnives : PartItem;

public class MeleeSpearMushroomSpearAndHammush : PartItem;

public class MeleeSpearObsidianSwordfish : PartItem;

public class MeleeSpearSwordfish : PartItem;

public class MeleeSwordArkhalis : PartItem;

public class MeleeSwordBatBat : PartItem;

public class MeleeSwordBeamSword : PartItem;

public class MeleeSwordBladedGlove : PartItem;

public class MeleeSwordBladetongue : PartItem;

public class MeleeSwordBoneSword : PartItem;

public class MeleeSwordBreathingReed : PartItem;

public class MeleeSwordClassyCane : PartItem;

public class MeleeSwordCutlass : PartItem;

public class MeleeSwordDeathSickle : PartItem;

public class MeleeSwordEnchantedSword : PartItem;

public class MeleeSwordExoticScimitar : PartItem;

public class MeleeSwordFalconBlade : PartItem;

public class MeleeSwordFetidBaghnakhs : PartItem;

public class MeleeSwordGladius : PartItem;

public class MeleeSwordHamBat : PartItem;

public class MeleeSwordIceSickle : PartItem;

public class MeleeSwordKatana : PartItem;

public class MeleeSwordKeybrand : PartItem;

public class MeleeSwordMandibleBlade : PartItem;

public class MeleeSwordPsychoKnife : PartItem;

public class MeleeSwordPurpleClubberfish : PartItem;

public class MeleeSwordRuler : PartItem;

public class MeleeSwordSickle : PartItem;

public class MeleeSwordSlapHand : PartItem;

public class MeleeSwordStarfury : PartItem;

public class MeleeSwordStylishScissors : PartItem;

public class MeleeSwordTentacleSpike : PartItem;

public class MeleeSwordTerragrim : PartItem;

public class MeleeSwordTragicUmbrella : PartItem;

public class MeleeSwordWafflesIron : PartItem;

public class MeleeSwordZombieArm : PartItem;

public class MeleeYoyoAmarok : PartItem;

public class MeleeYoyoCascade : PartItem;

public class MeleeYoyoCode1 : PartItem;

public class MeleeYoyoCode2 : PartItem;

public class MeleeYoyoFormatC : PartItem;

public class MeleeYoyoGradient : PartItem;

public class MeleeYoyoHelFire : PartItem;

public class MeleeYoyoKraken : PartItem;

public class MeleeYoyoRally : PartItem;

public class MeleeYoyoRedsThrow : PartItem;

public class MeleeYoyoValkyrieYoyo : PartItem;

public class MeleeYoyoYelets : PartItem;

public class MinecartBee : PartItem;

public class MinecartDemonicHellcart : PartItem;

public class MinecartDiggingMolecart : PartItem;

public class MinecartDutchman : PartItem;

public class MinecartLadybug : PartItem;

public class MinecartMinecarp : PartItem;

public class MinecartPigron : PartItem;

public class MinecartSteampunk : PartItem;

public class MinecartSunflower : PartItem;

public class MountAncientHorn : PartItem;

public class MountBlackStuddedSaddle : PartItem;

public class MountBlessedApple : PartItem;

public class MountBrainScrambler : PartItem;

public class MountDustyRawhideSaddle : PartItem;

public class MountFuzzyCarrot : PartItem;

public class MountGolfCartKeys : PartItem;

public class MountHardySaddle : PartItem;

public class MountLilithsNecklace : PartItem;

public class MountMolluskWhistle : PartItem;

public class MountPogoStick : PartItem;

public class MountReindeerBells : PartItem;

public class MountRoyalGildedSaddle : PartItem;

public class MountScalyTruffle : PartItem;

public class MountShrimpyTruffle : PartItem;

public class MountSuperheatedBlood : PartItem;

public class PetSpiffoPlush : PartItem;

public class RangedBowBloodRainBow : PartItem;

public class RangedBowMarrow : PartItem;

public class RangedBowPulseBow : PartItem;

public class RangedGunAleTosser : PartItem;

public class RangedGunBlowgun : PartItem;

public class RangedGunCelebration : PartItem;

public class RangedGunFlamethrower : PartItem;

public class RangedGunFlintlockPistol : PartItem;

public class RangedGunGatligator : PartItem;

public class RangedGunHarpoon : PartItem;

public class RangedGunMinishark : PartItem;

public class RangedGunNailGun : PartItem;

public class RangedGunPaintballGun : PartItem;

public class RangedGunPiranhaGun : PartItem;

public class RangedGunProximityMineLauncher : PartItem;

public class RangedGunQuadBarrelShotgun : PartItem;

public class RangedGunRedRyder : PartItem;

public class RangedGunRevolver : PartItem;

public class RangedGunRocketLauncher : PartItem;

public class RangedGunSandgun : PartItem;

public class RangedGunShotgun : PartItem;

public class RangedGunSniperRifle : PartItem;

public class RangedGunTacticalShotgun : PartItem;

public class RangedGunToxikarp : PartItem;

public class RangedGunUzi : PartItem;

public class SummonAbigailsFlower : PartItem;

public class SummonDeadlySphereStaff : PartItem;

public class SummonDesertTigerStaff : PartItem;

public class SummonFinchStaff : PartItem;

public class SummonSlimeStaff : PartItem;

public class SummonStaffOfTheFrostHydra : PartItem;

public class SummonTerraprisma : PartItem;

public class SummonVampireFrogStaff : PartItem;

public class SummonWhipLeatherWhip : PartItem;

public class SummonWhipMorningStar : PartItem;

public class SummonWhipSpinalTap : PartItem;

public class ToolBugNet : PartItem;

public class ToolClentaminator : PartItem;

public class ToolDirtRod : PartItem;

public class ToolPaintbrush : PartItem;

public class ToolPaintRoller : PartItem;

public class ToolPaintScraper : PartItem;

public class ToolPiggyBank : PartItem;

public class ToolSafe : PartItem;
// ReSharper restore ClassNeverInstantiated.Global
