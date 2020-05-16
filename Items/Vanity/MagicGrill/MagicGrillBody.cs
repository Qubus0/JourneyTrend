using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace JourneyTrend.Items.Vanity.MagicGrill
{
    [AutoloadEquip(EquipType.Body)]
    public class MagicGrillBody : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("[c/ff9ecc:Magic Shark Head]");
            Tooltip.SetDefault("Dw, it's fake shark leather.\nMade by Pepsi.");
        }
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = 1;
            item.vanity = true;
        }
        public override void DrawHands(ref bool drawHands, ref bool drawArms)
        {
            drawHands = true;
            drawArms = true;
        }
    }
}