using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Treesuit
{
    [AutoloadEquip(EquipType.Head)]
    public class TreesuitHead : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tree Crown");
            Tooltip.SetDefault("Made by Drawter");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.Green;
            item.vanity = true;
        }
    }
}