using Terraria.DataStructures;

namespace JourneyTrend.Items.Vanity.Knightwalker
{
    public class KnightwalkerHeadAnimatedDrawLayerAlwaysFlame : AnimatedDrawLayer
    {
        private const string AnimationTexturePath = "JourneyTrend/Items/Vanity/Knightwalker/KnightwalkerHead_Head_AnimatedAlwaysFlame";
        private const int SpritePositionOffsetX = 0;
        private const int SpritePositionOffsetY = -38;
        private const float Glow = 1f;
        public const int FrameCount = 8;
        

        public KnightwalkerHeadAnimatedDrawLayerAlwaysFlame() : base(AnimationTexturePath, SpritePositionOffsetX, SpritePositionOffsetY, Glow, FrameCount)
        {
        }
        
        protected override int GetFrameIndex(JourneyPlayer journeyPlayer)
        {
            journeyPlayer.KnightwalkerHeadAlwaysFlameAnimationFrameCounter.NextFrame();
            return journeyPlayer.KnightwalkerHeadAlwaysFlameAnimationFrameCounter.GetFrameIndex();
        }
        
        protected override int GetShader(PlayerDrawSet drawInfo) => drawInfo.cHead;

        // if it will be rendered on the minimap. needs to be parented to head.
        public override bool IsHeadLayer => true;

        // before/after from back to front - behind/in front
        public override Position GetDefaultPosition() => new AfterParent(PlayerDrawLayers.Head);

        public override bool GetDefaultVisibility(PlayerDrawSet drawInfo)
        {
            JourneyPlayer player = drawInfo.drawPlayer.GetModPlayer<JourneyPlayer>();
            return !drawInfo.drawPlayer.dead && player.KnightwalkerHeadEquipped;
        }
    }

}