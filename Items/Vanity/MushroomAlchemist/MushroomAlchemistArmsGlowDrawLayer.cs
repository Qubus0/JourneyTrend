using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.MushroomAlchemist
{
    public class MushroomAlchemistArmsGlowDrawLayer : GlowDrawLayer
    {
        public MushroomAlchemistArmsGlowDrawLayer() : base(
            "JourneyTrend/Items/Vanity/MushroomAlchemist/MushroomAlchemistBody_ArmsGlow")
        {
        }

        // before/after from back to front - behind/in front
        public override Position GetDefaultPosition() => new AfterParent(PlayerDrawLayers.ArmOverItem);

        protected override Rectangle GetPlayerFrame(PlayerDrawSet drawInfo) => drawInfo.drawPlayer.bodyFrame;
        
        public override bool GetDefaultVisibility(PlayerDrawSet drawInfo)
        {
            return drawInfo.drawPlayer.body == Mod.GetEquipSlot("MushroomAlchemistBody", EquipType.Body)
                   && !drawInfo.drawPlayer.dead;
        }
    }
}