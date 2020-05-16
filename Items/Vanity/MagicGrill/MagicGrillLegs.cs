using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace JourneyTrend.Items.Vanity.MagicGrill
{
    [AutoloadEquip(EquipType.Legs)]
    public class MagicGrillLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("[c/ff9ecc:Magic Shark Skirt]");
            Tooltip.SetDefault("Use carefully on windy days.\nMade by Pepsi.");
        }
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = 1;
            item.vanity = true;
        }
    }
}