using Argos.Content.Parts.Terraria;
using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;

namespace Argos.Common;

public class ModifyNpc : GlobalNPC
{
    public override void ModifyShop(NPCShop shop)
    {
        switch (shop.NpcType)
        {
            case NPCID.ArmsDealer:
                shop.GetEntry(ItemID.TungstenBullet).Disable();

                shop.GetEntry(ItemID.Minishark).Disable();
                shop.Add<RangedGunMinishark>(Condition.InBeach, Condition.DownedEyeOfCthulhu);

                shop.GetEntry(ItemID.FlintlockPistol).Disable();
                shop.Add<RangedGunFlintlockPistol>();

                shop.GetEntry(ItemID.Shotgun).Disable();
                shop.Add<RangedGunShotgun>(Condition.Hardmode);

                shop.GetEntry(ItemID.QuadBarrelShotgun).Disable();
                shop.Add<RangedGunQuadBarrelShotgun>(Condition.DownedSkeletron, Condition.InGraveyard);
                break;
            case NPCID.Merchant:
                shop.GetEntry(ItemID.IronAnvil).Disable();
                shop.GetEntry(ItemID.MiningHelmet).Disable();
                shop.GetEntry(ItemID.CopperPickaxe).Disable();
                shop.GetEntry(ItemID.CopperAxe).Disable();
                shop.GetEntry(ItemID.Furnace).Disable();
                shop.GetEntry(ItemID.Sickle).Disable();
                shop.Add<MeleeSwordSickle>();
                shop.GetEntry(ItemID.BugNet).Disable();
                shop.Add<ToolBugNet>();
                shop.GetEntry(ItemID.PiggyBank).Disable();
                shop.Add<ToolPiggyBank>();
                shop.GetEntry(ItemID.Safe).Disable();
                shop.Add<ToolSafe>(Condition.DownedSkeletron);
                break;
            case NPCID.Steampunker:
                shop.GetEntry(ItemID.Clentaminator).Disable();
                shop.Add<ToolClentaminator>(Condition.NotInHallow, Condition.Hardmode);
                shop.GetEntry(ItemID.BlendOMatic).Disable();
                shop.Add<CraftingStationBlendOMatic>();
                shop.GetEntry(ItemID.SteampunkBoiler).Disable();
                shop.Add<CraftingStationSteampunkBoiler>(Condition.DownedPlantera);
                shop.GetEntry(ItemID.FleshCloningVaat).Disable();
                shop.Add<CraftingStationFleshCloningVat>(Condition.InCrimson);
                shop.GetEntry(ItemID.LesionStation).Disable();
                shop.Add<CraftingStationDecayChamber>(Condition.InCorrupt);
                shop.GetEntry(ItemID.SteampunkMinecart).Disable();
                shop.Add<MinecartSteampunk>(Condition.Hardmode);
                shop.GetEntry(ItemID.SteampunkWings).Disable();
                shop.Add<AccSteampunkWings>(Condition.Hardmode, Condition.DownedGolem);
                shop.GetEntry(ItemID.Jetpack).Disable();
                shop.Add<AccJetpack>(Condition.Hardmode, Condition.MoonPhasesHalf1);
                break;
            case NPCID.Cyborg:
                shop.GetEntry(ItemID.ProximityMineLauncher).Disable();
                shop.Add<RangedGunProximityMineLauncher>();
                break;
            case NPCID.Dryad:
                shop.GetEntry(ItemID.DirtRod).Disable();
                shop.Add<ToolDirtRod>();
                break;
            case NPCID.Painter:
                shop.GetEntry(ItemID.Paintbrush).Disable();
                shop.Add<ToolPaintbrush>();
                shop.Add<ToolPaintScraper>();
                shop.Add<ToolPaintRoller>();
                break;
            case NPCID.Demolitionist:
                shop.GetEntry(ItemID.HellfireArrow).Disable();
                break;
            case NPCID.DyeTrader:
                shop.GetEntry(ItemID.DyeVat).Disable();
                shop.Add<CraftingStationDyeVat>();
                break;
            case NPCID.Wizard:
                shop.GetEntry(ItemID.IceRod).Disable();
                shop.Add<MageIceRod>(Condition.InSnow, Condition.InBelowSurface);
                break;
            case NPCID.WitchDoctor:
                shop.GetEntry(ItemID.Blowgun).Disable();
                shop.Add<RangedGunBlowgun>();
                shop.GetEntry(ItemID.TikiMask).Disable();
                shop.Add<ArmorTikiHead>(Condition.DownedPlantera);
                shop.GetEntry(ItemID.TikiShirt).Disable();
                shop.Add<ArmorTikiChest>(Condition.DownedPlantera);
                shop.GetEntry(ItemID.TikiMask).Disable();
                shop.Add<ArmorTikiLegs>(Condition.DownedPlantera);
                shop.GetEntry(ItemID.PygmyNecklace).Disable();
                shop.Add<AccPygmyNecklace>(Condition.DownedSkeletron);
                shop.GetEntry(ItemID.HerculesBeetle).Disable();
                shop.Add<AccHerculesBeetle>(Condition.DownedPlantera, Condition.InJungle);
                break;
            case NPCID.BestiaryGirl:
                shop.GetEntry(ItemID.BlandWhip).Disable();
                shop.Add<SummonWhipLeatherWhip>();
                shop.GetEntry(ItemID.SquirrelHook).Disable();
                shop.Add<HookSquirrel>(Condition.InOverworldHeight);
                shop.GetEntry(ItemID.JoustingLance).Disable();
                shop.Add<MeleeOtherJoustingLance>(Condition.BestiaryFilledPercent(30));
                shop.GetEntry(ItemID.DiggingMoleMinecart).Disable();
                shop.Add<MinecartDiggingMolecart>(Condition.BestiaryFilledPercent(35));
                break;
            case NPCID.Truffle:
                shop.GetEntry(ItemID.Autohammer).Disable();
                shop.Add<CraftingStationAutohammer>(Condition.DownedPlantera, Condition.InGlowshroom);
                shop.GetEntry(ItemID.MushroomSpear).Disable();
                shop.GetEntry(ItemID.Hammush).Disable();
                shop.Add<MeleeSpearMushroomSpearAndHammush>(Condition.DownedMechBossAny);
                break;
        }
    }

    public override void ModifyNPCLoot(NPC npc,
            NPCLoot loot)
    {
        // https://terraria.wiki.gg/wiki/NPC_IDs
        switch (npc.type)
        {
            // -100 to 0

            case NPCID.Pinky:
                loot.Add(ItemDropRule.NormalvsExpert(ModContent.ItemType<SummonSlimeStaff>(), 100, 700));
                // TODO: Figure out how to remove NormalvsExpert loot. No clue on this one.
                break;

            // 1 - 100

            case NPCID.Antlion:
                loot.Add(ItemDropRule.Common(ModContent.ItemType<MeleeSwordMandibleBlade>(), 50));
                loot.RemoveWhere(rule => rule is CommonDrop { itemId: ItemID.AntlionClaw });
                break;
            case NPCID.Mimic:
                loot.Add(ItemDropRule.Common(ModContent.ItemType<SharedMimic>()));
                // TODO: Figure out how to remove the Mimic loot. Something to do with Chains/ChainedMethods in LeadingCondition, but i give up.
                break;

            // 101 - 200

            case NPCID.Mechanic:
                loot.Add(ItemDropRule.Common(ModContent.ItemType<MeleeBoomerangCombatWrench>(), 8));
                loot.RemoveWhere(rule => rule is CommonDrop { itemId: ItemID.CombatWrench });
                break;
            case NPCID.IceTortoise:
                loot.Add(ItemDropRule.Common(ModContent.ItemType<AccFrozenTurtleShell>(), 50));
                loot.RemoveWhere(rule => rule is CommonDrop { itemId: ItemID.FrozenTurtleShell });
                break;
            case NPCID.BlackRecluse:
                loot.Add(ItemDropRule.Common(ModContent.ItemType<MagePoisonStaff>(), 40));
                loot.RemoveWhere(rule => rule is CommonDrop { itemId: ItemID.PoisonStaff });
                break;
            case NPCID.AngryTrapper:
                loot.Add(ItemDropRule.Common(ModContent.ItemType<RangedGunUzi>(), 100));
                loot.RemoveWhere(rule => rule is CommonDrop { itemId: ItemID.Uzi });
                break;
            case NPCID.LostGirl:
                loot.Add(ItemDropRule.NormalvsExpert(ModContent.ItemType<AccMetalDetector>(), 2, 1));
                loot.RemoveWhere(rule => rule is CommonDrop { itemId: ItemID.MetalDetector });
                break;
            case NPCID.Nymph:
                loot.Add(ItemDropRule.NormalvsExpert(ModContent.ItemType<AccMetalDetector>(), 2, 1));
                loot.RemoveWhere(rule => rule is CommonDrop { itemId: ItemID.MetalDetector });
                break;

            // 201 - 300

            case NPCID.DyeTrader:
                loot.Add(ItemDropRule.Common(ModContent.ItemType<MeleeSwordExoticScimitar>(), 8));
                loot.RemoveWhere(rule => rule is CommonDrop { itemId: ItemID.DyeTradersScimitar });
                break;
            case NPCID.PirateCaptain:
                loot.Add(ItemDropRule.Common(ModContent.ItemType<SharedPirateCaptain>(), 4));
                loot.RemoveWhere(rule => rule is CommonDrop { itemId: ItemID.CoinGun });
                loot.RemoveWhere(rule => rule is CommonDrop { itemId: ItemID.LuckyCoin });
                loot.RemoveWhere(rule => rule is CommonDrop { itemId: ItemID.DiscountCard });
                loot.RemoveWhere(rule => rule is CommonDrop { itemId: ItemID.PirateStaff });
                loot.RemoveWhere(rule => rule is CommonDrop { itemId: ItemID.GoldRing });
                loot.RemoveWhere(rule => rule is CommonDrop { itemId: ItemID.Cutlass });
                break;
            case NPCID.Painter:
                loot.Add(ItemDropRule.Common(ModContent.ItemType<RangedGunPaintballGun>(), 10));
                loot.RemoveWhere(rule => rule is CommonDrop { itemId: ItemID.PainterPaintballGun });
                break;
            case NPCID.BlackRecluseWall:
                loot.Add(ItemDropRule.Common(ModContent.ItemType<MagePoisonStaff>(), 40));
                loot.RemoveWhere(rule => rule is CommonDrop { itemId: ItemID.PoisonStaff });
                break;

            // 301 - 400

            case NPCID.Stylist:
                loot.Add(ItemDropRule.Common(ModContent.ItemType<MeleeSwordStylishScissors>(), 8));
                loot.RemoveWhere(rule => rule is CommonDrop { itemId: ItemID.StylistKilLaKillScissorsIWish });
                break;

            // 401 - 500

            case NPCID.TaxCollector:
                loot.Add(ItemDropRule.Common(ModContent.ItemType<MeleeSwordClassyCane>(), 8));
                loot.RemoveWhere(rule => rule is CommonDrop { itemId: ItemID.TaxCollectorsStickOfDoom });
                break;

            // 501 - 600

            case NPCID.GiantWalkingAntlion:
                loot.Add(ItemDropRule.Common(ModContent.ItemType<MeleeSwordMandibleBlade>(), 50));
                loot.RemoveWhere(rule => rule is CommonDrop { itemId: ItemID.AntlionClaw });
                break;
            case NPCID.GiantFlyingAntlion:
                loot.Add(ItemDropRule.Common(ModContent.ItemType<MeleeSwordMandibleBlade>(), 50));
                loot.RemoveWhere(rule => rule is CommonDrop { itemId: ItemID.AntlionClaw });
                break;
            case NPCID.SandSlime:
                loot.Add(ItemDropRule.NormalvsExpert(ModContent.ItemType<SummonSlimeStaff>(), 8000, 5600));
                // TODO: Figure out how to remove NormalvsExpert loot. No clue on this one.
                break;
            case NPCID.WalkingAntlion:
                loot.Add(ItemDropRule.Common(ModContent.ItemType<MeleeSwordMandibleBlade>(), 50));
                loot.RemoveWhere(rule => rule is CommonDrop { itemId: ItemID.AntlionClaw });
                break;
            case NPCID.FlyingAntlion:
                loot.Add(ItemDropRule.Common(ModContent.ItemType<MeleeSwordMandibleBlade>(), 50));
                loot.RemoveWhere(rule => rule is CommonDrop { itemId: ItemID.AntlionClaw });
                break;

            // 601 - 700

            case NPCID.IceMimic:
                loot.Add(ItemDropRule.Common(ModContent.ItemType<SharedMimicIce>()));
                loot.RemoveWhere(rule => rule is CommonDrop { itemId: ItemID.ToySled });
                // loot.RemoveWhere(rule => rule is OneFromOptionsDropRule { dropIds: [676, 725, 1264] });
                break;
            case NPCID.Princess:
                loot.Add(ItemDropRule.Common(ModContent.ItemType<MageResonanceScepter>(), 8));
                loot.RemoveWhere(rule => rule is CommonDrop { itemId: ItemID.RoyalScepter });
                break;
        }
    }
}
