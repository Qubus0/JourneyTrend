using Microsoft.Xna.Framework;
using Terraria;

namespace JourneyTrend.Items.Vanity.Knightwalker
{
    public class KnightwalkerDust : AbstractDust
    {
        private const float Glow = 1f;
        private const int FrameCount = 3;
        
        public KnightwalkerDust() : base(Glow, FrameCount)
        {
        }
        
        protected override void SpawnEffects(Dust dust)
        {
            dust.velocity = new Vector2(0, -1f);
            dust.scale = 1;
            dust.customData ??= 1f;
        }

        protected override int GetFrameIndex()
        {
            return Main.rand.Next(FrameCount);
        }
        
        public override Color? GetAlpha(Dust dust, Color lightColor)
        {
            return Color.White * (float) dust.customData;
        }

        public override bool Update(Dust dust)
        {
            if (Main.rand.NextBool(10))
                NextFrame(dust);
            
            dust.position += dust.velocity;

            var glow = (float) dust.customData;
            var reducedGlow = glow - 0.01f;
            if (reducedGlow < 0.8f)
                reducedGlow-= 0.06f;
            dust.customData = reducedGlow;
            
            if (reducedGlow < 0f) dust.active = false;

            return false;
        }
    }
}