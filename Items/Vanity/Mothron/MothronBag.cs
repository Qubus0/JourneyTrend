using JourneyTrend.Items.Vanity;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JourneyTrend.Items.Vanity.Mothron
{
    public class MothronBag : ModItem
    {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Mothron Bag");
            Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}");
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

            // //guaranteed drops
            player.QuickSpawnItem(ItemType<MothronPants>());
            player.QuickSpawnItem(ItemType<MothronShirt>());
            player.QuickSpawnItem(ItemType<MothronMask>());

            // randomized from these items
            // int choice = Main.rand.Next(7);
            // if (choice == 0) {
            //     player.QuickSpawnItem(ItemType<PuritySpiritMask>());
            // }
            // else if (choice == 1) {
            //     player.QuickSpawnItem(ItemType<BunnyMask>());
            // }
            // if (choice != 1) {
            //     player.QuickSpawnItem(ItemID.Bunny);
            // }
        }

    }
}