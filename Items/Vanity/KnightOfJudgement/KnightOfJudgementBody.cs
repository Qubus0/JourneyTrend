using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.KnightOfJudgement
{
    [AutoloadEquip(EquipType.Body)]
    public class KnightOfJudgementBody : ModItem
    {
        public override void SetStaticDefaults()
        {
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            // DisplayName.SetDefault("Knight of Judgement's Chestplate");
            // Tooltip.SetDefault("Made by Silvrsterlng");
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.Blue;
            Item.vanity = true;
        }
    }
}