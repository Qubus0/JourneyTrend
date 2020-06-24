using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JourneyTrend.Items.Vanity.RookieSet
{
    public class RookieBag : ModItem
    {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Rookie Bag");
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
            player.QuickSpawnItem(ItemType<RookieLegs>());
            player.QuickSpawnItem(ItemType<RookieBody>());
            player.QuickSpawnItem(ItemType<RookieHead>());
        }
    }
}