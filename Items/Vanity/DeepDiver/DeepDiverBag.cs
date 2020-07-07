using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JourneyTrend.Items.Vanity.DeepDiver
{
    public class DeepDiverBag : ModItem
    {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Deep Diver's Disguise Bag");
            Tooltip.SetDefault("Sprinting assisted by Curt 'Bucket Face' Black\n{$CommonItemTooltip.RightClickToOpen}");
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
            player.QuickSpawnItem(ItemType<DeepDiverLegs>());
            player.QuickSpawnItem(ItemType<DeepDiverBody>());
            player.QuickSpawnItem(ItemType<DeepDiverHead>());
        }
    }
}
