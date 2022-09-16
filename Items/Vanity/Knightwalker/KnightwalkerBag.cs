using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JourneyTrend.Items.Vanity.Knightwalker
{
    public class KnightwalkerBag : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The Knightwalker's Bag");
            Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}");
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
            itemLoot.Add(ItemDropRule.Common(ItemType<KnightwalkerLegs>()));
            itemLoot.Add(ItemDropRule.Common(ItemType<KnightwalkerBody>()));
            itemLoot.Add(ItemDropRule.Common(ItemType<KnightwalkerHead>()));
        }
    }
}