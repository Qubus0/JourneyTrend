using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Nexus
{
    public class NexusBodyGlowDrawLayer : GlowDrawLayer
    {
        public NexusBodyGlowDrawLayer() : base(
            "JourneyTrend/Items/Vanity/Nexus/NexusBody_Glow")
        {
        }
        
        // before/after from back to front - behind/in front
        public override Position GetDefaultPosition() => new AfterParent(PlayerDrawLayers.Torso);
        
        protected override Rectangle GetPlayerFrame(PlayerDrawSet drawInfo) => drawInfo.drawPlayer.bodyFrame;

        public override bool GetDefaultVisibility(PlayerDrawSet drawInfo)
        {
            return drawInfo.drawPlayer.body == EquipLoader.GetEquipSlot(Mod, "NexusBody", EquipType.Body)
                   && !drawInfo.drawPlayer.dead;
        }
    }
}