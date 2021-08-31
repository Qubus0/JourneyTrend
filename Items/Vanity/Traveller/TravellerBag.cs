using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JourneyTrend.Items.Vanity.Traveller
{
    public class TravellerBag : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The Traveller's Bag");
            Tooltip.SetDefault("Spriting assisted by VaeloroK\n{$CommonItemTooltip.RightClickToOpen}");
        }

        public override void SetDefaults()
        {
            Item.maxStack = 999;
            Item.consumable = true;
            Item.width = 24;
            Item.height = 24;
            Item.rare = ItemRarityID.Blue;
        }

        public override bool CanRightClick()
        {
            return true;
        }

        public override void RightClick(Player player)
        {
            player.QuickSpawnItem(ItemType<TravellerLegs>());
            player.QuickSpawnItem(ItemType<TravellerBody>());
            player.QuickSpawnItem(ItemType<TravellerHead>());
        }
    }
}