using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace Argos.Common.Config;

public class ArgosConfig : ModConfig
{
    [Header("Mods"), DefaultValue(true), ReloadRequired]
    public bool EnableLuiafkSupport;

    [Header("Toggles"), DefaultValue(false), ReloadRequired]
    public bool HellMode;

    public override ConfigScope Mode => ConfigScope.ServerSide;
}
