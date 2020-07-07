using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.StarlightDream
{
    [AutoloadEquip(EquipType.Legs)]
    public class StarlightDreamLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Set");
            Tooltip.SetDefault("Tooltip\nMade by Golditale");
        }
        
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.Cyan;
            item.vanity = true;
        }
    }
}