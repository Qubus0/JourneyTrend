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
        
        protected override int GetShader(PlayerDrawSet drawInfo) => drawInfo.cLegs;
        
        public override bool GetDefaultVisibility(PlayerDrawSet drawInfo)
        {
            return drawInfo.drawPlayer.legs == EquipLoader.GetEquipSlot(Mod, "MushroomAlchemistLegs", EquipType.Legs)
                   && !drawInfo.drawPlayer.dead;
        }
    }
}