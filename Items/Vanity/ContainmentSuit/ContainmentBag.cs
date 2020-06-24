using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.ContainmentSuit
{
    public class ContainmentBag : ModItem
    {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Containment Suit Bag");
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
            player.QuickSpawnItem(mod.ItemType("ContainmentHead"));
            player.QuickSpawnItem(mod.ItemType("ContainmentBody"));
            player.QuickSpawnItem(mod.ItemType("ContainmentLegs"));
        }
    }
}