using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JourneyTrend.Items.Vanity.Nexus
{
    public class NexusBag : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Nexus Bag");
            Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}");
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
            player.QuickSpawnItem(ItemType<NexusLegs>());
            player.QuickSpawnItem(ItemType<NexusBody>());
            player.QuickSpawnItem(ItemType<NexusHead>());
        }
    }
}