using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace JourneyTrend.Items.Vanity.SeaBuckthornTea
{
    [AutoloadEquip(EquipType.Legs)]
    public class SeaLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Butler's Pants and Shoes");
            Tooltip.SetDefault("Cleaned-ironed-polished!\nMade by VaeloroK");
        }
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = 1;
            item.vanity = true;
            item.value = 250000;
        }
    }
}