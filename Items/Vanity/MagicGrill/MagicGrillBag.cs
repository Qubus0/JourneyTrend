using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JourneyTrend.Items.Vanity.MagicGrill
{
    public class MagicGrillBag : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Magic Grill Megashark Bag");
            Tooltip.SetDefault("Spriting assisted by Faskeon\n{$CommonItemTooltip.RightClickToOpen}");
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
            player.QuickSpawnItem(ItemType<MagicGrillLegs>());
            player.QuickSpawnItem(ItemType<MagicGrillBody>());
            player.QuickSpawnItem(ItemType<MagicGrillHead>());
        }
    }
}