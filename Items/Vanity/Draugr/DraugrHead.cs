using Terraria.ModLoader;
using Terraria.ID;

namespace JourneyTrend.Items.Vanity.Draugr
{
    [AutoloadEquip(EquipType.Head)]
    public class DraugrHead : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Draugr Horned Helmet");
            Tooltip.SetDefault("Made by tic");
        }
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.Orange;
            item.vanity = true;
        }
        public override bool DrawHead()
        {
            return false;
        }
    }
}