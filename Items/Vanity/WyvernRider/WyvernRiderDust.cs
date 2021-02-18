using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.WyvernRider
{
    public class WyvernRiderDust : ModDust
    {
        public override void OnSpawn(Dust dust)
        {
            dust.noGravity = true;
            dust.scale = 1f;
            dust.velocity.X *= 0.3f;
        }

        public override bool Update(Dust dust)
        {
            dust.scale -= 0.02f;
            if (dust.scale < 0.2f) dust.active = false;
            return false;
        }

        public override Color? GetAlpha(Dust dust, Color lightColor)
        {
            return new Color(255, 255, 255);
        }
    }
}