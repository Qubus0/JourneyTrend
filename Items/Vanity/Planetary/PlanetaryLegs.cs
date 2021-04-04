using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Planetary
{
    [AutoloadEquip(EquipType.Legs)]
    public class PlanetaryLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Planetary Pants");
            Tooltip.SetDefault("Made by Goddigger3_1");
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