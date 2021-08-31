using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JourneyTrend.Items.Vanity.Terra
{
    public class TerraBag : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Terra Bag");
            Tooltip.SetDefault(
                "Spriting assisted by Chan, Lotaru and Cakeboiii\n{$CommonItemTooltip.RightClickToOpen}");
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
            player.QuickSpawnItem(ItemType<TerraLegs>());
            player.QuickSpawnItem(ItemType<TerraBody>());
            player.QuickSpawnItem(ItemType<TerraHead>());
        }
    }
}