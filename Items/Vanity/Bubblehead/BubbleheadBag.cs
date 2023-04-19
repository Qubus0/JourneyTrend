using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JourneyTrend.Items.Vanity.Bubblehead
{
    public class BubbleheadBag : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bubblehead Bag");
            Tooltip.SetDefault("Found him!\nBag sprite by PeanutSte\n{$CommonItemTooltip.RightClickToOpen}");
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
            itemLoot.Add(ItemDropRule.Common(ItemType<BubbleheadLegs>()));
            itemLoot.Add(ItemDropRule.Common(ItemType<BubbleheadBody>()));
            itemLoot.Add(ItemDropRule.Common(ItemType<BubbleheadHead>()));
        }
    }
}