using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Argos.Common.RecipeEdits.Terraria;

public class Pickaxes : GlobalItem
{
    public override void AddRecipes()
    {
        RecipeHelper.AddRecipe(ItemID.CactusPickaxe, [(ItemID.Cactus, 20), (ItemID.Waterleaf, 3)],
                [TileID.WorkBenches]);

        RecipeHelper.AddRecipe(ItemID.CopperPickaxe, [(ItemID.CopperBar, 12), (ItemID.CactusPickaxe, 1)],
                recipeGroups: [("Wood", 6)], tiles: [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.TinPickaxe, [(ItemID.TinBar, 12), (ItemID.CactusPickaxe, 1)],
                recipeGroups: [("Wood", 6)], tiles: [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.IronPickaxe, [(ItemID.IronBar, 12)], recipeGroups: [("CopperPickaxe", 1)],
                tiles: [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.LeadPickaxe, [(ItemID.LeadBar, 12)], recipeGroups: [("CopperPickaxe", 1)],
                tiles: [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.SilverPickaxe, [(ItemID.SilverBar, 12), (ItemID.Sapphire, 1)],
                recipeGroups: [("IronPickaxe", 1)], tiles: [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.TungstenPickaxe, [(ItemID.TungstenBar, 12), (ItemID.Sapphire, 1)],
                recipeGroups: [("IronPickaxe", 1)], tiles: [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.GoldPickaxe, [(ItemID.GoldBar, 12), (ItemID.Ruby, 1)],
                recipeGroups: [("SilverPickaxe", 1)], tiles: [TileID.HeavyWorkBench]);

        RecipeHelper.AddRecipe(ItemID.PlatinumPickaxe, [(ItemID.PlatinumBar, 12), (ItemID.Ruby, 1)],
                recipeGroups: [("SilverPickaxe", 1)], tiles: [TileID.HeavyWorkBench]);

        RecipeHelper.AddRecipe(ItemID.FossilPickaxe, [(ItemID.FossilOre, 12), (ItemID.Amber, 2)],
                recipeGroups: [("GoldPickaxe", 1)], tiles: [TileID.CatBast]);

        RecipeHelper.AddRecipe(ItemID.NightmarePickaxe,
                [(ItemID.DemoniteBar, 12), (ItemID.Ebonwood, 24), (ItemID.ShadowScale, 8)],
                recipeGroups: [("GoldPickaxe", 1)], tiles: [TileID.DemonAltar], conditions: [Condition.InCorrupt]);

        RecipeHelper.AddRecipe(ItemID.DeathbringerPickaxe,
                [(ItemID.CrimtaneBar, 12), (ItemID.Shadewood, 24), (ItemID.TissueSample, 8)],
                recipeGroups: [("GoldPickaxe", 1)], tiles: [TileID.DemonAltar], conditions: [Condition.InCrimson]);

        RecipeHelper.AddRecipe(ItemID.MoltenPickaxe,
                [(ItemID.HellstoneBar, 12), (ItemID.AshWood, 24), (ItemID.BeeWax, 8)],
                recipeGroups: [("NightmarePickaxe", 1)], tiles: [TileID.Hellforge],
                conditions: [Condition.InUnderworld, Condition.NearLava]);

        RecipeHelper.AddRecipe(ItemID.CobaltPickaxe, [(ItemID.CobaltBar, 20), (ItemID.MoltenPickaxe, 1)], [TileID.HeavyWorkBench]);

        RecipeHelper.AddRecipe(ItemID.PalladiumPickaxe, [(ItemID.PalladiumBar, 20), (ItemID.MoltenPickaxe, 1)], [TileID.HeavyWorkBench]);

        RecipeHelper.AddRecipe(ItemID.MythrilPickaxe, [(ItemID.MythrilBar, 20)], [TileID.MythrilAnvil], recipeGroups: [("CobaltPickaxe", 1)]);

        RecipeHelper.AddRecipe(ItemID.OrichalcumPickaxe, [(ItemID.OrichalcumBar, 20)], [TileID.MythrilAnvil], recipeGroups: [("CobaltPickaxe", 1)]);

        RecipeHelper.AddRecipe(ItemID.AdamantitePickaxe, [(ItemID.AdamantiteBar, 20)], [TileID.MythrilAnvil], recipeGroups: [("MythrilPickaxe", 1)]);

        RecipeHelper.AddRecipe(ItemID.TitaniumPickaxe, [(ItemID.TitaniumBar, 20)], [TileID.MythrilAnvil], recipeGroups: [("MythrilPickaxe", 1)]);

        RecipeHelper.AddRecipe(ItemID.PickaxeAxe, [(ItemID.HallowedBar, 20), (ItemID.SoulofFright, 3), (ItemID.SoulofMight, 3), (ItemID.SoulofSight, 3), (ItemID.SoulofFlight, 3), (ItemID.SoulofLight, 3), (ItemID.SoulofNight, 3)], [TileID.MythrilAnvil], recipeGroups: [("AdamantitePickaxe", 1), ("AdamantiteWaraxe", 1)]);

        RecipeHelper.AddRecipe(ItemID.CobaltDrill, [(ItemID.CobaltBar, 18), (ItemID.MoltenPickaxe, 1)], [TileID.HeavyWorkBench]);

        RecipeHelper.AddRecipe(ItemID.PalladiumDrill, [(ItemID.PalladiumBar, 18), (ItemID.MoltenPickaxe, 1)], [TileID.HeavyWorkBench]);

        RecipeHelper.AddRecipe(ItemID.MythrilDrill, [(ItemID.MythrilBar, 18)], [TileID.MythrilAnvil], recipeGroups: [("CobaltDrill", 1)]);

        RecipeHelper.AddRecipe(ItemID.OrichalcumDrill, [(ItemID.OrichalcumBar, 18)], [TileID.MythrilAnvil], recipeGroups: [("CobaltDrill", 1)]);

        RecipeHelper.AddRecipe(ItemID.AdamantiteDrill, [(ItemID.AdamantiteBar, 18)], [TileID.MythrilAnvil], recipeGroups: [("MythrilDrill", 1)]);

        RecipeHelper.AddRecipe(ItemID.TitaniumDrill, [(ItemID.TitaniumBar, 18)], [TileID.MythrilAnvil], recipeGroups: [("MythrilDrill", 1)]);

        RecipeHelper.AddRecipe(ItemID.Drax, [(ItemID.HallowedBar, 20), (ItemID.SoulofFright, 3), (ItemID.SoulofMight, 3), (ItemID.SoulofSight, 3), (ItemID.SoulofFlight, 3), (ItemID.SoulofLight, 3), (ItemID.SoulofNight, 3)], [TileID.MythrilAnvil], recipeGroups: [("AdamantiteDrill", 1), ("AdamantiteChainsaw", 1)]);
    }
}

public class Axes : GlobalItem
{
    public override void AddRecipes()
    {
        RecipeHelper.AddRecipe(ItemID.CopperAxe, [(ItemID.CopperBar, 8)], recipeGroups: [("Wood", 6)],
                tiles: [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.TinAxe, [(ItemID.TinBar, 8)], recipeGroups: [("Wood", 6)],
                tiles: [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.IronAxe, [(ItemID.IronBar, 8)], recipeGroups: [("CopperAxe", 1)],
                tiles: [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.LeadAxe, [(ItemID.LeadBar, 8)], recipeGroups: [("CopperAxe", 1)],
                tiles: [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.SilverAxe, [(ItemID.SilverBar, 8), (ItemID.Sapphire, 1)],
                recipeGroups: [("IronAxe", 1)], tiles: [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.TungstenAxe, [(ItemID.TungstenBar, 8), (ItemID.Sapphire, 1)],
                recipeGroups: [("IronAxe", 1)], tiles: [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.GoldAxe, [(ItemID.GoldBar, 8), (ItemID.Ruby, 1)],
                recipeGroups: [("SilverAxe", 1)], tiles: [TileID.HeavyWorkBench]);

        RecipeHelper.AddRecipe(ItemID.PlatinumAxe, [(ItemID.PlatinumBar, 8), (ItemID.Ruby, 1)],
                recipeGroups: [("SilverAxe", 1)], tiles: [TileID.HeavyWorkBench]);

        RecipeHelper.AddRecipe(ItemID.WarAxeoftheNight, [(ItemID.DemoniteBar, 8), (ItemID.Ebonwood, 24)],
                recipeGroups: [("GoldAxe", 1)], tiles: [TileID.DemonAltar], conditions: [Condition.InCorrupt]);

        RecipeHelper.AddRecipe(ItemID.BloodLustCluster, [(ItemID.CrimtaneBar, 8), (ItemID.Shadewood, 24)],
                recipeGroups: [("GoldAxe", 1)], tiles: [TileID.DemonAltar], conditions: [Condition.InCrimson]);

        RecipeHelper.AddRecipe(ItemID.MoltenHamaxe,
                [(ItemID.HellstoneBar, 8), (ItemID.AshWood, 24), (ItemID.BeeWax, 8)], [TileID.Hellforge],
                [Condition.InUnderworld, Condition.NearLava], [("WarAxeoftheNight", 1)]);

        RecipeHelper.AddRecipe(ItemID.CobaltWaraxe, [(ItemID.CobaltBar, 16), (ItemID.MoltenHamaxe, 1)], [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.PalladiumWaraxe, [(ItemID.PalladiumBar, 16), (ItemID.MoltenHamaxe, 1)], [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.MythrilWaraxe, [(ItemID.MythrilBar, 16)], [TileID.MythrilAnvil], recipeGroups: [("CobaltWaraxe", 1)]);

        RecipeHelper.AddRecipe(ItemID.OrichalcumWaraxe, [(ItemID.OrichalcumBar, 16)], [TileID.MythrilAnvil], recipeGroups: [("CobaltWaraxe", 1)]);

        RecipeHelper.AddRecipe(ItemID.AdamantiteWaraxe, [(ItemID.AdamantiteBar, 16)], [TileID.MythrilAnvil], recipeGroups: [("MythrilWaraxe", 1)]);

        RecipeHelper.AddRecipe(ItemID.TitaniumWaraxe, [(ItemID.TitaniumBar, 16)], [TileID.MythrilAnvil], recipeGroups: [("MythrilWaraxe", 1)]);

        RecipeHelper.AddRecipe(ItemID.CobaltChainsaw, [(ItemID.CobaltBar, 14), (ItemID.MoltenHamaxe, 1)], [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.PalladiumChainsaw, [(ItemID.PalladiumBar, 14), (ItemID.MoltenHamaxe, 1)], [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.MythrilChainsaw, [(ItemID.MythrilBar, 14)], [TileID.MythrilAnvil], recipeGroups: [("CobaltChainsaw", 1)]);

        RecipeHelper.AddRecipe(ItemID.OrichalcumChainsaw, [(ItemID.OrichalcumBar, 14)], [TileID.MythrilAnvil], recipeGroups: [("CobaltChainsaw", 1)]);

        RecipeHelper.AddRecipe(ItemID.AdamantiteChainsaw, [(ItemID.AdamantiteBar, 14)], [TileID.MythrilAnvil], recipeGroups: [("MythrilChainsaw", 1)]);

        RecipeHelper.AddRecipe(ItemID.TitaniumChainsaw, [(ItemID.TitaniumBar, 14)], [TileID.MythrilAnvil], recipeGroups: [("MythrilChainsaw", 1)]);
    }
}

public class FishingPoles : GlobalItem
{
    public override void AddRecipes()
    {
        RecipeHelper.AddRecipe(ItemID.WoodFishingPole, [(ItemID.Wood, 24), (ItemID.Cobweb, 20), (ItemID.Acorn, 3)],
                [TileID.WorkBenches]);
    }
}

public class Hammers : GlobalItem
{
    public override void AddRecipes()
    {
        RecipeHelper.AddRecipe(ItemID.WoodenHammer, [(ItemID.Wood, 14), (ItemID.StoneBlock, 25)], [TileID.WorkBenches]);

        RecipeHelper.AddRecipe(ItemID.BorealWoodHammer, [(ItemID.BorealWood, 14), (ItemID.SnowBlock, 25)], [TileID.WorkBenches]);

        RecipeHelper.AddRecipe(ItemID.RichMahoganyHammer, [(ItemID.RichMahogany, 14), (ItemID.MudBlock, 25)], [TileID.WorkBenches]);

        RecipeHelper.AddRecipe(ItemID.PalmWoodHammer, [(ItemID.PalmWood, 14), (ItemID.SandBlock, 25)], [TileID.WorkBenches]);

        RecipeHelper.AddRecipe(ItemID.AshWoodHammer, [(ItemID.AshWood, 14), (ItemID.AshBlock, 25)], [TileID.Hellforge]);

        RecipeHelper.AddRecipe(ItemID.EbonwoodHammer, [(ItemID.Ebonwood, 14), (ItemID.VilePowder, 2)], [TileID.WorkBenches]);

        RecipeHelper.AddRecipe(ItemID.ShadewoodHammer, [(ItemID.Shadewood, 14), (ItemID.ViciousPowder, 2)], [TileID.WorkBenches]);

        RecipeHelper.AddRecipe(ItemID.PearlwoodHammer, [(ItemID.Pearlwood, 14), (ItemID.PearlstoneBlock, 25)], [TileID.WorkBenches]);

        RecipeHelper.AddRecipe(ItemID.CopperHammer, [(ItemID.CopperBar, 10)], recipeGroups: [("Wood", 6)],
                tiles: [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.TinHammer, [(ItemID.TinBar, 10)], recipeGroups: [("Wood", 6)],
                tiles: [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.IronHammer, [(ItemID.IronBar, 10)], recipeGroups: [("CopperHammer", 1)],
                tiles: [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.LeadHammer, [(ItemID.LeadBar, 10)], recipeGroups: [("CopperHammer", 1)],
                tiles: [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.SilverHammer, [(ItemID.SilverBar, 10), (ItemID.Sapphire, 1)],
                recipeGroups: [("IronHammer", 1)], tiles: [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.TungstenHammer, [(ItemID.TungstenBar, 10), (ItemID.Sapphire, 1)],
                recipeGroups: [("IronHammer", 1)], tiles: [TileID.Anvils]);

        RecipeHelper.AddRecipe(ItemID.GoldHammer, [(ItemID.GoldBar, 10), (ItemID.Ruby, 1)],
                recipeGroups: [("SilverHammer", 1)], tiles: [TileID.HeavyWorkBench]);

        RecipeHelper.AddRecipe(ItemID.PlatinumHammer, [(ItemID.PlatinumBar, 10), (ItemID.Ruby, 1)],
                recipeGroups: [("SilverHammer", 1)], tiles: [TileID.HeavyWorkBench]);

        RecipeHelper.AddRecipe(ItemID.TheBreaker, [(ItemID.DemoniteBar, 10), (ItemID.Ebonwood, 24)],
                recipeGroups: [("GoldHammer", 1)], tiles: [TileID.DemonAltar], conditions: [Condition.InCorrupt]);

        RecipeHelper.AddRecipe(ItemID.FleshGrinder, [(ItemID.CrimtaneBar, 10), (ItemID.Shadewood, 24)],
                recipeGroups: [("GoldHammer", 1)], tiles: [TileID.DemonAltar], conditions: [Condition.InCrimson]);
    }
}
