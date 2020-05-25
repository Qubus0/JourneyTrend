using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace JourneyTrend.Items.Vanity.Hivenet
{
	public class HivenetDust : ModDust
	{
		public override void OnSpawn(Dust dust) {
			dust.noGravity = true;
			dust.noLight = true;
			dust.rotation = 1.5707f * (dust.dustIndex % 4);
			dust.frame = new Rectangle(0, Main.rand.Next(4) * 10, 8, 10);
			//								  num frames^ height^, width, height
			dust.scale = 1.25f;
		}

		public override bool Update(Dust dust) {

			int oldAlpha = dust.alpha;
			dust.alpha = (int)(dust.alpha * 1.05);
			if (dust.alpha == oldAlpha) {
				dust.alpha++;
			}
			if (dust.alpha >= 255) {
				dust.alpha = 255;
				dust.active = false;
			}

			if(dust.alpha > 100) {
				dust.frame = new Rectangle(0, Main.rand.Next(4) * 10, 8, 10);
			}
			return false;
		}
	}
}


