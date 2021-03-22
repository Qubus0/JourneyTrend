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
            item.maxStack = 999;
            item.consumable = true;
            item.width = 24;
            item.height = 24;
            item.rare = ItemRarityID.Blue;
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