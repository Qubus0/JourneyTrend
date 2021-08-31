using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Treesuit
{
    [AutoloadEquip(EquipType.Body)]
    public class TreesuitBody : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tree Shirt");
            Tooltip.SetDefault("Made by Drawter");
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.Green;
            Item.vanity = true;
        }
    }
}