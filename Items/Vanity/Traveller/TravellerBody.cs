using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Traveller
{
    [AutoloadEquip(EquipType.Body)]
    public class TravellerBody : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Traveller Shirt");
            Tooltip.SetDefault("We've come a long way\nMade by Upixel");

            ArmorIDs.Body.Sets.HidesHands[Item.bodySlot] = false;
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