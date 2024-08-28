using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Argos.Common;

public class PlayerInventory : ModPlayer
{
    private readonly (string mod, short itemId)[] _inventoryItemsToRemove =
    [
            ("Terraria", ItemID.CopperShortsword),
            ("Terraria", ItemID.CopperPickaxe)
    ];

    public override void ModifyStartingInventory(IReadOnlyDictionary<string, List<Item>> items, bool mCoreDeath)
    {
        foreach ((string mod, short itemId) inventoryItem in _inventoryItemsToRemove)
        {
            items[inventoryItem.mod].RemoveAll(item => item.type == inventoryItem.itemId);
        }
    }
}
