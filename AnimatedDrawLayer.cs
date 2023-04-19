using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace JourneyTrend
{
    public abstract class AnimatedDrawLayer : PlayerDrawLayer
    {
        private readonly string AnimationTexturePath;
        private readonly int SpritePositionOffsetX;
        private readonly int SpritePositionOffsetY;
        private readonly bool Glow;
        private readonly int FrameCount;

        protected AnimatedDrawLayer(
            string animationTexturePath,
            int spritePositionOffsetX,
            int spritePositionOffsetY,
            bool glow,
            int frameCount
            )
        {
            AnimationTexturePath = animationTexturePath;
            SpritePositionOffsetX = spritePositionOffsetX;
            SpritePositionOffsetY = spritePositionOffsetY;
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
            Rectangle? currentFrame = new Rectangle(0, currentFrameIndex * frameHeight, PartTexture.Width(), frameHeight);
            
            var renderPosition =
                new Vector2(drawInfo.Center.X, drawInfo.Center.Y + modPlayer.walkUpShift)
                + new Vector2(SpritePositionOffsetX * drawInfo.drawPlayer.direction, SpritePositionOffsetY)
                - Main.screenPosition;
            renderPosition = new Vector2((int) renderPosition.X, (int) renderPosition.Y); // to avoid quivering.

            var flipHorizontally =
                drawInfo.drawPlayer.direction == 1 ? SpriteEffects.None : SpriteEffects.FlipHorizontally;
            var flipVertically =
                (int) drawInfo.drawPlayer.gravDir == 1 ? SpriteEffects.None : SpriteEffects.FlipVertically;

            drawInfo.DrawDataCache.Add(
                new DrawData(
                    PartTexture.Value, //The texture to render.
                    renderPosition,
                    currentFrame,
                    Glow ? Color.White : drawInfo.colorArmorBody,
                    0f, //Rotation.
                    new Vector2(PartTexture.Width() * 0.5f, 0), //Origin. Uses the width center.
                    1f, //Scale.
                    flipHorizontally | flipVertically,
                    0 //'Layer'. This is always 0 in Terraria.
                ));
        }
    }
}