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
		}
	}

	public class FallingStar : GlobalProjectile
    {
        public override bool OnTileCollide(Projectile projectile, Vector2 oldVelocity)
        {
			if (projectile.type == 12 && projectile.damage > 500 && Main.rand.Next(20) < 1)
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
}