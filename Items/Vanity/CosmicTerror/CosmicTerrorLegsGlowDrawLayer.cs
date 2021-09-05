using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.CosmicTerror
{
    public class CosmicTerrorLegsGlowDrawLayer : GlowDrawLayer
    {
        public CosmicTerrorLegsGlowDrawLayer() : base(
            "JourneyTrend/Items/Vanity/CosmicTerror/CosmicTerrorLegs_Glow")
        {
        }

        // before/after from back to front - behind/in front
        public override Position GetDefaultPosition() => new AfterParent(PlayerDrawLayers.Shoes);

        protected override Rectangle GetPlayerFrame(PlayerDrawSet drawInfo) => drawInfo.drawPlayer.legFrame;
        
        public override bool GetDefaultVisibility(PlayerDrawSet drawInfo)
        {
            return drawInfo.drawPlayer.legs == Mod.GetEquipSlot("CosmicTerrorLegs", EquipType.Legs)
                   && !drawInfo.drawPlayer.dead;
        }
    }
}