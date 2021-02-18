using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.ShadowFiend
{
    public class ShadowFiendDust : ModDust
    {
        public override void OnSpawn(Dust dust)
        {
            dust.noGravity = true;
            dust.velocity.X *= 0.3f;
            dust.frame = new Rectangle(0, Main.rand.Next(2) * 6, 6, 6);
            //								  num frames^ height^, width, height
        }

        public override bool Update(Dust dust)
        {
            dust.rotation += Main.rand.NextFloat(0.3f);
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