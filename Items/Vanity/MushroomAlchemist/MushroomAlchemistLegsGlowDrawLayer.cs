using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.MushroomAlchemist
{
    public class MushroomAlchemistLegsGlowDrawLayer : GlowDrawLayer
    {
        public MushroomAlchemistLegsGlowDrawLayer() : base(
            "JourneyTrend/Items/Vanity/MushroomAlchemist/MushroomAlchemistLegs_Glow")
        {
        }

        // before/after from back to front - behind/in front
        public override Position GetDefaultPosition() => new AfterParent(PlayerDrawLayers.Shoes);

        protected override Rectangle GetPlayerFrame(PlayerDrawSet drawInfo) => drawInfo.drawPlayer.legFrame;
        
        public override bool GetDefaultVisibility(PlayerDrawSet drawInfo)
        {
            return drawInfo.drawPlayer.legs == Mod.GetEquipSlot("MushroomAlchemistLegs", EquipType.Legs)
                   && !drawInfo.drawPlayer.dead;
        }
    }
}