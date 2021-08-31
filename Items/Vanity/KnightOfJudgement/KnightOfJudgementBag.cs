using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JourneyTrend.Items.Vanity.KnightOfJudgement
{
    public class KnightOfJudgementBag : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Knight of Judgement's Bag");
            Tooltip.SetDefault("Spriting assisted by Cakeboiii\n{$CommonItemTooltip.RightClickToOpen}");
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
            player.QuickSpawnItem(ItemType<KnightOfJudgementLegs>());
            player.QuickSpawnItem(ItemType<KnightOfJudgementBody>());
            player.QuickSpawnItem(ItemType<KnightOfJudgementHead>());
        }
    }
}