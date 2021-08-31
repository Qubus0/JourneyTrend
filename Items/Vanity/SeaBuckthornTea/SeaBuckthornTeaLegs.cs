using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.SeaBuckthornTea
{
    [AutoloadEquip(EquipType.Legs)]
    public class SeaBuckthornTeaLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Butler's Pants and Shoes");
            Tooltip.SetDefault("Cleaned-ironed-polished!\nMade by VaeloroK");
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.Blue;
            Item.vanity = true;
            Item.value = 250000;
        }
    }
}