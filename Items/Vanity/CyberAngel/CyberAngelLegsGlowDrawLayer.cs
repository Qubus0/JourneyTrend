using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.CyberAngel
{
    public class CyberAngelLegsGlowDrawLayer : GlowDrawLayer
    {
        public CyberAngelLegsGlowDrawLayer() : base(
            "JourneyTrend/Items/Vanity/CyberAngel/CyberAngelLegs_Glow")
        {
        }

        // before/after from back to front - behind/in front
        public override Position GetDefaultPosition() => new AfterParent(PlayerDrawLayers.Shoes);

        protected override Rectangle GetPlayerFrame(PlayerDrawSet drawInfo) => drawInfo.drawPlayer.legFrame;
        
        public override bool GetDefaultVisibility(PlayerDrawSet drawInfo)
        {
            return drawInfo.drawPlayer.legs == EquipLoader.GetEquipSlot(Mod, "CyberAngelLegs", EquipType.Legs)
                   && !drawInfo.drawPlayer.dead;
        }
    }
}