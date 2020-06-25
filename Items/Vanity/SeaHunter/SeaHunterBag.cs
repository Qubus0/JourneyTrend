using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace JourneyTrend.Items.Vanity.SeaHunter
{
    public class SeaHunterBag : ModItem
    {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Sea Hunter Bag");
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
            player.QuickSpawnItem(ItemType<SeaHunterHead>());
            player.QuickSpawnItem(ItemType<SeaHunterBody>());
            player.QuickSpawnItem(ItemType<SeaHunterLegs>());
        }
    }
}