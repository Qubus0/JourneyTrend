using JourneyTrend.Items.Vanity.MagicGrill;
using JourneyTrend.Items.Vanity.Rookie;
using JourneyTrend.Items.Vanity.StarlightDream;
using JourneyTrend.Items.Vanity.Treesuit;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JourneyTrend.Items
{
    public class BossBags : GlobalItem
    {
        public override void OpenVanillaBag(string context, Player player, int arg)
        {
            if (context == "bossBag" && arg == ItemID.FishronBossBag && Main.rand.Next(10) < 1)
            {
                player.QuickSpawnItem(ItemType<MagicGrillHead>());
                player.QuickSpawnItem(ItemType<MagicGrillBody>());
                player.QuickSpawnItem(ItemType<MagicGrillLegs>());
            }

            if (context == "crate" && arg == ItemID.WoodenCrate && Main.rand.Next(40) < 1)
            {
                player.QuickSpawnItem(ItemType<TreesuitHead>());
                player.QuickSpawnItem(ItemType<TreesuitBody>());
                player.QuickSpawnItem(ItemType<TreesuitLegs>());
            }
        }
    }

    public class FallingStar : GlobalProjectile
    {
        public override bool OnTileCollide(Projectile projectile, Vector2 oldVelocity)
        {
            if (projectile.type == 12 && projectile.damage > 500 && Main.rand.Next(300) < 1)
                Item.NewItem(projectile.Hitbox, ItemType<StarlightDreamBag>());
            return base.OnTileCollide(projectile, oldVelocity);
        }
    }

    public class Offset : GlobalItem
    {
        public override void UseStyle(Item item, Player player, Rectangle rectangle)
        {
            if (player.GetModPlayer<JourneyPlayer>().doOffset) //updated in RookieBody.cs
            {
                player.itemLocation.X += 2;
                player.itemLocation.Y += 8;
                player.GetModPlayer<JourneyPlayer>().doOffset = false;
            }
        }
    }

    public class HarpyWings : GlobalItem
    {
        public override void Update(Item item, ref float gravity, ref float maxFallSpeed)
        {
            if (item.type == ItemID.HarpyWings && item.lavaWet)
            {
                item.TurnToAir();
                Item.NewItem(item.Hitbox, ItemType<Hotwings>());
            }
        }
    }
}