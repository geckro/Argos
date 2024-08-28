using Terraria;
using Terraria.ID;

namespace Argos.Content.Parts.Terraria;

public class SharedBetsy : PartItem
{
    public override void SetDefaults()
    {
        Item.rare = ItemRarityID.Yellow;
        Item.value = Item.sellPrice(gold: 1);
    }
}

public class SharedBrainOfCthulhu : PartItem
{
    public override void SetDefaults()
    {
        Item.rare = ItemRarityID.Blue;
        Item.value = Item.sellPrice(gold: 1);
    }
}

public class SharedChestCrimsonHeart : PartItem
{
    public override string Texture => $"Terraria/Images/Item_{ItemID.CrimsonHeart}";

    public override void SetDefaults()
    {
        Item.rare = ItemRarityID.Blue;
        Item.value = Item.sellPrice(silver: 75);
    }
}

public class SharedChestDesert : PartItem
{
    public override string Texture => $"Terraria/Images/Item_{ItemID.DesertChest}";

    public override void SetDefaults()
    {
        Item.rare = ItemRarityID.Green;
        Item.value = Item.sellPrice(gold: 2);
    }
}

public class SharedChestDesertPyramid : PartItem
{
    public override string Texture => $"Terraria/Images/Item_{ItemID.CactusChest}";

    public override void SetDefaults()
    {
        Item.rare = ItemRarityID.Blue;
        Item.value = Item.sellPrice(gold: 1, silver: 50);
    }
}

public class SharedChestGlowingMushroom : PartItem
{
    public override string Texture => $"Terraria/Images/Item_{ItemID.MushroomChest}";

    public override void SetDefaults()
    {
        Item.rare = ItemRarityID.Blue;
        Item.value = Item.sellPrice(gold: 1);
    }
}

public class SharedChestGolden : PartItem
{
    public override string Texture => $"Terraria/Images/Item_{ItemID.GoldenChest}";

    public override void SetDefaults()
    {
        Item.rare = ItemRarityID.Blue;
        Item.value = Item.sellPrice(silver: 80);
    }
}

public class SharedChestIce : PartItem
{
    public override string Texture => $"Terraria/Images/Item_{ItemID.IceChest}";

    public override void SetDefaults()
    {
        Item.rare = ItemRarityID.Blue;
        Item.value = Item.sellPrice(gold: 1);
    }
}

public class SharedChestJungle : PartItem
{
    public override string Texture => $"Terraria/Images/Item_{ItemID.IvyChest}";

    public override void SetDefaults()
    {
        Item.rare = ItemRarityID.Green;
        Item.value = Item.sellPrice(gold: 1, silver: 50);
    }
}

public class SharedChestJungleTemple : PartItem
{
    public override string Texture => $"Terraria/Images/Item_{ItemID.LihzahrdChest}";

    public override void SetDefaults()
    {
        Item.rare = ItemRarityID.Lime;
        Item.value = Item.sellPrice(gold: 5);
    }
}

public class SharedChestLivingWood : PartItem
{
    public override string Texture => $"Terraria/Images/Item_{ItemID.LivingWoodChest}";

    public override void SetDefaults()
    {
        Item.rare = ItemRarityID.Blue;
        Item.value = Item.sellPrice(silver: 60);
    }
}

public class SharedChestLockedDungeon : PartItem
{
    public override string Texture => $"Terraria/Images/Item_{ItemID.BoneChest}";

    public override void SetDefaults()
    {
        Item.rare = ItemRarityID.Orange;
        Item.value = Item.sellPrice(gold: 2);
    }
}

public class SharedChestShadowUnderworld : PartItem
{
    public override string Texture => $"Terraria/Images/Item_{ItemID.ShadowChest}";

    public override void SetDefaults()
    {
        Item.rare = ItemRarityID.Orange;
        Item.value = Item.sellPrice(gold: 4);
    }
}

public class SharedChestShadowOrb : PartItem
{
    public override string Texture => $"Terraria/Images/Item_{ItemID.ShadowOrb}";

    public override void SetDefaults()
    {
        Item.rare = ItemRarityID.Blue;
        Item.value = Item.sellPrice(silver: 75);
    }
}

public class SharedChestSkyIslands : PartItem
{
    public override string Texture => $"Terraria/Images/Item_{ItemID.SkywareChest}";

    public override void SetDefaults()
    {
        Item.rare = ItemRarityID.Green;
        Item.value = Item.sellPrice(gold: 1);
    }
}

public class SharedChestWater : PartItem
{
    public override string Texture => $"Terraria/Images/Item_{ItemID.WaterChest}";

    public override void SetDefaults()
    {
        Item.rare = ItemRarityID.Blue;
        Item.value = Item.sellPrice(silver: 75);
    }
}

public class SharedChestWoodDungeon : PartItem
{
    public override string Texture => $"Terraria/Images/Item_{ItemID.GlassChest}";

    public override void SetDefaults()
    {
        Item.rare = ItemRarityID.Green;
        Item.value = Item.sellPrice(silver: 60);
    }
}

public class SharedChestWooden : PartItem
{
    public override string Texture => $"Terraria/Images/Item_{ItemID.Chest}";

    public override void SetDefaults()
    {
        Item.rare = ItemRarityID.Blue;
        Item.value = Item.sellPrice(silver: 25);
    }
}

public class SharedDarkMage : PartItem
{
    public override void SetDefaults()
    {
        Item.rare = ItemRarityID.Green;
        Item.value = Item.sellPrice(gold: 1);
    }
}

public class SharedDeerclops : PartItem
{
    public override void SetDefaults()
    {
        Item.rare = ItemRarityID.Orange;
        Item.value = Item.sellPrice(gold: 1);
    }
}

public class SharedDestroyer : PartItem
{
    public override void SetDefaults()
    {
        Item.rare = ItemRarityID.Pink;
        Item.value = Item.sellPrice(gold: 1);
    }
}

public class SharedDreadnautilus : PartItem
{
    public override void SetDefaults()
    {
        Item.rare = ItemRarityID.LightRed;
        Item.value = Item.sellPrice(gold: 1);
    }
}

public class SharedDukeFishron : PartItem
{
    public override void SetDefaults()
    {
        Item.rare = ItemRarityID.Yellow;
        Item.value = Item.sellPrice(gold: 1);
    }
}

public class SharedEaterOfWorlds : PartItem
{
    public override void SetDefaults()
    {
        Item.rare = ItemRarityID.Blue;
        Item.value = Item.sellPrice(gold: 1);
    }
}

public class SharedEmpressOfLight : PartItem
{
    public override void SetDefaults()
    {
        Item.rare = ItemRarityID.Yellow;
        Item.value = Item.sellPrice(gold: 1);
    }
}

public class SharedEverscream : PartItem
{
    public override void SetDefaults()
    {
        Item.rare = ItemRarityID.Lime;
        Item.value = Item.sellPrice(gold: 1);
    }
}

public class SharedEyeOfCthulhu : PartItem
{
    public override void SetDefaults()
    {
        Item.rare = ItemRarityID.Blue;
        Item.value = Item.sellPrice(gold: 1);
    }
}

public class SharedFlyingDutchman : PartItem
{
    public override void SetDefaults()
    {
        Item.rare = ItemRarityID.LightRed;
        Item.value = Item.sellPrice(gold: 1);
    }
}

public class SharedGoblinWarlock : PartItem
{
    public override void SetDefaults()
    {
        Item.rare = ItemRarityID.LightRed;
        Item.value = Item.sellPrice(gold: 1);
    }
}

public class SharedGolem : PartItem
{
    public override void SetDefaults()
    {
        Item.rare = ItemRarityID.Lime;
        Item.value = Item.sellPrice(gold: 1);
    }
}

public class SharedIceQueen : PartItem
{
    public override void SetDefaults()
    {
        Item.rare = ItemRarityID.Yellow;
        Item.value = Item.sellPrice(gold: 1);
    }
}

public class SharedKingSlime : PartItem
{
    public override void SetDefaults()
    {
        Item.rare = ItemRarityID.Blue;
        Item.value = Item.sellPrice(gold: 1);
    }
}

public class SharedLunaticCultist : PartItem
{
    public override void SetDefaults()
    {
        Item.rare = ItemRarityID.Cyan;
        Item.value = Item.sellPrice(gold: 1);
    }
}

public class SharedMartianSaucer : PartItem
{
    public override void SetDefaults()
    {
        Item.rare = ItemRarityID.Yellow;
        Item.value = Item.sellPrice(gold: 1);
    }
}

public class SharedMimic : PartItem
{
    public override void SetDefaults()
    {
        Item.rare = ItemRarityID.LightRed;
        Item.value = Item.sellPrice(gold: 1);
    }
}

public class SharedMimicCorrupt : PartItem
{
    public override void SetDefaults()
    {
        Item.rare = ItemRarityID.LightRed;
        Item.value = Item.sellPrice(gold: 1);
    }
}

public class SharedMimicCrimson : PartItem
{
    public override void SetDefaults()
    {
        Item.rare = ItemRarityID.LightRed;
        Item.value = Item.sellPrice(gold: 1);
    }
}

public class SharedMimicHallowed : PartItem
{
    public override void SetDefaults()
    {
        Item.rare = ItemRarityID.LightRed;
        Item.value = Item.sellPrice(gold: 1);
    }
}

public class SharedMimicIce : PartItem
{
    public override void SetDefaults()
    {
        Item.rare = ItemRarityID.LightRed;
        Item.value = Item.sellPrice(gold: 1);
    }
}

public class SharedMoonLord : PartItem
{
    public override void SetDefaults()
    {
        Item.rare = ItemRarityID.Cyan;
        Item.value = Item.sellPrice(gold: 1);
    }
}

public class SharedMothron : PartItem
{
    public override void SetDefaults()
    {
        Item.rare = ItemRarityID.Yellow;
        Item.value = Item.sellPrice(gold: 1);
    }
}

public class SharedMourningWood : PartItem
{
    public override void SetDefaults()
    {
        Item.rare = ItemRarityID.Lime;
        Item.value = Item.sellPrice(gold: 1);
    }
}

public class SharedOgre : PartItem
{
    public override void SetDefaults()
    {
        Item.rare = ItemRarityID.Pink;
        Item.value = Item.sellPrice(gold: 1);
    }
}

public class SharedPirateCaptain : PartItem
{
    public override void SetDefaults()
    {
        Item.rare = ItemRarityID.LightRed;
        Item.value = Item.sellPrice(gold: 1);
    }
}

public class SharedPlantera : PartItem
{
    public override void SetDefaults()
    {
        Item.rare = ItemRarityID.Lime;
        Item.value = Item.sellPrice(gold: 1);
    }
}

public class SharedPumpking : PartItem
{
    public override void SetDefaults()
    {
        Item.rare = ItemRarityID.Yellow;
        Item.value = Item.sellPrice(gold: 1);
    }
}

public class SharedQueenBee : PartItem
{
    public override void SetDefaults()
    {
        Item.rare = ItemRarityID.Green;
        Item.value = Item.sellPrice(gold: 1);
    }
}

public class SharedQueenSlime : PartItem
{
    public override void SetDefaults()
    {
        Item.rare = ItemRarityID.LightRed;
        Item.value = Item.sellPrice(gold: 1);
    }
}

public class SharedSantank : PartItem
{
    public override void SetDefaults()
    {
        Item.rare = ItemRarityID.Lime;
        Item.value = Item.sellPrice(gold: 1);
    }
}

public class SharedSkeletron : PartItem
{
    public override void SetDefaults()
    {
        Item.rare = ItemRarityID.Green;
        Item.value = Item.sellPrice(gold: 1);
    }
}

public class SharedSkeletronPrime : PartItem
{
    public override void SetDefaults()
    {
        Item.rare = ItemRarityID.Pink;
        Item.value = Item.sellPrice(gold: 1);
    }
}

public class SharedTwins : PartItem
{
    public override void SetDefaults()
    {
        Item.rare = ItemRarityID.Pink;
        Item.value = Item.sellPrice(gold: 1);
    }
}

public class SharedWallOfFlesh : PartItem
{
    public override void SetDefaults()
    {
        Item.rare = ItemRarityID.Orange;
        Item.value = Item.sellPrice(gold: 1);
    }
}
