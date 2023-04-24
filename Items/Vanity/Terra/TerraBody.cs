using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Terra
{
    [AutoloadEquip(EquipType.Body)]
    public class TerraBody : ModItem
    {
        public override void SetStaticDefaults()
        {
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            DisplayName.SetDefault("Terra Chestplate");
            Tooltip.SetDefault(
                "A set of armor created with the power of light and dark\nThe heart is where that power resides\nIt feels nice\nMade by TerraKingCole614");
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.Lime;
            Item.vanity = true;
        }
    }
}