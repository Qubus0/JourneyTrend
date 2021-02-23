using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JourneyTrend.Items.Vanity.SeaHunter
{
    public class SeaHunterBag : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sea Hunter Bag");
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
            player.QuickSpawnItem(ItemType<SeaHunterHead>());
            player.QuickSpawnItem(ItemType<SeaHunterBody>());
            player.QuickSpawnItem(ItemType<SeaHunterLegs>());
        }
    }
}