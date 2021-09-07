using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Nightlight
{
    public class NightlightBodyGlowDrawLayer : GlowDrawLayer
    {
        public NightlightBodyGlowDrawLayer() : base(
            "JourneyTrend/Items/Vanity/Nightlight/NightlightBody_Glow")
        {
        }
        
        // before/after from back to front - behind/in front
        public override Position GetDefaultPosition() => new AfterParent(PlayerDrawLayers.Torso);
        
        protected override Rectangle GetPlayerFrame(PlayerDrawSet drawInfo) => drawInfo.drawPlayer.bodyFrame;

        public override bool GetDefaultVisibility(PlayerDrawSet drawInfo)
        {
            return drawInfo.drawPlayer.body == Mod.GetEquipSlot("NightlightBody", EquipType.Body)
                   && !drawInfo.drawPlayer.dead;
        }
    }
}