using Terraria.DataStructures;

namespace JourneyTrend.Items.Vanity.Knightwalker
{
    public class KnightwalkerBodyAnimatedDrawLayerMovingCape : AnimatedDrawLayer
    {
        private const string AnimationTexturePath =
            "JourneyTrend/Items/Vanity/Knightwalker/KnightwalkerBody_AnimatedMovingCape";

        private const int SpritePositionOffsetX = -1;
        private const int SpritePositionOffsetY = -32;
        private const float Glow = 1f;
        private const int FrameCount = 20;


        public KnightwalkerBodyAnimatedDrawLayerMovingCape() : base(AnimationTexturePath, SpritePositionOffsetX,
            SpritePositionOffsetY, Glow, FrameCount)
        {
        }

        protected override int GetFrameIndex(JourneyPlayer journeyPlayer)
        {
            return journeyPlayer.GetPlayerBodyFrameYIndex();
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
            return !drawInfo.drawPlayer.dead && !player.IsIdle() && player.KnightwalkerBodyEquipped;
        }
    }
}