using JourneyTrend.Items.Vanity;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JourneyTrend.Items.Vanity.Bounty
{
    public class BountyBag : ModItem
    {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Bounty Hunter's Bag");
            Tooltip.SetDefault("{.RightClickToOpen}");
        }

        public override void SetDefaults() {
            item.maxStack = 999;
            item.consumable = true;
            item.width = 24;
            item.height = 24;
            item.rare = 1;
            //item.expert = true;
        }

        public override bool CanRightClick() {
            return true;
        }

        public override void RightClick(Player player) {
            player.QuickSpawnItem(ItemType<BountyLegs>());
            player.QuickSpawnItem(ItemType<BountyBody>());
            player.QuickSpawnItem(ItemType<BountyHead>());
        }

    }
}
