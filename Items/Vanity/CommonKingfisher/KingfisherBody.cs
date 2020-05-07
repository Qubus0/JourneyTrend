using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace JourneyTrend.Items.Vanity.CommonKingfisher
{
    [AutoloadEquip(EquipType.Body)]
    public class KingfisherBody : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Common Kingfisher Shirt");
            Tooltip.SetDefault("How could there be a day in your whole life that doesn't have a splash of happiness?\nThe Kingfisher wasn't born to think about it, or anything else!\nA. atthis Approved!");
        }
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = 1;
            item.vanity = true;
        }
    }
}