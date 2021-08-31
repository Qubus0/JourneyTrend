using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JourneyTrend.Items.Vanity.Grid
{
    public class GridBag : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Grid's Bag");
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
            player.QuickSpawnItem(ItemType<GridLegs>());
            player.QuickSpawnItem(ItemType<GridBody>());
            player.QuickSpawnItem(ItemType<GridHead>());
        }
    }
}