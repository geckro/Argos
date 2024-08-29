using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Argos.Common;

public class PlayerInventory : ModPlayer
{
    private readonly (string mod, short itemId)[] _inventoryItemsToRemove =
    [
            // Classic/Expert/Master mode items
            ("Terraria", ItemID.CopperShortsword),
            ("Terraria", ItemID.CopperPickaxe),

            // Journey mode items
            ("Terraria", ItemID.BabyBirdStaff),
            // ("Terraria", ItemID.CreativeWings),  // TODO: Does not get removed
            ("Terraria", ItemID.GrapplingHook),
            ("Terraria", ItemID.IronHammer),
            ("Terraria", ItemID.IronPickaxe),
            ("Terraria", ItemID.IronShortsword),
            ("Terraria", ItemID.MagicMirror),
            ("Terraria", ItemID.Rope),
            ("Terraria", ItemID.Torch),
            ("Terraria", ItemID.WolfMountItem)
    ];

    public override void ModifyStartingInventory(IReadOnlyDictionary<string, List<Item>> items,
            bool mCoreDeath)
    {
        foreach ((string mod, short itemId) inventoryItem in _inventoryItemsToRemove)
        {
            items[inventoryItem.mod].RemoveAll(item => item.type == inventoryItem.itemId);
        }
    }
}
