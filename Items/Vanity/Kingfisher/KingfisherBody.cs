using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Kingfisher
{
    [AutoloadEquip(EquipType.Body)]
    public class KingfisherBody : ModItem
    {
        public override void SetStaticDefaults()
        {
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            // DisplayName.SetDefault("Common Kingfisher Shirt");
            /* Tooltip.SetDefault(
                "How could there be a day in your whole life that doesn't have a splash of happiness?\nThe Kingfisher wasn't born to think about it, or anything else!\nAlcedo atthis Approved!\nMade by Squidcrane"); */
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