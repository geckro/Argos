using Argos.Content.Parts.Terraria;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Argos.Common.World;

public class ReplaceChestItems : ModSystem
{
    private readonly int[] _desertPyramidItemsToReplace =
    [
            ItemID.SandstorminaBottle,
            ItemID.PharaohsMask,
            ItemID.PharaohsRobe,
            ItemID.FlyingCarpet
    ];

    private readonly int[] _dungeonItemsToRemove =
    [
            ItemID.ShadowKey,
            ItemID.BoneWelder,
            ItemID.ThrowingKnife,
            ItemID.Dynamite,
            ItemID.Torch
    ];

    private readonly int[] _dungeonItemsToReplace =
    [
            ItemID.Muramasa,
            ItemID.Handgun,
            ItemID.AquaScepter,
            ItemID.CobaltShield,
            ItemID.Valor,
            ItemID.MagicMissile,
            ItemID.BlueMoon
    ];

    private readonly int[] _goldChestItemsToRemove =
    [
            ItemID.Flare,
            ItemID.TeleportationPotion,
            ItemID.AngelStatue,
            ItemID.JestersArrow,
            ItemID.SuspiciousLookingEye,
            ItemID.GravitationPotion
    ];

    private readonly int[] _goldenChestItemsToReplace =
    [
            ItemID.HermesBoots,
            ItemID.Extractinator,
            ItemID.CloudinaBottle,
            ItemID.BandofRegeneration,
            ItemID.FlareGun,
            ItemID.ShoeSpikes,
            ItemID.LavaCharm,
            ItemID.Mace,
            ItemID.MagicMirror
    ];

    private readonly int[] _graniteItemsToRemove =
    [
            ItemID.TeleportationPotion,
            ItemID.AngelStatue,
            ItemID.JestersArrow,
            ItemID.SuspiciousLookingEye,
            ItemID.GravitationPotion
    ];

    private readonly int[] _graniteItemsToReplace =
    [
            ItemID.HermesBoots,
            ItemID.Extractinator,
            ItemID.CloudinaBottle,
            ItemID.FlareGun,
            ItemID.ShoeSpikes,
            ItemID.LavaCharm,
            ItemID.Mace,
            ItemID.MagicMirror
    ];

    private readonly int[] _iceChestItemsToRemove =
    [
            ItemID.TeleportationPotion,
            ItemID.AngelStatue,
            ItemID.JestersArrow,
            ItemID.SuspiciousLookingEye,
            ItemID.GravitationPotion
    ];

    private readonly int[] _ivyChestsItemsToRemove =
    [
            ItemID.TeleportationPotion,
            ItemID.AngelStatue,
            ItemID.JestersArrow,
            ItemID.SuspiciousLookingEye,
            ItemID.GravitationPotion
    ];

    private readonly int[] _ivyChestsItemsToReplace =
    [
            ItemID.AnkletoftheWind,
            ItemID.FeralClaws,
            ItemID.Boomstick,
            ItemID.StaffofRegrowth
    ];

    private readonly int[] _jungleTempleItemsToRemove =
    [
            ItemID.TeleportationPotion,
            ItemID.AngelStatue,
            ItemID.JestersArrow,
            ItemID.SuspiciousLookingEye,
            ItemID.GravitationPotion,
            ItemID.LihzahrdFurnace,
            ItemID.Torch,
            ItemID.LunarTabletFragment
    ];

    private readonly int[] _jungleTempleItemsToReplace =
    [
            ItemID.SolarTablet,
            ItemID.LihzahrdPowerCell
    ];

    private readonly int[] _livingWoodItemsToRemove =
    [
            ItemID.LeafWand
    ];

    private readonly int[] _livingWoodItemsToReplace =
    [
            ItemID.BabyBirdStaff,
            ItemID.LivingWoodWand
    ];

    private readonly int[] _marbleItemsToRemove =
    [
            ItemID.TeleportationPotion,
            ItemID.AngelStatue,
            ItemID.JestersArrow,
            ItemID.SuspiciousLookingEye,
            ItemID.GravitationPotion
    ];

    private readonly int[] _marbleItemsToReplace =
    [
            ItemID.HermesBoots,
            ItemID.Extractinator,
            ItemID.CloudinaBottle,
            ItemID.FlareGun,
            ItemID.ShoeSpikes,
            ItemID.LavaCharm,
            ItemID.Mace,
            ItemID.MagicMirror
    ];

    private readonly int[] _richMahoganyItemsToRemove =
    [
            ItemID.TeleportationPotion,
            ItemID.AngelStatue,
            ItemID.JestersArrow,
            ItemID.SuspiciousLookingEye,
            ItemID.GravitationPotion
    ];

    private readonly int[] _richMahoganyItemsToReplace =
    [
            ItemID.HermesBoots,
            ItemID.Extractinator,
            ItemID.CloudinaBottle,
            ItemID.FlareGun,
            ItemID.ShoeSpikes,
            ItemID.LavaCharm,
            ItemID.Mace,
            ItemID.MagicMirror
    ];

    private readonly int[] _sandstoneChestsItemsToRemove =
    [
            ItemID.TeleportationPotion,
            ItemID.AngelStatue,
            ItemID.JestersArrow,
            ItemID.SuspiciousLookingEye,
            ItemID.GravitationPotion
    ];

    private readonly int[] _sandstoneChestsItemsToReplace =
    [
            ItemID.MagicConch,
            ItemID.AncientChisel,
            ItemID.MysticCoilSnake,
            ItemID.ThunderSpear,
            ItemID.ThunderStaff,
            ItemID.CatBast
    ];

    private readonly int[] _surfaceChestItemsToRemove =
    [
            ItemID.HerbBag,
            ItemID.CanOfWorms,
            ItemID.ThrowingKnife,
            ItemID.BuilderPotion,
            ItemID.Bottle
    ];

    private readonly int[] _surfaceChestItemsToReplace =
    [
            ItemID.Spear,
            ItemID.Radar,
            ItemID.Aglet,
            ItemID.PortableStool,
            ItemID.WandofSparking,
            ItemID.WoodenBoomerang,
            ItemID.Blowpipe,
            ItemID.ClimbingClaws,
            ItemID.CordageGuide
    ];

    private readonly int[] _waterChestItemsToRemove =
    [
            ItemID.SharkBait,
            ItemID.SandcastleBucket,
            ItemID.AngelStatue
    ];

    private readonly int[] _waterChestItemsToReplace =
    [
            ItemID.Trident,
            ItemID.Flipper,
            ItemID.WaterWalkingBoots,
            ItemID.FloatingTube,
            ItemID.BreathingReed
    ];

    private readonly int[] _woodDungeonItemsToReplace =
    [
            ItemID.GoldenKey
    ];

    public override void PostWorldGen()
    {
        for (int chestIndex = 0; chestIndex < Main.maxChests; chestIndex++)
        {
            Chest chest = Main.chest[chestIndex];
            if (chest == null)
            {
                continue;
            }

            Tile chestTile = Main.tile[chest.x, chest.y];

            switch (chestTile)
            {
                // Underground Ice Chest
                case { TileType: TileID.Containers, TileFrameX: 11 * 36 }:
                {
                    for (int inventoryIndex = 0; inventoryIndex < Chest.maxItems; inventoryIndex++)
                    {
                        if (Array.IndexOf((int[])
                            [
                                    ItemID.FlurryBoots,
                                    ItemID.IceBlade,
                                    ItemID.BlizzardinaBottle,
                                    ItemID.SnowballCannon,
                                    ItemID.IceBoomerang,
                                    ItemID.IceMirror,
                                    ItemID.IceSkates,
                                    ItemID.Extractinator
                            ], chest.item[inventoryIndex].type) != -1)
                        {
                            chest.item[inventoryIndex].SetDefaults(ModContent.ItemType<SharedChestIce>());
                        }

                        if (Array.IndexOf(_iceChestItemsToRemove, chest.item[inventoryIndex].type) != -1)
                        {
                            chest.item[inventoryIndex].SetDefaults();
                            break;
                        }
                    }

                    break;
                }
                // Surface wooden chest
                case { TileType: TileID.Containers, TileFrameX: 0 * 36 }:
                {
                    for (int inventoryIndex = 0; inventoryIndex < Chest.maxItems; inventoryIndex++)
                    {
                        if (Array.IndexOf(_surfaceChestItemsToReplace, chest.item[inventoryIndex].type) != -1)
                        {
                            chest.item[inventoryIndex].SetDefaults(ModContent.ItemType<SharedChestWooden>());
                        }

                        if (Array.IndexOf(_woodDungeonItemsToReplace, chest.item[inventoryIndex].type) != -1)
                        {
                            chest.item[inventoryIndex].SetDefaults(ModContent.ItemType<SharedChestWoodDungeon>());
                        }

                        if (Array.IndexOf(_surfaceChestItemsToRemove, chest.item[inventoryIndex].type) != -1)
                        {
                            chest.item[inventoryIndex].SetDefaults();
                            break;
                        }
                    }

                    break;
                }
                // Underground Golden Chest && Desert Pyramid
                case { TileType: TileID.Containers, TileFrameX: 1 * 36 }:
                {
                    for (int inventoryIndex = 0; inventoryIndex < Chest.maxItems; inventoryIndex++)
                    {
                        if (Array.IndexOf(_goldenChestItemsToReplace, chest.item[inventoryIndex].type) != -1)
                        {
                            chest.item[inventoryIndex].SetDefaults(ModContent.ItemType<SharedChestGolden>());
                        }

                        if (Array.IndexOf(_desertPyramidItemsToReplace, chest.item[inventoryIndex].type) != -1)
                        {
                            chest.item[inventoryIndex].SetDefaults(ModContent.ItemType<SharedChestDesertPyramid>());
                        }

                        if (Array.IndexOf(_goldChestItemsToRemove, chest.item[inventoryIndex].type) != -1)
                        {
                            chest.item[inventoryIndex].SetDefaults();
                            break;
                        }
                    }

                    break;
                }
                // Locked Gold Chest (Dungeon)
                case { TileType: TileID.Containers, TileFrameX: 2 * 36 }:
                {
                    for (int inventoryIndex = 0; inventoryIndex < Chest.maxItems; inventoryIndex++)
                    {
                        if (Array.IndexOf(_dungeonItemsToReplace, chest.item[inventoryIndex].type) != -1)
                        {
                            chest.item[inventoryIndex].SetDefaults(ModContent.ItemType<SharedChestLockedDungeon>());
                        }

                        if (Array.IndexOf(_dungeonItemsToRemove, chest.item[inventoryIndex].type) != -1)
                        {
                            chest.item[inventoryIndex].SetDefaults();
                            break;
                        }
                    }

                    break;
                }
                // Underground Mahogany Chest
                case { TileType: TileID.Containers, TileFrameX: 8 * 36 }:
                {
                    for (int inventoryIndex = 0; inventoryIndex < Chest.maxItems; inventoryIndex++)
                    {
                        if (Array.IndexOf(_richMahoganyItemsToReplace, chest.item[inventoryIndex].type) != -1)
                        {
                            chest.item[inventoryIndex].SetDefaults(ModContent.ItemType<SharedChestGolden>());
                        }

                        if (Array.IndexOf(_richMahoganyItemsToRemove, chest.item[inventoryIndex].type) != -1)
                        {
                            chest.item[inventoryIndex].SetDefaults();
                            break;
                        }
                    }

                    break;
                }
                // Granite Chest
                case { TileType: TileID.Containers, TileFrameX: 50 * 36 }:
                {
                    for (int inventoryIndex = 0; inventoryIndex < Chest.maxItems; inventoryIndex++)
                    {
                        if (Array.IndexOf(_graniteItemsToReplace, chest.item[inventoryIndex].type) != -1)
                        {
                            chest.item[inventoryIndex].SetDefaults(ModContent.ItemType<SharedChestGolden>());
                        }

                        if (Array.IndexOf(_graniteItemsToRemove, chest.item[inventoryIndex].type) != -1)
                        {
                            chest.item[inventoryIndex].SetDefaults();
                            break;
                        }
                    }

                    break;
                }
                // Marble Chest
                case { TileType: TileID.Containers, TileFrameX: 51 * 36 }:
                {
                    for (int inventoryIndex = 0; inventoryIndex < Chest.maxItems; inventoryIndex++)
                    {
                        if (Array.IndexOf(_marbleItemsToReplace, chest.item[inventoryIndex].type) != -1)
                        {
                            chest.item[inventoryIndex].SetDefaults(ModContent.ItemType<SharedChestGolden>());
                        }

                        if (Array.IndexOf(_marbleItemsToRemove, chest.item[inventoryIndex].type) != -1)
                        {
                            chest.item[inventoryIndex].SetDefaults();
                            break;
                        }
                    }

                    break;
                }
                // Underground Ivy Chest
                case { TileType: TileID.Containers, TileFrameX: 10 * 36 }:
                {
                    for (int inventoryIndex = 0; inventoryIndex < Chest.maxItems; inventoryIndex++)
                    {
                        if (Array.IndexOf(_ivyChestsItemsToReplace, chest.item[inventoryIndex].type) != -1)
                        {
                            chest.item[inventoryIndex].SetDefaults(ModContent.ItemType<SharedChestJungle>());
                        }

                        if (Array.IndexOf(_ivyChestsItemsToRemove, chest.item[inventoryIndex].type) != -1)
                        {
                            chest.item[inventoryIndex].SetDefaults();
                            break;
                        }
                    }

                    break;
                }
                // Water/Ocean Chest
                case { TileType: TileID.Containers, TileFrameX: 17 * 36 }:
                {
                    for (int inventoryIndex = 0; inventoryIndex < Chest.maxItems; inventoryIndex++)
                    {
                        if (Array.IndexOf(_waterChestItemsToReplace, chest.item[inventoryIndex].type) != -1)
                        {
                            chest.item[inventoryIndex].SetDefaults(ModContent.ItemType<SharedChestWater>());
                        }

                        if (Array.IndexOf(_waterChestItemsToRemove, chest.item[inventoryIndex].type) != -1)
                        {
                            chest.item[inventoryIndex].SetDefaults();
                            break;
                        }
                    }

                    break;
                }
                // Living Chest
                case { TileType: TileID.Containers, TileFrameX: 12 * 36 }:
                {
                    for (int inventoryIndex = 0; inventoryIndex < Chest.maxItems; inventoryIndex++)
                    {
                        if (Array.IndexOf(_livingWoodItemsToReplace, chest.item[inventoryIndex].type) != -1)
                        {
                            chest.item[inventoryIndex].SetDefaults(ModContent.ItemType<SharedChestLivingWood>());
                        }

                        if (Array.IndexOf(_livingWoodItemsToRemove, chest.item[inventoryIndex].type) != -1)
                        {
                            chest.item[inventoryIndex].SetDefaults();
                            break;
                        }
                    }

                    break;
                }
                // Underground Desert Chest
                case { TileType: TileID.Containers2, TileFrameX: 10 * 36 }:
                {
                    for (int inventoryIndex = 0; inventoryIndex < Chest.maxItems; inventoryIndex++)
                    {
                        if (Array.IndexOf(_sandstoneChestsItemsToReplace, chest.item[inventoryIndex].type) != -1)
                        {
                            chest.item[inventoryIndex].SetDefaults(ModContent.ItemType<SharedChestDesert>());
                        }

                        if (Array.IndexOf(_sandstoneChestsItemsToRemove, chest.item[inventoryIndex].type) != -1)
                        {
                            chest.item[inventoryIndex].SetDefaults();
                            break;
                        }
                    }

                    break;
                }
                // Jungle Temple Chest
                case { TileType: TileID.Containers, TileFrameX: 16 * 36 }:
                {
                    for (int inventoryIndex = 0; inventoryIndex < Chest.maxItems; inventoryIndex++)
                    {
                        if (Array.IndexOf(_jungleTempleItemsToReplace, chest.item[inventoryIndex].type) != -1)
                        {
                            chest.item[inventoryIndex].SetDefaults(ModContent.ItemType<SharedChestJungleTemple>());
                        }

                        if (Array.IndexOf(_jungleTempleItemsToRemove, chest.item[inventoryIndex].type) != -1)
                        {
                            chest.item[inventoryIndex].SetDefaults();
                            break;
                        }
                    }

                    break;
                }
            }
        }
    }
}
