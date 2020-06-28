using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ExampleMod.Items
{
    public class BossBags : GlobalItem
	{
		public override void OpenVanillaBag(string context, Player player, int arg)
		{
			if (context == "bossBag" && arg == ItemID.FishronBossBag && Main.rand.Next(10) < 1)
			{
				player.QuickSpawnItem(ItemType<JourneyTrend.Items.Vanity.MagicGrill.MagicGrillHead>(), 1);
				player.QuickSpawnItem(ItemType<JourneyTrend.Items.Vanity.MagicGrill.MagicGrillBody>(), 1);
				player.QuickSpawnItem(ItemType<JourneyTrend.Items.Vanity.MagicGrill.MagicGrillLegs>(), 1);
			}
		}
	}

	public class FallingStar : GlobalProjectile
    {
        public override bool OnTileCollide(Projectile projectile, Vector2 oldVelocity)
        {
			if (projectile.type == 12 && projectile.damage > 500 && Main.rand.Next(20) < 1)
			{
				Item.NewItem(projectile.Hitbox, ItemType<JourneyTrend.Items.Vanity.StarlightDream.StarlightDreamBag>());
			}
			return base.OnTileCollide(projectile, oldVelocity);
        }
    }
}