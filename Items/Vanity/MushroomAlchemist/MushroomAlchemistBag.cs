using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JourneyTrend.Items.Vanity.MushroomAlchemist
{
    public class MushroomAlchemistBag : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mushroom Alchemist Bag");
            Tooltip.SetDefault("Bag sprite by TerraKingCole614\n{$CommonItemTooltip.RightClickToOpen}");
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
            player.QuickSpawnItem(ItemType<MushroomAlchemistLegs>());
            player.QuickSpawnItem(ItemType<MushroomAlchemistBody>());
            player.QuickSpawnItem(ItemType<MushroomAlchemistHead>());
        }
    }
}