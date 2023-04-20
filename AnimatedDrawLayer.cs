using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;
using ColorSlidersSet = On.Terraria.DataStructures.ColorSlidersSet;

namespace JourneyTrend
{
    public abstract class AnimatedDrawLayer : PlayerDrawLayer
    {
        private readonly string AnimationTexturePath;
        private readonly int SpritePositionOffsetX;
        private readonly int SpritePositionOffsetY;
        private readonly float Glow;
        private readonly int FrameCount;

        protected AnimatedDrawLayer(
            string animationTexturePath,
            int spritePositionOffsetX,
            int spritePositionOffsetY,
            float glow,
            int frameCount
        )
        {
            AnimationTexturePath = animationTexturePath;
            SpritePositionOffsetX = spritePositionOffsetX + 1; // offset to align with 2px grid
            SpritePositionOffsetY = spritePositionOffsetY + 1; // offset to align with 2px grid
            Glow = glow;
            FrameCount = frameCount;
        }

        private Asset<Texture2D> PartTexture;

        protected abstract int GetFrameIndex(JourneyPlayer journeyPlayer);

        protected override void Draw(ref PlayerDrawSet drawInfo)
        {
            var modPlayer = drawInfo.drawPlayer.GetModPlayer<JourneyPlayer>();

            PartTexture ??= ModContent.Request<Texture2D>(AnimationTexturePath); // if null, request
            var frameHeight = PartTexture.Height() / FrameCount;
            var currentFrameIndex = GetFrameIndex(modPlayer);
            Rectangle? currentFrame =
                new Rectangle(0, currentFrameIndex * frameHeight, PartTexture.Width(), frameHeight);

            var renderPosition =
                new Vector2(drawInfo.Center.X, drawInfo.Center.Y + modPlayer.GetWalkUpShift())
                + new Vector2(SpritePositionOffsetX * drawInfo.drawPlayer.direction, SpritePositionOffsetY)
                - Main.screenPosition;
            
            // round to ints to avoid quivering.
            renderPosition = new Vector2((int)renderPosition.X, (int)renderPosition.Y); 

            var flipHorizontally =
                drawInfo.drawPlayer.direction == 1 ? SpriteEffects.None : SpriteEffects.FlipHorizontally;
            var flipVertically =
                (int)drawInfo.drawPlayer.gravDir == 1 ? SpriteEffects.None : SpriteEffects.FlipVertically;


            // if full glow, use white color
            // if some glow, use the brighter color between either shaded or glow color
            // else, use the shaded color
            var drawInfoColor =
                Glow >= 1f ? Color.White
                : Glow > 0f ? GetColorBrightness(Color.White * Glow) > GetColorBrightness(drawInfo.colorArmorBody)
                    ? Color.White * Glow
                    : drawInfo.colorArmorBody
                : drawInfo.colorArmorBody;

            drawInfo.DrawDataCache.Add(
                new DrawData(
                    PartTexture.Value, // The texture to render.
                    renderPosition,
                    currentFrame,
                    drawInfoColor,
                    0f, // Rotation.
                    new Vector2(PartTexture.Width() * 0.5f, 0), // Origin. Uses the width center.
                    1f, // Scale.
                    flipHorizontally | flipVertically,
                    0 // 'Layer'. This is always 0 in Terraria.
                ));
        }

        private int GetColorBrightness(Color color)
        {
            // https://stackoverflow.com/questions/596216/formula-to-determine-brightness-of-rgb-color
            return (int)Math.Sqrt(
                color.R * color.R * .241 +
                color.G * color.G * .691 +
                color.B * color.B * .068);
        }
    }
}