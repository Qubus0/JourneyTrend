using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JourneyTrend.Items.Vanity.CosmicTerror
{
    public class CosmicTerrorBag : ModItem
    {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Cosmic Terror Bag");
            Tooltip.SetDefault("Bag sprite by PeanutSte\n{$CommonItemTooltip.RightClickToOpen}");
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
            player.QuickSpawnItem(ItemType<CosmicTerrorLegs>());
            player.QuickSpawnItem(ItemType<CosmicTerrorBody>());
            player.QuickSpawnItem(ItemType<CosmicTerrorHead>());
        }
    }
}