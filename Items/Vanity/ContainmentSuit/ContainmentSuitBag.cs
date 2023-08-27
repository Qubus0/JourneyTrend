using Terraria.GameContent.Creative;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;


namespace JourneyTrend.Items.Vanity.ContainmentSuit
{
    public class ContainmentSuitBag : ModItem
    {
        public override void SetStaticDefaults()
        {
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            // DisplayName.SetDefault("Containment Suit Bag");
            // Tooltip.SetDefault("Spriting assisted by Curt 'Bucket Face' Black\n{$CommonItemTooltip.RightClickToOpen}");
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
            itemLoot.Add(ItemDropRule.Common(ItemType<ContainmentSuitLegs>()));
            itemLoot.Add(ItemDropRule.Common(ItemType<ContainmentSuitBody>()));
            itemLoot.Add(ItemDropRule.Common(ItemType<ContainmentSuitHead>()));
        }
    }
}