using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JourneyTrend.Items.Vanity.Bounty
{
    public class BountyBag : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bounty Hunter's Bag");
            Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}");
        }

        public override void SetDefaults()
        {
            Item.maxStack = 999;
            Item.consumable = true;
            Item.width = 24;
            Item.height = 24;
            Item.rare = ItemRarityID.Blue;
            //Item.expert = true;
        }

        public override bool CanRightClick()
        {
            return true;
        }

        public override void RightClick(Player player)
        {
            player.QuickSpawnItem(ItemType<BountyLegs>());
            player.QuickSpawnItem(ItemType<BountyBody>());
            player.QuickSpawnItem(ItemType<BountyHead>());
        }
    }
}