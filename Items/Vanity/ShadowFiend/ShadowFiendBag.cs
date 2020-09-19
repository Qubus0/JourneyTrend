using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JourneyTrend.Items.Vanity.ShadowFiend
{
    public class ShadowFiendBag : ModItem
    {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Shadow Fiend's Bag");
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
            player.QuickSpawnItem(ItemType<ShadowFiendLegs>());
            player.QuickSpawnItem(ItemType<ShadowFiendBody>());
            player.QuickSpawnItem(ItemType<ShadowFiendHead>());
        }
    }
}