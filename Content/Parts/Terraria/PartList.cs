﻿using Terraria;
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

public class AccAglet : PartItem;

public class AccAncientChisel : PartItem;

public class AccAnglerEarring : PartItem;

public class AccAnkletOfTheWind : PartItem;

public class AccApprenticesScarf : PartItem;

public class AccArkhalisWings : PartItem;

public class AccArmorPolish : PartItem;

public class AccBalloonPufferfish : PartItem;

public class AccBandOfRegen : PartItem;

public class AccBetsysWings : PartItem;

public class AccBezoar : PartItem;

public class AccBlackBelt : PartItem;

public class AccBlackCounterweight : PartItem;

public class AccBlindfold : PartItem;

public class AccBlizzardInABottle : PartItem;

public class AccBlueCounterweight : PartItem;

public class AccBoneGlove : PartItem;

public class AccBoneHelm : PartItem;

public class AccBrainOfConfusion : PartItem;

public class AccBrickLayer : PartItem;

public class AccCelestialMagnet : PartItem;

public class AccCelestialStarboard : PartItem;

public class AccCenxsWings : PartItem;

public class AccChromaticCloak : PartItem;

public class AccClimbingClaws : PartItem;

public class AccCloudInABottle : PartItem;

public class AccCobaltShield : PartItem;

public class AccCompass : PartItem;

public class AccCrossNecklace : PartItem;

public class AccCrownosWings : PartItem;

public class AccDPSMeter : PartItem;

public class AccDTownsWings : PartItem;

public class AccDepthMeter : PartItem;

public class AccDuneriderBoots : PartItem;

public class AccEmpressWings : PartItem;

public class AccExtendoGrip : PartItem;

public class AccEyeOfTheGolem : PartItem;

public class AccFastClock : PartItem;

public class AccFeralClaws : PartItem;

public class AccFestiveWings : PartItem;

public class AccFinWings : PartItem;

public class AccFishermansPocketGuide : PartItem;

public class AccFishingBobber : PartItem;

public class AccFishronWings : PartItem;

public class AccFledglingWings : PartItem;

public class AccFleshKnuckles : PartItem;

public class AccFlipper : PartItem;

public class AccFlowerBoots : PartItem;

public class AccFlurryBoots : PartItem;

public class AccFlyingCarpet : PartItem;

public class AccFoodBarbariansWings : PartItem;

public class AccFrogLeg : PartItem;

public class AccFrozenTurtleShell : PartItem;

public class AccGhostarsWings : PartItem;

public class AccGravityGlobe : PartItem;

public class AccGreenCounterweight : PartItem;

public class AccGroxTheGreatsWings : PartItem;

public class AccGuideToPlantFiberCordage : PartItem;

public class AccHandWarmer : PartItem;

public class AccHerculesBeetle : PartItem;

public class AccHermesBoots : PartItem;

public class AccHighTestFishingLine : PartItem;

public class AccHivePack : PartItem;

public class AccHoneyComb : PartItem;

public class AccHuntressBuckler : PartItem;

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

public class AccLuckyHorseshoe : PartItem;

public class AccMageEmblem : PartItem;

public class AccMagicQuiver : PartItem;

public class AccMagmaStone : PartItem;

public class AccMechanicalLens : PartItem;

public class AccMechanicalRuler : PartItem;

public class AccMegaphone : PartItem;

public class AccMetalDetector : PartItem;

public class AccMonksBelt : PartItem;

public class AccMoonCharm : PartItem;

public class AccMoonStone : PartItem;

public class AccMothronWings : PartItem;

public class AccNaturesGift : PartItem;

public class AccNazar : PartItem;

public class AccNecromanticScroll : PartItem;

public class AccNeptunesShell : PartItem;

public class AccObsidianRose : PartItem;

public class AccPaintSprayer : PartItem;

public class AccPaladinsShield : PartItem;

public class AccPanicNecklace : PartItem;

public class AccPhilosophersStone : PartItem;

public class AccPocketMirror : PartItem;

public class AccPortableCementMixer : PartItem;

public class AccPresserator : PartItem;

public class AccPurpleCounterweight : PartItem;

public class AccPutridScent : PartItem;

public class AccPygmyNecklace : PartItem;

public class AccRadar : PartItem;

public class AccRadioThing : PartItem;

public class AccRangedEmblem : PartItem;

public class AccRedCounterweight : PartItem;

public class AccRedsWings : PartItem;

public class AccRifleScope : PartItem;

public class AccRocketBoots : PartItem;

public class AccRoyalGel : PartItem;

public class AccSafemansWings : PartItem;

public class AccSandstormInABottle : PartItem;

public class AccSextant : PartItem;

public class AccShackle : PartItem;

public class AccSharkToothNecklace : PartItem;

public class AccShieldOfCthulhu : PartItem;

public class AccShinyRedBalloon : PartItem;

public class AccShinyStone : PartItem;

public class AccShoeSpikes : PartItem;

public class AccSkiphsWings : PartItem;

public class AccSoaringInsignia : PartItem;

public class AccSpectreGoggles : PartItem;

public class AccSporeSac : PartItem;

public class AccSquiresShield : PartItem;

public class AccStarCloak : PartItem;

public class AccSteampunkWings : PartItem;

public class AccStepStool : PartItem;

public class AccStopwatch : PartItem;

public class AccSummonerEmblem : PartItem;

public class AccSunStone : PartItem;

public class AccTabi : PartItem;

public class AccTackleBox : PartItem;

public class AccTallyCounter : PartItem;

public class AccTitanGlove : PartItem;

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

public class AccVanityRainbowCursor : PartItem;

public class AccVanityRedCape : PartItem;

public class AccVanityWinterCape : PartItem;

public class AccVitamins : PartItem;

public class AccVolatileGelatin : PartItem;

public class AccWarriorEmblem : PartItem;

public class AccWaterWalkingBoots : PartItem;

public class AccWeatherRadio : PartItem;

public class AccWillsWings : PartItem;

public class AccWormScarf : PartItem;

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

public class ArmorCrystalAssassinChest : PartItem;

public class ArmorCrystalAssassinHead : PartItem;

public class ArmorCrystalAssassinLegs : PartItem;

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

public class ArmorNinjaChest : PartItem;

public class ArmorNinjaHead : PartItem;

public class ArmorNinjaLegs : PartItem;

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

public class MageAquaScepter : PartItem;

public class MageBatScepter : PartItem;

public class MageBeeGun : PartItem;

public class MageBetsysWrath : PartItem;

public class MageBlizzardStaff : PartItem;

public class MageBloodThorn : PartItem;

public class MageBookOfSkulls : PartItem;

public class MageBubbleGun : PartItem;

public class MageChargedBlasterCannon : PartItem;

public class MageClingerStaff : PartItem;

public class MageCrimsonRod : PartItem;

public class MageCrystalVileShard : PartItem;

public class MageCrystalZapper : PartItem;

public class MageDemonScythe : PartItem;

public class MageFlamelash : PartItem;

public class MageFlowerOfFire : PartItem;

public class MageFrostStaff : PartItem;

public class MageGrayZapinator : PartItem;

public class MageHeatRay : PartItem;

public class MageIceRod : PartItem;

public class MageInfernoFork : PartItem;

public class MageLaserMachinegun : PartItem;

public class MageLaserRifle : PartItem;

public class MageLastPrism : PartItem;

public class MageLeafBlower : PartItem;

public class MageLifeDrain : PartItem;

public class MageLunarFlare : PartItem;

public class MageMagicDagger : PartItem;

public class MageMagicMissile : PartItem;

public class MageMagnetSphere : PartItem;

public class MageMedusaHead : PartItem;

public class MageNettleBurst : PartItem;

public class MageNightglow : PartItem;

public class MageNimbusRod : PartItem;

public class MageOrangeZapinator : PartItem;

public class MagePoisonStaff : PartItem;

public class MageRainbowGun : PartItem;

public class MageRazorbladeTyphoon : PartItem;

public class MageRazorpine : PartItem;

public class MageResonanceScepter : PartItem;

public class MageShadowbeamStaff : PartItem;

public class MageShadowflameHexDoll : PartItem;

public class MageSpectreStaff : PartItem;

public class MageStaffOfEarth : PartItem;

public class MageStellarTune : PartItem;

public class MageThunderZapper : PartItem;

public class MageTomeOfInfiniteWisdom : PartItem;

public class MageToxicFlask : PartItem;

public class MageUnholyTrident : PartItem;

public class MageVilethorn : PartItem;

public class MageWandOfSparking : PartItem;

public class MageWaspGun : PartItem;

public class MageWaterBolt : PartItem;

public class MageWeatherPain : PartItem;

public class MeleeBoomerangBananarang : PartItem;

public class MeleeBoomerangBloodyMachete : PartItem;

public class MeleeBoomerangCombatWrench : PartItem;

public class MeleeBoomerangFlyingKnife : PartItem;

public class MeleeBoomerangFruitcakeChakram : PartItem;

public class MeleeBoomerangIceBoomerang : PartItem;

public class MeleeBoomerangPaladinsHammer : PartItem;

public class MeleeBoomerangPossessedHatchet : PartItem;

public class MeleeBoomerangSergeantUnitedShield : PartItem;

public class MeleeBoomerangShroomerang : PartItem;

public class MeleeBoomerangWoodenBoomerang : PartItem;

public class MeleeFlailAnchor : PartItem;

public class MeleeFlailBallOHurt : PartItem;

public class MeleeFlailBlueMoon : PartItem;

public class MeleeFlailChainGuillotines : PartItem;

public class MeleeFlailChainKnife : PartItem;

public class MeleeFlailDripplerCrippler : PartItem;

public class MeleeFlailFlairon : PartItem;

public class MeleeFlailFlowerPow : PartItem;

public class MeleeFlailGolemFist : PartItem;

public class MeleeFlailKOCannon : PartItem;

public class MeleeFlailMace : PartItem;

public class MeleeFlailSunfury : PartItem;

public class MeleeOtherJoustingLance : PartItem;

public class MeleeOtherScourgeOfTheCorruptor : PartItem;

public class MeleeOtherShadowJoustingLance : PartItem;

public class MeleeOtherShadowflameKnofe : PartItem;

public class MeleeOtherSkyDragonsFury : PartItem;

public class MeleeOtherSleepyOctopod : PartItem;

public class MeleeOtherStarlight : PartItem;

public class MeleeOtherVampireKnives : PartItem;

public class MeleeSpearDarkLance : PartItem;

public class MeleeSpearMushroomSpearAndHammush : PartItem;

public class MeleeSpearNorthPole : PartItem;

public class MeleeSpearObsidianSwordfish : PartItem;

public class MeleeSpearRottedFork : PartItem;

public class MeleeSpearSpear : PartItem;

public class MeleeSpearStormSpear : PartItem;

public class MeleeSpearSwordfish : PartItem;

public class MeleeSpearTrident : PartItem;

public class MeleeSwordArkhalis : PartItem;

public class MeleeSwordBatBat : PartItem;

public class MeleeSwordBeamSword : PartItem;

public class MeleeSwordBeeKeeper : PartItem;

public class MeleeSwordBladedGlove : PartItem;

public class MeleeSwordBladetongue : PartItem;

public class MeleeSwordBoneSword : PartItem;

public class MeleeSwordBrandOfTheInferno : PartItem;

public class MeleeSwordBreakerBlade : PartItem;

public class MeleeSwordBreathingReed : PartItem;

public class MeleeSwordChristmasTreeSword : PartItem;

public class MeleeSwordClassyCane : PartItem;

public class MeleeSwordCutlass : PartItem;

public class MeleeSwordDeathSickle : PartItem;

public class MeleeSwordEnchantedSword : PartItem;

public class MeleeSwordExoticScimitar : PartItem;

public class MeleeSwordFalconBlade : PartItem;

public class MeleeSwordFetidBaghnakhs : PartItem;

public class MeleeSwordFlyingDragon : PartItem;

public class MeleeSwordGladius : PartItem;

public class MeleeSwordHamBat : PartItem;

public class MeleeSwordHorsemansBlade : PartItem;

public class MeleeSwordIceBlade : PartItem;

public class MeleeSwordIceSickle : PartItem;

public class MeleeSwordInfluxWaver : PartItem;

public class MeleeSwordKatana : PartItem;

public class MeleeSwordKeybrand : PartItem;

public class MeleeSwordMandibleBlade : PartItem;

public class MeleeSwordMeowmere : PartItem;

public class MeleeSwordMuramasa : PartItem;

public class MeleeSwordPsychoKnife : PartItem;

public class MeleeSwordPurpleClubberfish : PartItem;

public class MeleeSwordRuler : PartItem;

public class MeleeSwordSeedler : PartItem;

public class MeleeSwordSickle : PartItem;

public class MeleeSwordSlapHand : PartItem;

public class MeleeSwordStarWrath : PartItem;

public class MeleeSwordStarfury : PartItem;

public class MeleeSwordStylishScissors : PartItem;

public class MeleeSwordTentacleSpike : PartItem;

public class MeleeSwordTerragrim : PartItem;

public class MeleeSwordTragicUmbrella : PartItem;

public class MeleeSwordUmbrella : PartItem;

public class MeleeSwordWafflesIron : PartItem;

public class MeleeSwordZombieArm : PartItem;

public class MeleeYoyoAmarok : PartItem;

public class MeleeYoyoCascade : PartItem;

public class MeleeYoyoCode1 : PartItem;

public class MeleeYoyoCode2 : PartItem;

public class MeleeYoyoEyeOfCthulhu : PartItem;

public class MeleeYoyoFormatC : PartItem;

public class MeleeYoyoGradient : PartItem;

public class MeleeYoyoHelFire : PartItem;

public class MeleeYoyoKraken : PartItem;

public class MeleeYoyoRally : PartItem;

public class MeleeYoyoRedsThrow : PartItem;

public class MeleeYoyoTerrarian : PartItem;

public class MeleeYoyoValkyrieYoyo : PartItem;

public class MeleeYoyoValor : PartItem;

public class MeleeYoyoYelets : PartItem;

public class MinecartBee : PartItem;

public class MinecartDemonicHellcart : PartItem;

public class MinecartDesert : PartItem;

public class MinecartDiggingMolecart : PartItem;

public class MinecartDutchman : PartItem;

public class MinecartLadybug : PartItem;

public class MinecartMechanicalCart : PartItem;

public class MinecartMeowmere : PartItem;

public class MinecartMinecarp : PartItem;

public class MinecartPigron : PartItem;

public class MinecartShroom : PartItem;

public class MinecartSteampunk : PartItem;

public class MinecartSunflower : PartItem;

public class MountAncientHorn : PartItem;

public class MountBlackStuddedSaddle : PartItem;

public class MountBlessedApple : PartItem;

public class MountBrainScrambler : PartItem;

public class MountCosmicCarKey : PartItem;

public class MountDarkMagesTome : PartItem;

public class MountDustyRawhideSaddle : PartItem;

public class MountFuzzyCarrot : PartItem;

public class MountGelatinousPillon : PartItem;

public class MountGoatSkull : PartItem;

public class MountGolfCartKeys : PartItem;

public class MountHardySaddle : PartItem;

public class MountHexxedBranch : PartItem;

public class MountHoneyedGoggles : PartItem;

public class MountLilithsNecklace : PartItem;

public class MountMolluskWhistle : PartItem;

public class MountPogoStick : PartItem;

public class MountReindeerBells : PartItem;

public class MountRoyalGildedSaddle : PartItem;

public class MountScalyTruffle : PartItem;

public class MountShrimpyTruffle : PartItem;

public class MountSlimySaddle : PartItem;

public class MountSuperheatedBlood : PartItem;

public class MountTheBlackSpot : PartItem;

public class MountToyTank : PartItem;

public class MountWitchsBroom : PartItem;

public class PetBetsysEgg : PartItem;

public class PetBrainInAJar : PartItem;

public class PetCosmicSkateboard : PartItem;

public class PetDeactivatedProbe : PartItem;

public class PetDeerclopsEyeball : PartItem;

public class PetFrozenCrown : PartItem;

public class PetLightGuardianGolem : PartItem;

public class PetLightJewelOfLight : PartItem;

public class PetOgresClub : PartItem;

public class PetPairOfEyeballs : PartItem;

public class PetPieceOfMoonSquid : PartItem;

public class PetPlanteraSeedling : PartItem;

public class PetPorkOfTheSea : PartItem;

public class PetPossessedSkull : PartItem;

public class PetRegalDelicacy : PartItem;

public class PetRoboticSkull : PartItem;

public class PetRoyalDelight : PartItem;

public class PetShrubStar : PartItem;

public class PetSparklingHoney : PartItem;

public class PetSpiffoPlush : PartItem;

public class PetSuspiciousGrinningEye : PartItem;

public class PetTabletFragment : PartItem;

public class PetWrithingRemains : PartItem;

public class RangedBowAerialBane : PartItem;

public class RangedBowBeesKnees : PartItem;

public class RangedBowBloodRainBow : PartItem;

public class RangedBowDaedalusStormbow : PartItem;

public class RangedBowEventide : PartItem;

public class RangedBowHellwingBow : PartItem;

public class RangedBowMarrow : PartItem;

public class RangedBowPhantomPhoenix : PartItem;

public class RangedBowPulseBow : PartItem;

public class RangedBowShadowflameBow : PartItem;

public class RangedBowStakeLauncher : PartItem;

public class RangedBowTsunami : PartItem;

public class RangedGunAleTosser : PartItem;

public class RangedGunBlowgun : PartItem;

public class RangedGunBlowpipe : PartItem;

public class RangedGunBoomstick : PartItem;

public class RangedGunCandyCornRifle : PartItem;

public class RangedGunCelebration : PartItem;

public class RangedGunCelebrationMk2 : PartItem;

public class RangedGunChainGun : PartItem;

public class RangedGunClockworkAssaultRifle : PartItem;

public class RangedGunDartPistol : PartItem;

public class RangedGunDartRifle : PartItem;

public class RangedGunElectrosphereLauncher : PartItem;

public class RangedGunElfMelter : PartItem;

public class RangedGunFlamethrower : PartItem;

public class RangedGunFlareGun : PartItem;

public class RangedGunFlintlockPistol : PartItem;

public class RangedGunGatligator : PartItem;

public class RangedGunGrenadeLauncher : PartItem;

public class RangedGunHandgun : PartItem;

public class RangedGunHarpoon : PartItem;

public class RangedGunJackOLanternLauncher : PartItem;

public class RangedGunMinishark : PartItem;

public class RangedGunMusket : PartItem;

public class RangedGunNailGun : PartItem;

public class RangedGunPaintballGun : PartItem;

public class RangedGunPewMaticHorn : PartItem;

public class RangedGunPiranhaGun : PartItem;

public class RangedGunProximityMineLauncher : PartItem;

public class RangedGunQuadBarrelShotgun : PartItem;

public class RangedGunRedRyder : PartItem;

public class RangedGunRevolver : PartItem;

public class RangedGunRocketLauncher : PartItem;

public class RangedGunSDMG : PartItem;

public class RangedGunSandgun : PartItem;

public class RangedGunShotgun : PartItem;

public class RangedGunSniperRifle : PartItem;

public class RangedGunSnowballCannon : PartItem;

public class RangedGunSnowmanCannon : PartItem;

public class RangedGunStynger : PartItem;

public class RangedGunTacticalShotgun : PartItem;

public class RangedGunTheUndertaker : PartItem;

public class RangedGunToxikarp : PartItem;

public class RangedGunUzi : PartItem;

public class RangedGunVenusMagnum : PartItem;

public class RangedGunXenopopper : PartItem;

public class SummonAbigailsFlower : PartItem;

public class SummonBladeStaff : PartItem;

public class SummonDeadlySphereStaff : PartItem;

public class SummonDesertTigerStaff : PartItem;

public class SummonFinchStaff : PartItem;

public class SummonHoundiusShootius : PartItem;

public class SummonLunarPortalStaff : PartItem;

public class SummonRainbowCrystalStaff : PartItem;

public class SummonRavenStaff : PartItem;

public class SummonSanguineStaff : PartItem;

public class SummonSlimeStaff : PartItem;

public class SummonStaffOfTheFrostHydra : PartItem;

public class SummonTempestStaff : PartItem;

public class SummonTerraprisma : PartItem;

public class SummonVampireFrogStaff : PartItem;

public class SummonWhipDarkHarvest : PartItem;

public class SummonWhipFirecracker : PartItem;

public class SummonWhipKaleidoscope : PartItem;

public class SummonWhipLeatherWhip : PartItem;

public class SummonWhipMorningStar : PartItem;

public class SummonWhipSpinalTap : PartItem;

public class SummonXenoStaff : PartItem;

public class ToolBugNet : PartItem;

public class ToolClentaminator : PartItem;

public class ToolDirtRod : PartItem;

public class ToolPaintbrush : PartItem;

public class ToolPaintRoller : PartItem;

public class ToolPaintScraper : PartItem;

public class ToolPiggyBank : PartItem;

public class ToolSafe : PartItem;
// ReSharper restore ClassNeverInstantiated.Global
