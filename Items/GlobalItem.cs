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
				player.QuickSpawnItem(ItemType<Vanity.MagicGrill.MagicGrillHead>(), 1);
				player.QuickSpawnItem(ItemType<Vanity.MagicGrill.MagicGrillBody>(), 1);
				player.QuickSpawnItem(ItemType<Vanity.MagicGrill.MagicGrillLegs>(), 1);
			}

            if (context == "crate" && arg == ItemID.WoodenCrate && Main.rand.Next(40) < 1)
            {
				player.QuickSpawnItem(ItemType<Vanity.Treesuit.TreesuitHead>(), 1);
				player.QuickSpawnItem(ItemType<Vanity.Treesuit.TreesuitBody>(), 1);
				player.QuickSpawnItem(ItemType<Vanity.Treesuit.TreesuitLegs>(), 1);
			}
		}
	}

	public class FallingStar : GlobalProjectile
    {
        public override bool OnTileCollide(Projectile projectile, Vector2 oldVelocity)
        {
			if (projectile.type == 12 && projectile.damage > 500 && Main.rand.Next(300) < 1)
			{
				Item.NewItem(projectile.Hitbox, ItemType<Vanity.StarlightDream.StarlightDreamBag>());
			}
			return base.OnTileCollide(projectile, oldVelocity);
        }
    }

	public class Offset : GlobalItem
    {
        public override void UseStyle(Item item, Player player)
        {
			if (player.GetModPlayer<JourneyPlayer>().doOffset)		//updated in RookieBody.cs
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
				Item.NewItem(item.Hitbox, ItemType<Vanity.Rookie.Hotwings>());
				return;
			}
		}
	}
}