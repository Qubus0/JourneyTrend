using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Journeyman
{
    [AutoloadEquip(EquipType.Head)]
    public class JourneymanHead : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Journeyman Hat");
            Tooltip.SetDefault("The snazzy hat worn by journeymen.\nMade by poiuygfd");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 150000;
            item.rare = ItemRarityID.Gray;
            item.vanity = true;
        }

        public override bool CanBurnInLava()
        {
            return false;
        }

        public override void DrawHair(ref bool drawHair, ref bool drawAltHair)
        {
            drawAltHair = true;
        }
    }
}