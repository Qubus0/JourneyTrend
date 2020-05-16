using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace JourneyTrend.Items.Vanity.MagicGrill
{
    [AutoloadEquip(EquipType.Head)]
    public class MagicGrillHead : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("[c/ff9ecc:Magic Shark Top]");
            Tooltip.SetDefault("Boss may be proud!\nMade by Pepsi.");
        }
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = 1;
            item.vanity = true;
        }
        public override void DrawHair(ref bool drawHair, ref bool drawAltHair)
        {
            drawAltHair = true;
        }
    }
}