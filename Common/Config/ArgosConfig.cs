using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace Argos.Common.Config;

public class ArgosConfig : ModConfig
{
    public override ConfigScope Mode => ConfigScope.ServerSide;

    [Header("Toggles"),DefaultValue(false),ReloadRequired]
    public bool HellMode;

    [Header("Mods"),DefaultValue(true),ReloadRequired]
    public bool EnableLuiafkSupport;
}
