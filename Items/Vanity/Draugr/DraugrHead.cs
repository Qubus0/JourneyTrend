using Terraria.ID;
using Terraria.ModLoader;

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
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.Orange;
            Item.vanity = true;
        }

        public override bool DrawHead()
        {
            return false;
        }
    }
}