using System.Collections.Generic;
using Terraria.ModLoader;

namespace Argos.Common;

public class RemoveTips : ModSystem
{
    public override void ModifyGameTipVisibility(IReadOnlyList<GameTipData> gameTips)
    {
        foreach (GameTipData tip in gameTips)
        {
            if (tip.FullName.Contains("Terraria/"))
            {
                tip.Hide();
            }
        }
    }
}
