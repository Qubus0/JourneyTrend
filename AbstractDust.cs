using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace JourneyTrend
{
    public abstract class AbstractDust : ModDust
    {
        private readonly float Glow;
        private readonly int FrameCount;

        protected AbstractDust(
            float glow,
            int frameCount
        )
        {
            Glow = glow;
            FrameCount = frameCount;
        }
        
        /// <summary>
        /// Override this method to return the frame index of the dust.
        /// <example>return Main.rand.Next(FrameCount); </example>
        /// </summary>
        protected abstract int GetFrameIndex();

        /// <summary>
        /// Override this method to add effects to the dust when it spawns.
        /// </summary>
        protected virtual void SpawnEffects(Dust dust)
        {
        }

        public override void OnSpawn(Dust dust)
        {
            int frameIndex = GetFrameIndex();
            int frameHeight = Texture2D.Height() / FrameCount;
            dust.frame = new Rectangle(0, frameIndex * frameHeight, Texture2D.Width(), frameHeight);
            SpawnEffects(dust);
        }

        protected void NextFrame(Dust dust)
        {
            int currentFrameIndex = dust.frame.Y / Texture2D.Height();
            int frameHeight = Texture2D.Height() / FrameCount;
            
            int nextFrameIndex = currentFrameIndex + 1;
            if (nextFrameIndex >= FrameCount)
                nextFrameIndex = 0;
            
            dust.frame = new Rectangle(0, nextFrameIndex * frameHeight, Texture2D.Width(), frameHeight);
        }

        public override Color? GetAlpha(Dust dust, Color lightColor)
        {
            return ApplyGlowToColor(Glow, lightColor);
        }

        private static Color ApplyGlowToColor(float glow, Color baseColor)
        {
            // if full glow, use white color
            if (glow >= 1f)
                return Color.White;

            // if some glow and white glow is brighter than the base color, use white color
            if (glow > 0f && GetColorBrightness(Color.White * glow) > GetColorBrightness(baseColor))
                return Color.White * glow;

            // else, use the shaded color
            return baseColor;
        }

        private static int GetColorBrightness(Color color)
        {
            // https://stackoverflow.com/questions/596216/formula-to-determine-brightness-of-rgb-color
            return (int)Math.Sqrt(
                color.R * color.R * .241 +
                color.G * color.G * .691 +
                color.B * color.B * .068);
        }
    }
}