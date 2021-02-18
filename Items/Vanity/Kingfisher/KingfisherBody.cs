using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Kingfisher
{
    [AutoloadEquip(EquipType.Body)]
    public class KingfisherBody : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Common Kingfisher Shirt");
            Tooltip.SetDefault(
                "How could there be a day in your whole life that doesn't have a splash of happiness?\nThe Kingfisher wasn't born to think about it, or anything else!\nAlcedo atthis Approved!\nMade by Squidcrane");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.Blue;
            item.vanity = true;
            item.value = 0;
        }
    }
}