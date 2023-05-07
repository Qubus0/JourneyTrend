using Terraria.DataStructures;

namespace JourneyTrend.Items.Vanity.StarlightDream
{
    public class StarlightDreamBodyAnimatedDrawLayerAccBackCape : AnimatedDrawLayer
    {
        private const string AnimationTexturePath =
            "JourneyTrend/Items/Vanity/StarlightDream/StarlightDreamBody_AnimatedAccBackCape";

        private const int SpritePositionOffsetX = -1;
        private const int SpritePositionOffsetY = -34;
        private const float Glow = 0.3f;
        private const int FrameCount = 20;


        protected StarlightDreamBodyAnimatedDrawLayerAccBackCape() : base(AnimationTexturePath, SpritePositionOffsetX,
            SpritePositionOffsetY, Glow, FrameCount)
        {
        }

        protected override int GetFrameIndex(JourneyPlayer journeyPlayer)
        {
            return journeyPlayer.GetPlayerBodyFrameYIndex();
        }

        protected override int GetShader(PlayerDrawSet drawInfo) => drawInfo.cBody;

        // before/after from back to front - behind/in front
        public override Position GetDefaultPosition() => new BeforeParent(PlayerDrawLayers.BackAcc);

        public override bool GetDefaultVisibility(PlayerDrawSet drawInfo)
        {
            JourneyPlayer player = drawInfo.drawPlayer.GetModPlayer<JourneyPlayer>();
            return !drawInfo.drawPlayer.dead && player.StarlightDreamBodyEquipped;
        }
    }
}