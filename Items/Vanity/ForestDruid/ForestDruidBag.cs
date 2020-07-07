using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace JourneyTrend.Items.Vanity.ForestDruid
{
    public class ForestDruidBag : ModItem
    {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Forest Druid's Bag");
            Tooltip.SetDefault("Sprinting assisted by Drdragonfly\nBag sprite by Curt 'Bucket Face' Black\n{$CommonItemTooltip.RightClickToOpen}");
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
            player.QuickSpawnItem(ItemType<ForestDruidBody>());
            player.QuickSpawnItem(ItemType<ForestDruidHead>());
        }
    }
}
