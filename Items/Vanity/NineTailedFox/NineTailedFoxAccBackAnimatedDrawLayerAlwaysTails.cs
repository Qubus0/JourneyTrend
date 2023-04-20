using Terraria.DataStructures;

namespace JourneyTrend.Items.Vanity.NineTailedFox
{
    public class NineTailedFoxAccBackAnimatedDrawLayerAlwaysTails : AnimatedDrawLayer
    {
        private const string AnimationTexturePath = "JourneyTrend/Items/Vanity/NineTailedFox/NineTailedFoxAccBack_AnimatedAlwaysTails";
        private const int SpritePositionOffsetX = -4;
        private const int SpritePositionOffsetY = -32;
        private const float Glow = 0f;
        public const int FrameCount = 11;
        

        public NineTailedFoxAccBackAnimatedDrawLayerAlwaysTails() : base(AnimationTexturePath, SpritePositionOffsetX, SpritePositionOffsetY, Glow, FrameCount)
        {
        }
        
        protected override int GetFrameIndex(JourneyPlayer journeyPlayer)
        {
            journeyPlayer.NineTailedFoxAccBackAnimationFrameCounter.NextFrame();
            return journeyPlayer.IsJumping() ? 10 : journeyPlayer.NineTailedFoxAccBackAnimationFrameCounter.GetFrameIndex();
        }

        // before/after from back to front - behind/in front
        public override Position GetDefaultPosition() => new AfterParent(PlayerDrawLayers.Wings);

        public override bool GetDefaultVisibility(PlayerDrawSet drawInfo)
        {
            JourneyPlayer player = drawInfo.drawPlayer.GetModPlayer<JourneyPlayer>();
            return !drawInfo.drawPlayer.dead && player.NineTailedFoxAccBackEquipped;
        }
    }

}