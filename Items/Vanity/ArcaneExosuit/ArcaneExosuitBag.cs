using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace JourneyTrend.Items.Vanity.ArcaneExosuit
{
    public class ArcaneExosuitBag : ModItem
    {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Arcane Exosuit Bag");
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

        public override void RightClick(Player player)
        {
            player.QuickSpawnItem(ItemType<ArcaneExosuitLegs>());
            player.QuickSpawnItem(ItemType<ArcaneExosuitBody>());
            player.QuickSpawnItem(ItemType<ArcaneExosuitHead>());
        }
    }
}