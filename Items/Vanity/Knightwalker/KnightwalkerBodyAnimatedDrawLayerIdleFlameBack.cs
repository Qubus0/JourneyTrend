using Terraria.DataStructures;

namespace JourneyTrend.Items.Vanity.Knightwalker
{
    public class KnightwalkerBodyAnimatedDrawLayerIdleFlameBack : AnimatedDrawLayer
    {
        private const string AnimationTexturePath =
            "JourneyTrend/Items/Vanity/Knightwalker/KnightwalkerBody_AnimatedIdleFlameBack";

        private const int SpritePositionOffsetX = -3;
        private const int SpritePositionOffsetY = -26;
        private const float Glow = 1f;
        private const int FrameCount = 8;


        public KnightwalkerBodyAnimatedDrawLayerIdleFlameBack() : base(AnimationTexturePath, SpritePositionOffsetX,
            SpritePositionOffsetY, Glow, FrameCount)
        {
        }

        protected override int GetFrameIndex(JourneyPlayer journeyPlayer)
        {
            return journeyPlayer.KnightwalkerBodyIdleFlameAnimationFrameCounter.GetFrameIndex();
        }

        protected override int GetShader(PlayerDrawSet drawInfo) => drawInfo.cBody;

        // before/after from back to front - behind/in front
        public override Position GetDefaultPosition() => new AfterParent(PlayerDrawLayers.Torso);

        public override bool GetDefaultVisibility(PlayerDrawSet drawInfo)
        {
            JourneyPlayer player = drawInfo.drawPlayer.GetModPlayer<JourneyPlayer>();
            return !drawInfo.drawPlayer.dead && player.IsIdle() && player.KnightwalkerBodyEquipped;
        }
    }
}