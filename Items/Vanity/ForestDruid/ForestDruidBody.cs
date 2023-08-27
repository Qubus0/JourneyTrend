using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.ForestDruid
{
    [AutoloadEquip(EquipType.Body)]
    public class ForestDruidBody : ModItem
    {
        public override void SetStaticDefaults()
        {
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            // DisplayName.SetDefault("Forest Druid's Robe");
            // Tooltip.SetDefault("An ancient robe filled with the forest's essence\nMade by Kohi_aue");
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.Green;
            Item.vanity = true;
        }
    }
}