using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JourneyTrend.Items.Vanity.IronCore
{
    public class IronCoreBag : ModItem
    {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Knight of the Iron Core Bag");
            Tooltip.SetDefault("Bag sprite by Polish_Soap\n{$CommonItemTooltip.RightClickToOpen}");
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
            player.QuickSpawnItem(ItemType<IronCoreLegs>());
            player.QuickSpawnItem(ItemType<IronCoreBody>());
            player.QuickSpawnItem(ItemType<IronCoreHead>());
        }
    }
}