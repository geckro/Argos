using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace Argos.Common.GlobalItems;

public class CactusPickaxeChange : GlobalItem
{
    public override bool AppliesToEntity(Item item,
            bool lateInstantiation) =>
            item.type == ItemID.CactusPickaxe;

    public override void SetDefaults(Item item)
    {
        item.StatsModifiedBy.Add(Mod);
        item.tileBoost = -1;
    }
}

public class CopperPickaxeChange : GlobalItem
{
    public override bool AppliesToEntity(Item item,
            bool lateInstantiation) =>
            item.type == ItemID.CopperPickaxe;

    public override void SetDefaults(Item item)
    {
        item.StatsModifiedBy.Add(Mod);
        item.tileBoost = 0;
    }
}

public class ZenithChange : GlobalItem
{
    public override bool AppliesToEntity(Item item,
            bool lateInstantiation) =>
            item.type == ItemID.Zenith;

    public override void SetDefaults(Item item)
    {
        if (EnabledMods.AnyContentModEnabled)
        {
            return;
        }

        item.useTime = 1; // is originally 30, :troll:
    }

    public override bool Shoot(Item item,
            Player player,
            EntitySource_ItemUse_WithAmmo source,
            Vector2 position,
            Vector2 velocity,
            int type,
            int damage,
            float knockback)
    {
        Vector2 target = Main.screenPosition + new Vector2(Main.mouseX, Main.mouseY);
        float ceilingLimit = target.Y;
        if (ceilingLimit > player.Center.Y - 200f)
        {
            ceilingLimit = player.Center.Y - 200f;
        }

        for (int i = 0; i < 2; i++)
        {
            position = player.Center - new Vector2(Main.rand.NextFloat(401) * player.direction, 600f);
            position.Y -= 100 * i;
            Vector2 heading = target - position;

            if (heading.Y < 0f)
            {
                heading.Y *= -1f;
            }

            if (heading.Y < 20f)
            {
                heading.Y = 20f;
            }

            heading.Normalize();
            heading *= velocity.Length();
            heading.X = +Main.rand.Next(-20, 21) * 5f;
            heading.Y += Main.rand.Next(-40, 41) * 2f;
            Projectile.NewProjectile(source, position, heading, ProjectileID.FallingStar, damage * 2, knockback,
                    player.whoAmI, 0f, ceilingLimit);
            Projectile.NewProjectile(source, position, heading, ProjectileID.LunarFlare, damage * 2, knockback,
                    player.whoAmI);
        }

        return true;
    }
}
