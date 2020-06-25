using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Traveller
{
    [AutoloadEquip(EquipType.Legs)]
    public class TravellerLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Traveller Pants");
            Tooltip.SetDefault("We've come a long way\nMade by Upixel");
        }
        
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.Green;
            item.vanity = true;
        }
    }
}