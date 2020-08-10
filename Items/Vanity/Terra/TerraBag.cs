using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JourneyTrend.Items.Vanity.Terra
{
    public class TerraBag : ModItem
    {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Terra Bag");
            Tooltip.SetDefault("Sprinting assisted by Chan, Lotaru and Cakeboiii\n{$CommonItemTooltip.RightClickToOpen}");
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
            player.QuickSpawnItem(ItemType<TerraLegs>());
            player.QuickSpawnItem(ItemType<TerraBody>());
            player.QuickSpawnItem(ItemType<TerraHead>());
        }

    }
}