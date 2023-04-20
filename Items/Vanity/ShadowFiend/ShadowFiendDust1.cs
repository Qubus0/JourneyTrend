using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.ShadowFiend
{
    public class ShadowFiendDust1 : AbstractDust
    {
        private const float Glow = 1f;
        private const int FrameCount = 2;
        
        public ShadowFiendDust1() : base(Glow, FrameCount)
        {
        }

        protected override int GetFrameIndex()
        {
            return Main.rand.Next(FrameCount);
        }
        
        protected override void SpawnEffects(Dust dust)
        {
            dust.noGravity = false;
            dust.scale = 0.8f;
            dust.velocity = new Vector2(0, 0.003f); 
        }

        public override bool Update(Dust dust)
        {
            dust.position += dust.velocity;
            dust.velocity.Y += 0.003f;
            
            dust.scale -= 0.01f;
            if (dust.scale < 0.2f) dust.active = false;
            return false;
        }
    }
}