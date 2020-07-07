using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JourneyTrend.Items.Vanity.Knightwalker
{
    public class KnightwalkerBag : ModItem
    {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("The Knightwalker's Bag");
            Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}");
        }

        public override void SetDefaults() {
            item.maxStack = 999;
            item.consumable = true;
            item.width = 24;
            item.height = 24;
            item.rare = ItemRarityID.Blue;
        }

        public override bool CanRightClick() {
            return true;
        }

        public override void RightClick(Player player) {
            player.QuickSpawnItem(ItemType<KnightwalkerLegs>());
            player.QuickSpawnItem(ItemType<KnightwalkerBody>());
            player.QuickSpawnItem(ItemType<KnightwalkerHead>());
        }

    }
}