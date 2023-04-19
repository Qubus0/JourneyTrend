using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace JourneyTrend
{
    public abstract class GlowDrawLayer : PlayerDrawLayer
    {
        private readonly string StaticTexturePath;
        private readonly int SpritePositionOffsetX;
        private readonly int SpritePositionOffsetY;

        protected GlowDrawLayer(
            string staticTexturePath,
            int spritePositionOffsetX = 0,
            int spritePositionOffsetY = 0)
        {
            StaticTexturePath = staticTexturePath;
            SpritePositionOffsetX = spritePositionOffsetX;
            SpritePositionOffsetY = spritePositionOffsetY;
        }

        private Asset<Texture2D> PartTexture;
        public override bool GetDefaultVisibility(PlayerDrawSet drawInfo) => !drawInfo.drawPlayer.dead;

        protected abstract Rectangle GetPlayerFrame(PlayerDrawSet drawInfo);

        protected override void Draw(ref PlayerDrawSet drawInfo)
        {
            PartTexture ??= ModContent.Request<Texture2D>(StaticTexturePath); // if null, request
            var currentFrame = GetPlayerFrame(drawInfo);
            
            var renderPosition =
                drawInfo.Center
                + new Vector2(SpritePositionOffsetX * drawInfo.drawPlayer.direction, SpritePositionOffsetY -31)
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
                    Color.White,
                    0f, //Rotation.
                    new Vector2(PartTexture.Width() * 0.5f, 0), //Origin. Uses the width center.
                    1f, //Scale.
                    flipHorizontally | flipVertically,
                    0 //'Layer'. This is always 0 in Terraria.
                ));
        }
    }
}