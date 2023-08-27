using Terraria.GameContent.Creative;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JourneyTrend.Items.Vanity.NineTailedFox
{
    public class NineTailedFoxBag : ModItem
    {
        public override void SetStaticDefaults()
        {
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            // DisplayName.SetDefault("Nine-Tailed Fox Bag");
            // Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}");
        }

        public override void SetDefaults()
        {
            Item.maxStack = 999;
            Item.consumable = true;
            Item.width = 24;
            Item.height = 24;
            Item.value = 200000;
            Item.rare = ItemRarityID.Blue;
        }

        public override bool CanRightClick()
        {
            return true;
        }

        public override void ModifyItemLoot(ItemLoot itemLoot)
        {
            itemLoot.Add(ItemDropRule.Common(ItemType<NineTailedFoxAcc>()));
            itemLoot.Add(ItemDropRule.Common(ItemType<NineTailedFoxLegs>()));
            itemLoot.Add(ItemDropRule.Common(ItemType<NineTailedFoxBody>()));
            itemLoot.Add(ItemDropRule.Common(ItemType<NineTailedFoxHead>()));
        }
    }
}