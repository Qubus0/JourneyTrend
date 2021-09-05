using Terraria.DataStructures;

namespace JourneyTrend.Items.Vanity.NineTailedFox
{
    public class NineTailedFoxAccAnimatedDrawLayer : AnimatedDrawLayer
    {
        public NineTailedFoxAccAnimatedDrawLayer() : base(
            "JourneyTrend/Items/Vanity/NineTailedFox/NineTailedFoxAcc_Tails", 
            -3, 
            -31,
            false,
            11
        ){}
        
        // // if it will be rendered on the minimap. probably needs to be parented to head. might be bugged in tml
        // public override bool IsHeadLayer => true;
        // before/after from back to front - behind/in front
        public override Position GetDefaultPosition() => new AfterParent(PlayerDrawLayers.Wings); 
        
        public override bool GetDefaultVisibility(PlayerDrawSet drawInfo)
        {
            var modPlayer = drawInfo.drawPlayer.GetModPlayer<JourneyPlayer>();
            return modPlayer.NineTailedFoxAccEquipped && !drawInfo.drawPlayer.dead;
        }
        protected override int GetFrameIndex(JourneyPlayer journeyPlayer) => journeyPlayer.NineTailedFoxFrameIndex;
    }
}