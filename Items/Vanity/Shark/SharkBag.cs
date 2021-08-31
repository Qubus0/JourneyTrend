using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JourneyTrend.Items.Vanity.Shark
{
    public class SharkBag : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Shark Bag");
            Tooltip.SetDefault("Bag sprite by PeanutSte\n{$CommonItemTooltip.RightClickToOpen}");
        }

        public override void SetDefaults()
        {
            Item.maxStack = 999;
            Item.consumable = true;
            Item.width = 24;
            Item.height = 24;
            Item.rare = ItemRarityID.Blue;
        }

        public override bool CanRightClick()
        {
            return true;
        }

        public override void RightClick(Player player)
        {
            player.QuickSpawnItem(ItemType<SharkLegs>());
            player.QuickSpawnItem(ItemType<SharkBody>());
            player.QuickSpawnItem(ItemType<SharkHead>());
        }
    }
}