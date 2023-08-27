using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Kingfisher
{
    [AutoloadEquip(EquipType.Legs)]
    public class KingfisherLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            // DisplayName.SetDefault("Common Kingfisher Pants");
            /* Tooltip.SetDefault(
                "Hunger is the only story he has ever heard in his life.\nReligiously, he swallows the silver leaf.\nAlcedo atthis Approved!\nMade by Squidcrane"); */
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.Blue;
            Item.vanity = true;
            Item.value = 0;
        }
    }
}