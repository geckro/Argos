using Terraria.ModLoader;

namespace Argos.Common;

public static class EnabledMods
{
    public static bool FargoMutantModEnabled { get; set; }
    public static bool LuiafkEnabled { get; set; }
    public static bool AnyContentModEnabled { get; set; }
    public static bool CalamityModEnabled { get; set; }
    public static bool ThoriumModEnabled { get; set; }
    public static bool SpiritModEnabled { get; set; }
    public static bool FargoSoulsEnabled { get; set; }
    public static bool ModOfRedemptionEnabled { get; set; }
    public static bool StarsAboveEnabled { get; set; }
}

public static class EnabledModsChecker
{
    public static void CheckMods()
    {
        CheckQoLMods();
        CheckContentMods();
    }

    private static void CheckQoLMods()
    {
        ModLoader.TryGetMod("Fargowiltas", out Mod fargo);
        if (fargo != null)
        {
            EnabledMods.FargoMutantModEnabled = true;
        }

        ModLoader.TryGetMod("miningcracks_take_on_luiafk", out Mod luiafk);
        if (luiafk != null)
        {
            EnabledMods.LuiafkEnabled = true;
        }
    }

    private static void CheckContentMods()
    {
        ModLoader.TryGetMod("CalamityMod", out Mod calamityMod);
        if (calamityMod != null)
        {
            EnabledMods.CalamityModEnabled = true;
            EnabledMods.AnyContentModEnabled = true;
        }

        ModLoader.TryGetMod("ThoriumMod", out Mod thoriumMod);
        if (thoriumMod != null)
        {
            EnabledMods.ThoriumModEnabled = true;
            EnabledMods.AnyContentModEnabled = true;
        }

        ModLoader.TryGetMod("SpiritMod", out Mod spiritMod);
        if (spiritMod != null)
        {
            EnabledMods.SpiritModEnabled = true;
            EnabledMods.AnyContentModEnabled = true;
        }

        ModLoader.TryGetMod("FargowiltasSouls", out Mod fargos);
        if (fargos != null)
        {
            EnabledMods.FargoSoulsEnabled = true;
            EnabledMods.AnyContentModEnabled = true;
        }

        ModLoader.TryGetMod("Redemption", out Mod modOfRedemption);
        if (modOfRedemption != null)
        {
            EnabledMods.ModOfRedemptionEnabled = true;
            EnabledMods.AnyContentModEnabled = true;
        }

        ModLoader.TryGetMod("StarsAbove", out Mod starsAbove);
        if (starsAbove != null)
        {
            EnabledMods.StarsAboveEnabled = true;
            EnabledMods.AnyContentModEnabled = true;
        }
    }
}
