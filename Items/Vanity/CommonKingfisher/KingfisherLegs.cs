using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace JourneyTrend.Items.Vanity.CommonKingfisher
{
    [AutoloadEquip(EquipType.Legs)]
    public class KingfisherLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Common Kingfisher Pants");
            Tooltip.SetDefault("Hunger is the only story he has ever heard in his life.\nReligiously, he swallows the silver leaf.\nA. atthis Approved!");
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