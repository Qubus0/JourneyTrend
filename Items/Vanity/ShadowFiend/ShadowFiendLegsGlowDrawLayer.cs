using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.ShadowFiend
{
    public class ShadowFiendLegsGlowDrawLayer : GlowDrawLayer
    {
        public ShadowFiendLegsGlowDrawLayer() : base(
            "JourneyTrend/Items/Vanity/ShadowFiend/ShadowFiendLegs_Legs_Glow")
        {
        }
        
        // before/after from back to front - behind/in front
        public override Position GetDefaultPosition() => new AfterParent(PlayerDrawLayers.Shoes);

        protected override Rectangle GetPlayerFrame(PlayerDrawSet drawInfo) => drawInfo.drawPlayer.legFrame;
        
        protected override int GetShader(PlayerDrawSet drawInfo) => drawInfo.cLegs;

        public override bool GetDefaultVisibility(PlayerDrawSet drawInfo)
        {
            return drawInfo.drawPlayer.legs == EquipLoader.GetEquipSlot(Mod, nameof(ShadowFiendLegs), EquipType.Legs)
                   && !drawInfo.drawPlayer.dead;
        }
    }
}