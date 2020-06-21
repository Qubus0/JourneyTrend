using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.CommonKingfisher
{
    [AutoloadEquip(EquipType.Legs)]
    public class KingfisherLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Common Kingfisher Pants");
            Tooltip.SetDefault("Hunger is the only story he has ever heard in his life.\nReligiously, he swallows the silver leaf.\nAlcedo atthis Approved!\nMade by Squidcrane");
        }
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.Blue;
            item.vanity = true;
        }
    }
}