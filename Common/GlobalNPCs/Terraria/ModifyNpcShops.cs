using Argos.Content.Parts.Terraria;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Argos.Common.GlobalNPCs.Terraria;

public class ModifyNpcShops : GlobalNPC
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
                // TODO: Find a way to disable these items being sold. They are the correct ItemIDs.
                // shop.GetEntry(ItemID.Paintbrush).Disable();
                // shop.GetEntry(ItemID.PaintScraper).Disable();
                // shop.GetEntry(ItemID.PaintRoller).Disable();
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
}
