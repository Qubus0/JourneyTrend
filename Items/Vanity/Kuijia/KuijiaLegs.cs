using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace JourneyTrend.Items.Vanity.Kuijia
{
    [AutoloadEquip(EquipType.Legs)]
    public class KuijiaLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("[c/ff98ff:Kuijia Legmail]");
            Tooltip.SetDefault("Used by fighters for splash and impact protection.\nMade by PatisNow.");
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