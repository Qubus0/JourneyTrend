using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JourneyTrend.Items.Vanity.SeaBuckthornTea
{
    public class SeaBuckthornTeaBag : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sea Buckthorn Tea Bag");
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
            player.QuickSpawnItem(ItemType<SeaBuckthornTeaLegs>());
            player.QuickSpawnItem(ItemType<SeaBuckthornTeaBody>());
            player.QuickSpawnItem(ItemType<SeaBuckthornTeaHead>());
        }
    }
}