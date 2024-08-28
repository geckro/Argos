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
        Item.value = Item.sellPrice(0, 0, 0, 1);
    }
}
