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
            Item.width = 18;
            Item.height = 18;
            Item.value = 150000;
            Item.rare = ItemRarityID.Gray;
            Item.vanity = true;
        }

        public override bool? CanBurnInLava()
        {
            return false;
        }

        public override void DrawHair(ref bool drawHair, ref bool drawAltHair)
        {
            drawAltHair = true;
        }
    }
}