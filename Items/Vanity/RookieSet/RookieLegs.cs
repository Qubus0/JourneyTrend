using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace JourneyTrend.Items.Vanity.RookieSet
{
    [AutoloadEquip(EquipType.Legs)]
    public class RookieLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Base");
            Tooltip.SetDefault("Stay Grounded.");
        }
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = 1;
            item.vanity = true;
        }
        public override bool DrawLegs()
        {
            return false;
        }
    }
}