using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.WitchsVoid
{
    public class WitchsVoidHeadGlowDrawLayer : GlowDrawLayer
    {
        public WitchsVoidHeadGlowDrawLayer() : base(
            "JourneyTrend/Items/Vanity/WitchsVoid/WitchsVoidHead_Glow")
        {
        }

        // // if it will be rendered on the minimap. probably needs to be parented to head. might be bugged in tml
        public override bool IsHeadLayer => true;

        // before/after from back to front - behind/in front
        public override Position GetDefaultPosition() => new AfterParent(PlayerDrawLayers.Head);

        protected override Rectangle GetPlayerFrame(PlayerDrawSet drawInfo) => drawInfo.drawPlayer.bodyFrame;

        public override bool GetDefaultVisibility(PlayerDrawSet drawInfo)
        {
            return drawInfo.drawPlayer.head == Mod.GetEquipSlot("WitchsVoidHead", EquipType.Head)
                   && !drawInfo.drawPlayer.dead;
        }
    }
}