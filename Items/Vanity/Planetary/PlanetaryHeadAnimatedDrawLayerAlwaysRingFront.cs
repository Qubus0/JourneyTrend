using Terraria.DataStructures;

namespace JourneyTrend.Items.Vanity.Planetary
{
    public class PlanetaryHeadAnimatedDrawLayerAlwaysRingFront : AnimatedDrawLayer
    {
        private const string AnimationTexturePath = "JourneyTrend/Items/Vanity/Planetary/PlanetaryHead_Head_AnimatedAlwaysRingFront";
        private const int SpritePositionOffsetX = 0;
        private const int SpritePositionOffsetY = -30;
        private const float Glow = .4f;
        public const int FrameCount = 4;
        

        public PlanetaryHeadAnimatedDrawLayerAlwaysRingFront() : base(AnimationTexturePath, SpritePositionOffsetX, SpritePositionOffsetY, Glow, FrameCount)
        {
        }
        
        protected override int GetFrameIndex(JourneyPlayer journeyPlayer)
        {
            journeyPlayer.PlanetaryHeadAlwaysRingFrameCounter.NextFrame();
            return journeyPlayer.PlanetaryHeadAlwaysRingFrameCounter.GetFrameIndex();
        }

        // if it will be rendered on the minimap. needs to be parented to head.
        public override bool IsHeadLayer => true;

        // before/after from back to front - behind/in front
        public override Position GetDefaultPosition() => new AfterParent(PlayerDrawLayers.FaceAcc);

        public override bool GetDefaultVisibility(PlayerDrawSet drawInfo)
        {
            JourneyPlayer player = drawInfo.drawPlayer.GetModPlayer<JourneyPlayer>();
            return !drawInfo.drawPlayer.dead && player.PlanetaryHeadEquipped;
        }
    }

}