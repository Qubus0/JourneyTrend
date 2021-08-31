using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Draugr
{
    [AutoloadEquip(EquipType.Legs)]
    public class DraugrLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Draugr Greaves");
            Tooltip.SetDefault("Made by tic");
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.Orange;
            Item.vanity = true;
        }
    }
}