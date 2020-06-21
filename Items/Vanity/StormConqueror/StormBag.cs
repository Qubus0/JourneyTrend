using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.StormConqueror
{
    public class StormBag : ModItem
    {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Storm Conqueror's Bag");
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
            player.QuickSpawnItem(mod.ItemType("StormLegs"));
            player.QuickSpawnItem(mod.ItemType("StormBody"));
            player.QuickSpawnItem(mod.ItemType("StormHead"));
        }
    }
}