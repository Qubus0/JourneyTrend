using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.ShadowFiend
{
    public class ShadowFiendDust1 : ModDust
    {
        public override void OnSpawn(Dust dust)
        {
            dust.frame = new Rectangle(0, Main.rand.Next(2) * 8, 8, 8);
            //								  num frames^ height^, width, height
        }

        public override bool Update(Dust dust)
        {
            //dust.velocity.Y += 0.3f;
            dust.scale -= 0.01f;
            if (dust.scale < 0.2f) dust.active = false;
            return false;
        }

        public override Color? GetAlpha(Dust dust, Color lightColor)
        {
            return new Color(255, 255, 255);
        }
    }
}