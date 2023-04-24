using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.ShadowFiend
{
    public class ShadowFiendLegs1GlowDrawLayer : GlowDrawLayer
    {
        public ShadowFiendLegs1GlowDrawLayer() : base(
            "JourneyTrend/Items/Vanity/ShadowFiend/ShadowFiendLegs1_Legs_Glow")
        {
        }
        
        // before/after from back to front - behind/in front
        public override Position GetDefaultPosition() => new AfterParent(PlayerDrawLayers.Shoes);

        protected override Rectangle GetPlayerFrame(PlayerDrawSet drawInfo) => drawInfo.drawPlayer.legFrame;

        public override bool GetDefaultVisibility(PlayerDrawSet drawInfo)
        {
            return drawInfo.drawPlayer.legs == EquipLoader.GetEquipSlot(Mod, nameof(ShadowFiendLegs1), EquipType.Legs)
                   && !drawInfo.drawPlayer.dead;
        }
    }
}