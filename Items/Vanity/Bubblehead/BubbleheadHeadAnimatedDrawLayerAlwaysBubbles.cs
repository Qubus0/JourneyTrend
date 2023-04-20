using Terraria.DataStructures;

namespace JourneyTrend.Items.Vanity.Bubblehead
{
    public class BubbleheadHeadAnimatedDrawLayerAlwaysBubbles : AnimatedDrawLayer
    {
        private const string AnimationTexturePath = "JourneyTrend/Items/Vanity/Bubblehead/BubbleheadHead_Head_AnimatedAlwaysBubbles";
        private const int SpritePositionOffsetX = 0;
        private const int SpritePositionOffsetY = -28;
        private const float Glow = 0f;
        public const int FrameCount = 14;

        public BubbleheadHeadAnimatedDrawLayerAlwaysBubbles() : base(AnimationTexturePath, SpritePositionOffsetX, SpritePositionOffsetY, Glow, FrameCount)
        {
        }

        protected override int GetFrameIndex(JourneyPlayer journeyPlayer)
        {
            journeyPlayer.BubbleheadHeadAnimationFrameCounter.NextFrame();
            return journeyPlayer.BubbleheadHeadAnimationFrameCounter.GetFrameIndex();
        }

        // if it will be rendered on the minimap. needs to be parented to head.
        public override bool IsHeadLayer => true;

        // before/after from back to front - behind/in front
        public override Position GetDefaultPosition() => new AfterParent(PlayerDrawLayers.Head);

        public override bool GetDefaultVisibility(PlayerDrawSet drawInfo)
        {
            JourneyPlayer player = drawInfo.drawPlayer.GetModPlayer<JourneyPlayer>();
            return !drawInfo.drawPlayer.dead && player.BubbleheadHeadEquipped;
        }
    }
}