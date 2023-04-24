using Terraria.GameContent.Creative;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JourneyTrend.Items.Vanity.KnightOfJudgement
{
    public class KnightOfJudgementBag : ModItem
    {
        public override void SetStaticDefaults()
        {
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
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

        public override void ModifyItemLoot(ItemLoot itemLoot)
        {
            itemLoot.Add(ItemDropRule.Common(ItemType<KnightOfJudgementLegs>()));
            itemLoot.Add(ItemDropRule.Common(ItemType<KnightOfJudgementBody>()));
            itemLoot.Add(ItemDropRule.Common(ItemType<KnightOfJudgementHead>()));
        }
    }
}