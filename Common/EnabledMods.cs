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

    public static Mod ModFargoMutantModEnabled { get; set; }
    public static Mod ModLuiafkEnabled { get; set; }
    public static Mod ModCalamityModEnabled { get; set; }
    public static Mod ModThoriumModEnabled { get; set; }
    public static Mod ModSpiritModEnabled { get; set; }
    public static Mod ModFargoSoulsEnabled { get; set; }
    public static Mod ModModOfRedemptionEnabled { get; set; }
    public static Mod ModStarsAboveEnabled { get; set; }
    public static Mod ModMagicStorageEnabled { get; set; }
    public static Mod ModAlchemistNpcLiteEnabled { get; set; }
    public static Mod ModStarlightRiverEnabled { get; set; }
    public static Mod ModClickerClassEnabled { get; set; }
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
            EnabledMods.ModFargoMutantModEnabled = fargo;
        }

        ModLoader.TryGetMod("miningcracks_take_on_luiafk", out Mod luiafk);
        if (luiafk != null)
        {
            EnabledMods.LuiafkEnabled = true;
            EnabledMods.ModLuiafkEnabled = luiafk;
        }

        ModLoader.TryGetMod("MagicStorage", out Mod magicStorage);
        if (magicStorage != null)
        {
            EnabledMods.MagicStorageEnabled = true;
            EnabledMods.ModMagicStorageEnabled = magicStorage;
        }

        ModLoader.TryGetMod("AlchemistNPCLite", out Mod alchNpcLite);
        if (alchNpcLite != null)
        {
            EnabledMods.AlchemistNpcLiteEnabled = true;
            EnabledMods.ModAlchemistNpcLiteEnabled = alchNpcLite;
        }
    }

    private static void CheckContentMods()
    {
        ModLoader.TryGetMod("CalamityMod", out Mod calamityMod);
        if (calamityMod != null)
        {
            EnabledMods.CalamityModEnabled = true;
            EnabledMods.ModCalamityModEnabled = calamityMod;
            EnabledMods.AnyContentModEnabled = true;
        }

        ModLoader.TryGetMod("ThoriumMod", out Mod thoriumMod);
        if (thoriumMod != null)
        {
            EnabledMods.ThoriumModEnabled = true;
            EnabledMods.ModThoriumModEnabled = thoriumMod;
            EnabledMods.AnyContentModEnabled = true;
        }

        ModLoader.TryGetMod("SpiritMod", out Mod spiritMod);
        if (spiritMod != null)
        {
            EnabledMods.SpiritModEnabled = true;
            EnabledMods.ModSpiritModEnabled = spiritMod;
            EnabledMods.AnyContentModEnabled = true;
        }

        ModLoader.TryGetMod("FargowiltasSouls", out Mod fargos);
        if (fargos != null)
        {
            EnabledMods.FargoSoulsEnabled = true;
            EnabledMods.ModFargoSoulsEnabled = fargos;
            EnabledMods.AnyContentModEnabled = true;
        }

        ModLoader.TryGetMod("Redemption", out Mod modOfRedemption);
        if (modOfRedemption != null)
        {
            EnabledMods.ModOfRedemptionEnabled = true;
            EnabledMods.ModModOfRedemptionEnabled = modOfRedemption;
            EnabledMods.AnyContentModEnabled = true;
        }

        ModLoader.TryGetMod("StarsAbove", out Mod starsAbove);
        if (starsAbove != null)
        {
            EnabledMods.StarsAboveEnabled = true;
            EnabledMods.ModStarsAboveEnabled = starsAbove;
            EnabledMods.AnyContentModEnabled = true;
        }

        ModLoader.TryGetMod("StarlightRiver", out Mod starlightRiver);
        if (starlightRiver != null)
        {
            EnabledMods.StarlightRiverEnabled = true;
            EnabledMods.ModStarlightRiverEnabled = starlightRiver;
            EnabledMods.AnyContentModEnabled = true;
        }
    }

    private static void CheckMiniContentMods()
    {
        ModLoader.TryGetMod("ClickerClass", out Mod clickerClass);
        if (clickerClass != null)
        {
            EnabledMods.ClickerClassEnabled = true;
            EnabledMods.ModClickerClassEnabled = clickerClass;
        }
    }
}
