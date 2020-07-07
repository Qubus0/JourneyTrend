using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JourneyTrend.Items.Vanity.NineTailedFox
{
    public class NineTailedFoxBag : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Nine-Tailed Fox Bag");
            Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}");
        }

        public override void SetDefaults()
        {
            item.maxStack = 999;
            item.consumable = true;
            item.width = 24;
            item.height = 24;
            item.value = 200000;
            item.rare = ItemRarityID.Blue;
        }

        public override bool CanRightClick()
        {
            return true;
        }

        public override void RightClick(Player player)
        {
            player.QuickSpawnItem(ItemType<NineTailedFoxHead>());
            player.QuickSpawnItem(ItemType<NineTailedFoxBody>());
            player.QuickSpawnItem(ItemType<NineTailedFoxLegs>());
            player.QuickSpawnItem(ItemType<NineTailedFoxAcc>());
        }
    }
}