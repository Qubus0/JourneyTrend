using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JourneyTrend.Items.Vanity.Duality
{
    public class DualityBag : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Duality Bag");
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
            itemLoot.Add(ItemDropRule.Common(ItemType<DualityLegs>()));
            itemLoot.Add(ItemDropRule.Common(ItemType<DualityBody>()));
            itemLoot.Add(ItemDropRule.Common(ItemType<DualityHead>()));
        }
    }
}