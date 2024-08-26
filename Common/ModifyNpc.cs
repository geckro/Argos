using Argos.Content.Parts;
using Argos.Content.Parts.Terraria;
using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;

namespace Argos.Common;

public class ModifyNpc : GlobalNPC
{
    public override void ModifyNPCLoot(NPC npc,
            NPCLoot loot)
    {
        if (npc.type is NPCID.WalkingAntlion or NPCID.GiantWalkingAntlion or NPCID.FlyingAntlion
            or NPCID.GiantFlyingAntlion or NPCID.Antlion)
        {
            loot.Add(ItemDropRule.Common(ModContent.ItemType<MeleeSwordMandibleBlade>(),
                    50));
            loot.RemoveWhere(rule => rule is CommonDrop { itemId: ItemID.AntlionClaw });
        }
    }
}