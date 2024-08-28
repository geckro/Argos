using Argos.Content.Parts.Terraria;
using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;

namespace Argos.Common.GlobalNPCs;

public class ModifyNpcLoot : GlobalNPC
{
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
