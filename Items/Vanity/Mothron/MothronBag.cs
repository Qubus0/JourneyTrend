using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JourneyTrend.Items.Vanity.Mothron
{
    public class MothronBag : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mothron Bag");
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
            player.QuickSpawnItem(ItemType<MothronLegs>());
            player.QuickSpawnItem(ItemType<MothronBody>());
            player.QuickSpawnItem(ItemType<MothronHead>());
            player.QuickSpawnItem(ItemID.MothronWings);
        }
    }
}