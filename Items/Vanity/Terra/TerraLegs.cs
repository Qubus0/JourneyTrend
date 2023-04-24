using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Terra
{
    [AutoloadEquip(EquipType.Legs)]
    public class TerraLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            DisplayName.SetDefault("Terra Leggings");
            Tooltip.SetDefault(
                "Powers from the edge of nights and the light of new days\nMay this armor help you reach the journey's end\nMade by TerraKingCole614");
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