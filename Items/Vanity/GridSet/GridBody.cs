using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace JourneyTrend.Items.Vanity.GridSet
{
    [AutoloadEquip(EquipType.Body)]
    public class GridBody : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("[c/550000:Grid's Body Armor]");
            Tooltip.SetDefault("A legendary piece of armor.\nCrafted by Grid.");
        }
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = 1;
            item.vanity = true;
            item.value = 500000;
        }
    }
}