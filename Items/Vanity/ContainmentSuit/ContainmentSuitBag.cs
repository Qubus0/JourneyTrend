using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;


namespace JourneyTrend.Items.Vanity.ContainmentSuit
{
    public class ContainmentSuitBag : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Containment Suit Bag");
            Tooltip.SetDefault("Spriting assisted by Curt 'Bucket Face' Black\n{$CommonItemTooltip.RightClickToOpen}");
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
            player.QuickSpawnItem(ItemType<ContainmentSuitHead>());
            player.QuickSpawnItem(ItemType<ContainmentSuitBody>());
            player.QuickSpawnItem(ItemType<ContainmentSuitLegs>());
        }
    }
}