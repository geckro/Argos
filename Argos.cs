using Argos.Common;
using Terraria.ModLoader;

namespace Argos;

public class Argos : Mod
{
    public override void Load()
    {
        EnabledModsChecker.CheckMods();
    }
}
