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
    public static bool MagicStorageEnabled { get; set; }
    public static bool AlchemistNpcLiteEnabled { get; set; }
    public static bool StarlightRiverEnabled { get; set; }
    public static bool ClickerClassEnabled { get; set; }
}

public static class EnabledModsChecker
{
    public static void CheckMods()
    {
        CheckQoLMods();
        CheckContentMods();
        CheckMiniContentMods();
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

        ModLoader.TryGetMod("MagicStorage", out Mod magicStorage);
        if (magicStorage != null)
        {
            EnabledMods.MagicStorageEnabled = true;
        }

        ModLoader.TryGetMod("AlchemistNPCLite", out Mod alchNpcLite);
        if (alchNpcLite != null)
        {
            EnabledMods.AlchemistNpcLiteEnabled = true;
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

        ModLoader.TryGetMod("StarlightRiver", out Mod starlightRiver);
        if (starlightRiver != null)
        {
            EnabledMods.StarlightRiverEnabled = true;
            EnabledMods.AnyContentModEnabled = true;
        }
    }

    private static void CheckMiniContentMods()
    {
        ModLoader.TryGetMod("ClickerClass", out Mod clickerClass);
        if (clickerClass != null)
        {
            EnabledMods.ClickerClassEnabled = true;
        }
    }
}
