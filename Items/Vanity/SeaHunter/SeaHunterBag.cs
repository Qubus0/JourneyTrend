using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JourneyTrend.Items.Vanity.SeaHunter
{
    public class SeaHunterBag : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sea Hunter Bag");
            Tooltip.SetDefault("Spriting assisted by Faskeon\n{$CommonItemTooltip.RightClickToOpen}");
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
            itemLoot.Add(ItemDropRule.Common(ItemType<SeaHunterLegs>()));
            itemLoot.Add(ItemDropRule.Common(ItemType<SeaHunterBody>()));
            itemLoot.Add(ItemDropRule.Common(ItemType<SeaHunterHead>()));
        }
    }
}