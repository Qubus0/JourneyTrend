using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JourneyTrend.Items.Vanity.SwampHorror
{
    public class SwampHorrorBag : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Swamp Horror Bag");
            Tooltip.SetDefault("Spriting assisted by Drdragonfly\n{$CommonItemTooltip.RightClickToOpen}");
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
            itemLoot.Add(ItemDropRule.Common(ItemType<SwampHorrorLegs>()));
            itemLoot.Add(ItemDropRule.Common(ItemType<SwampHorrorBody>()));
            itemLoot.Add(ItemDropRule.Common(ItemType<SwampHorrorHead>()));
        }
    }
}