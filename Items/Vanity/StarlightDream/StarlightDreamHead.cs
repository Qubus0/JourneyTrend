using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.StarlightDream
{
    [AutoloadEquip(EquipType.Head)]
    public class StarlightDreamHead : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Set");
            Tooltip.SetDefault("Tooltip\nMade by Golditale");
        }
        
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.Cyan;
            item.vanity = true;
        }

        public override void DrawHair(ref bool drawHair, ref bool drawAltHair)
        {
            drawAltHair = true;
        }
    }
}

