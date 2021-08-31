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
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.Green;
            Item.vanity = true;
        }
    }
}