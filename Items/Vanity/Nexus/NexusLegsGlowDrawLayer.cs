using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Nexus
{
    public class NexusLegsGlowDrawLayer : GlowDrawLayer
    {
        public NexusLegsGlowDrawLayer() : base(
            "JourneyTrend/Items/Vanity/Nexus/NexusLegs_Glow")
        {
        }

        // before/after from back to front - behind/in front
        public override Position GetDefaultPosition() => new AfterParent(PlayerDrawLayers.Shoes);

        protected override Rectangle GetPlayerFrame(PlayerDrawSet drawInfo) => drawInfo.drawPlayer.legFrame;
        
        public override bool GetDefaultVisibility(PlayerDrawSet drawInfo)
        {
            return drawInfo.drawPlayer.legs == EquipLoader.GetEquipSlot(Mod, "NexusLegs", EquipType.Legs)
                   && !drawInfo.drawPlayer.dead;
        }
    }
}