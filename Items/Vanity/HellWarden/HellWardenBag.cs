using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JourneyTrend.Items.Vanity.HellWarden
{
    public class HellWardenBag : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hell Warden's Bag");
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
            itemLoot.Add(ItemDropRule.Common(ItemType<HellWardenLegs>()));
            itemLoot.Add(ItemDropRule.Common(ItemType<HellWardenBody>()));
            itemLoot.Add(ItemDropRule.Common(ItemType<HellWardenHead>()));
        }
    }
}