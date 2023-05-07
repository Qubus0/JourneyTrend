using Terraria.DataStructures;

namespace JourneyTrend.Items.Vanity.Planetary
{
    public class PlanetaryHeadAnimatedDrawLayerAlwaysStars : AnimatedDrawLayer
    {
        private const string AnimationTexturePath = "JourneyTrend/Items/Vanity/Planetary/PlanetaryHead_Head_AnimatedAlwaysStars";
        private const int SpritePositionOffsetX = 1;
        private const int SpritePositionOffsetY = -28;
        private const float Glow = 1f;
        public const int FrameCount = 4;
        

        public PlanetaryHeadAnimatedDrawLayerAlwaysStars() : base(AnimationTexturePath, SpritePositionOffsetX, SpritePositionOffsetY, Glow, FrameCount)
        {
        }
        
        protected override int GetFrameIndex(JourneyPlayer journeyPlayer)
        {
            journeyPlayer.PlanetaryHeadAlwaysStarsFrameCounter.NextFrame();
            return journeyPlayer.PlanetaryHeadAlwaysStarsFrameCounter.GetFrameIndex();
        }
        
        protected override int GetShader(PlayerDrawSet drawInfo) => drawInfo.cHead;

        // if it will be rendered on the minimap. needs to be parented to head.
        public override bool IsHeadLayer => true;

        // before/after from back to front - behind/in front
        public override Position GetDefaultPosition() => new AfterParent(PlayerDrawLayers.Head);

        public override bool GetDefaultVisibility(PlayerDrawSet drawInfo)
        {
            JourneyPlayer player = drawInfo.drawPlayer.GetModPlayer<JourneyPlayer>();
            return !drawInfo.drawPlayer.dead && player.PlanetaryHeadEquipped;
        }
    }

}