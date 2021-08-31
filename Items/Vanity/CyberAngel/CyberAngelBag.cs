using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JourneyTrend.Items.Vanity.CyberAngel
{
    public class CyberAngelBag : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cyber Angel Bag");
            Tooltip.SetDefault(
                "Spriting assisted by Faskeon\nBag sprite by Polish_Soap\n{$CommonItemTooltip.RightClickToOpen}");
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
            player.QuickSpawnItem(ItemType<CyberAngelLegs>());
            player.QuickSpawnItem(ItemType<CyberAngelBody>());
            player.QuickSpawnItem(ItemType<CyberAngelHead>());
        }
    }
}