using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.CommonKingfisher
{
    [AutoloadEquip(EquipType.Head)]
    public class KingfisherHead : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Common Kingfisher Mask");
            Tooltip.SetDefault("The kingfisher rises out of the black wave like a blue flower.\nIn his beak, he carries a silver leaf.\nAlcedo atthis Approved!\nMade by Squidcrane");
        }
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.Blue;
            item.vanity = true;
        }
        public override bool DrawHead()
        {
            return false;
        }
    }
}