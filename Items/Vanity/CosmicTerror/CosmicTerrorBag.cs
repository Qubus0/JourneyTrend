using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JourneyTrend.Items.Vanity.CosmicTerror
{
    public class CosmicTerrorBag : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cosmic Terror Bag");
            Tooltip.SetDefault("Bag sprite by PeanutSte\n{$CommonItemTooltip.RightClickToOpen}");
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
            itemLoot.Add(ItemDropRule.Common(ItemType<CosmicTerrorLegs>()));
            itemLoot.Add(ItemDropRule.Common(ItemType<CosmicTerrorBody>()));
            itemLoot.Add(ItemDropRule.Common(ItemType<CosmicTerrorHead>()));
        }
    }
}