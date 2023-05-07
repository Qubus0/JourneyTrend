using Terraria.DataStructures;

namespace JourneyTrend.Items.Vanity.Knightwalker
{
    public class KnightwalkerBodyAnimatedDrawLayerIdleCape : AnimatedDrawLayer
    {
        private const string AnimationTexturePath =
            "JourneyTrend/Items/Vanity/Knightwalker/KnightwalkerBody_AnimatedIdleCape";

        private const int SpritePositionOffsetX = -5;
        private const int SpritePositionOffsetY = -10;
        private const float Glow = 1f;
        public const int FrameCount = 20;


        public KnightwalkerBodyAnimatedDrawLayerIdleCape() : base(AnimationTexturePath, SpritePositionOffsetX,
            SpritePositionOffsetY, Glow, FrameCount)
        {
        }

        protected override int GetFrameIndex(JourneyPlayer journeyPlayer)
        {
            if (journeyPlayer.IsIdle())
                journeyPlayer.KnightwalkerBodyIdleCapeAnimationFrameCounter.NextFrame();
            return journeyPlayer.KnightwalkerBodyIdleCapeAnimationFrameCounter.GetFrameIndex();
        }

        protected override int GetShader(PlayerDrawSet drawInfo)
        {
            return drawInfo.cBody;
        }

        // before/after from back to front - behind/in front
        public override Position GetDefaultPosition() => new BeforeParent(PlayerDrawLayers.BackAcc);

        public override bool GetDefaultVisibility(PlayerDrawSet drawInfo)
        {
            JourneyPlayer player = drawInfo.drawPlayer.GetModPlayer<JourneyPlayer>();
            return !drawInfo.drawPlayer.dead && player.IsIdle() && player.KnightwalkerBodyEquipped;
        }
    }
}