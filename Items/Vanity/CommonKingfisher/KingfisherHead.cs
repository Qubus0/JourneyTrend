using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace JourneyTrend.Items.Vanity.CommonKingfisher
{
    [AutoloadEquip(EquipType.Head)]
    public class KingfisherHead : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Common Kingfisher Mask");
            Tooltip.SetDefault("The kingfisher rises out of the black wave like a blue flower.\nIn his beak, he carries a silver leaf.\nA. atthis Approved!");
        }
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = 1;
            item.vanity = true;
        }
        public override bool DrawHead()
        {
            return false;
        }
    }
}