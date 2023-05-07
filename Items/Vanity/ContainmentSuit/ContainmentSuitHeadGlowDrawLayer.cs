using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.ContainmentSuit
{
    public class ContainmentSuitHeadGlowDrawLayer : GlowDrawLayer
    {
        public ContainmentSuitHeadGlowDrawLayer() : base(
            "JourneyTrend/Items/Vanity/ContainmentSuit/ContainmentSuitHead_Glow")
        {
        }

        // // if it will be rendered on the minimap. needs to be parented to head.
        public override bool IsHeadLayer => true;

        // before/after from back to front - behind/in front
        public override Position GetDefaultPosition() => new AfterParent(PlayerDrawLayers.Head);
        
        protected override Rectangle GetPlayerFrame(PlayerDrawSet drawInfo) => drawInfo.drawPlayer.bodyFrame;
        protected override int GetShader(PlayerDrawSet drawInfo) => drawInfo.cHead;

        public override bool GetDefaultVisibility(PlayerDrawSet drawInfo)
        {
            return drawInfo.drawPlayer.head == EquipLoader.GetEquipSlot(Mod, "ContainmentSuitHead", EquipType.Head)
                   && !drawInfo.drawPlayer.dead;
        }
    }
}