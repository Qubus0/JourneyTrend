using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JourneyTrend.Items.Vanity.Shootsaton
{
    public class ShootsatonBag : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sire Shootsaton Bag");
            Tooltip.SetDefault(
                "Spriting assisted by Faskeon\nBag sprite by PeanutSte\n{$CommonItemTooltip.RightClickToOpen}");
        }

        public override void SetDefaults()
        {
            item.maxStack = 999;
            item.consumable = true;
            item.width = 24;
            item.height = 24;
            item.rare = ItemRarityID.Blue;
        }

        public override bool CanRightClick()
        {
            return true;
        }

        public override void RightClick(Player player)
        {
            player.QuickSpawnItem(ItemType<ShootsatonLegs>());
            player.QuickSpawnItem(ItemType<ShootsatonBody>());
            player.QuickSpawnItem(ItemType<ShootsatonHead>());
        }
    }
}