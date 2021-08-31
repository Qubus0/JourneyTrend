using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JourneyTrend.Items.Vanity.Duality
{
    public class DualityBag : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Duality Bag");
            Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}");
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
            player.QuickSpawnItem(ItemType<DualityLegs>());
            player.QuickSpawnItem(ItemType<DualityBody>());
            player.QuickSpawnItem(ItemType<DualityHead>());
        }
    }
}