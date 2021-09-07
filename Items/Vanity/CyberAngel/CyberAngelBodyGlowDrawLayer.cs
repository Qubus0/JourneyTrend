using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.CyberAngel
{
    public class CyberAngelBodyGlowDrawLayer : GlowDrawLayer
    {
        public CyberAngelBodyGlowDrawLayer() : base(
            "JourneyTrend/Items/Vanity/CyberAngel/CyberAngelBody_Glow")
        {
        }
        
        // before/after from back to front - behind/in front
        public override Position GetDefaultPosition() => new AfterParent(PlayerDrawLayers.Torso);
        
        protected override Rectangle GetPlayerFrame(PlayerDrawSet drawInfo) => drawInfo.drawPlayer.bodyFrame;

        public override bool GetDefaultVisibility(PlayerDrawSet drawInfo)
        {
            return drawInfo.drawPlayer.body == Mod.GetEquipSlot("CyberAngelBody", EquipType.Body)
                   && !drawInfo.drawPlayer.dead;
        }
    }
}